using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Walkin_Report;
using Walkin_Report.login;

namespace YourProject
{

    public static class HttpService
    {
        private static readonly string base_url = "http://127.0.0.1:8000";
        private static HttpClient client = new HttpClient();

        private static string token;

        // set token after login
        public static void SetToken(string jwt)
        {
            token = jwt;

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }

        // GET USERS
        public static async Task<List<Userz>> GetUsers()
        {
            SetToken(token);

            HttpResponseMessage response =
                await client.GetAsync(base_url + "/users");

            string json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            // If API returned an object (error)
            if (doc.RootElement.ValueKind == JsonValueKind.Object)
            {
                if (doc.RootElement.TryGetProperty("error", out JsonElement err))
                {
                    MessageBox.Show(err.GetString());
                    return null;
                }
            }

            // Otherwise it's an array (users)
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Userz> users =
                JsonSerializer.Deserialize<List<Userz>>(json, options);

            return users;
        }

        public static async Task<List<Walkin_Report.Action>> GetActions()
        {
            HttpResponseMessage response =
                await client.GetAsync(base_url + "/actions");

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to fetch actions");

            string json = await response.Content.ReadAsStringAsync();

            List<Walkin_Report.Action> actions =
                JsonSerializer.Deserialize<List<Walkin_Report.Action>>(json);

            return actions;
        }

        public static async Task<bool> Login(string name, string password)
        {
            var data = new
            {
                name = name,
                password = password
            };

            string json = JsonSerializer.Serialize(data);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response =
                await client.PostAsync(base_url + "/login", content);

            if (!response.IsSuccessStatusCode)
                return false;

            string responseJson =
                await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(responseJson);

            string token =
                doc.RootElement.GetProperty("access_token").GetString();

            SetToken(token);
            excel_xml xm = new excel_xml();
            xm.set_xml_tag("netjwt", token);

            return true;
        }

        public static async Task<HttpResponseMessage> UpdateUser(int id, string name, string type, string roles)
        {
            var data = new
            {
                id = id,
                name = name,
                type = type,
                roles = roles
            };

            string json = JsonSerializer.Serialize(data);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response =
                await client.PostAsync(base_url + "/update_user", content);

            return response;
        }

        public static async Task<Token> token_validity(string token)
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                base_url + "/token_validity"
            );

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = await client.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();

            Token result =
                JsonSerializer.Deserialize<Token>(json);
            SetToken(token);
            return result;
        }

        public static async Task<(bool success, string message)> Register(string name, string password, string email, string type)
        {
            try
            {
                var data = new
                {
                    name = name,
                    email = email,
                    password = password,
                    type = type
                };

                string json = JsonSerializer.Serialize(data);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =
                    await client.PostAsync(base_url + "/register", content);

                string responseJson =
                    await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(responseJson);

                if (doc.RootElement.TryGetProperty("message", out var msg))
                    return (true, msg.GetString());

                if (doc.RootElement.TryGetProperty("detail", out var err))
                    return (false, err.GetString());

                return (false, "Unknown error");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public static async Task<List<Walkin>> GetWalkins()
        {

            HttpResponseMessage response =
                await client.GetAsync(base_url + "/GetWalkins");

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to fetch walkins");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Walkin> walkins =
                JsonSerializer.Deserialize<List<Walkin>>(json, options);

            return walkins;
        }

        public static async Task<List<Store>> GetStores()
        {
            HttpResponseMessage response =
                await client.GetAsync(base_url + "/GetStores");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Store>>(json, options);
        }

        public static async Task<List<Status>> GetStatus()
        {
            HttpResponseMessage response =
                await client.GetAsync(base_url + "/GetStatus");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Status>>(json, options);
        }

        public static async Task<List<Staff>> GetStaff()
        {
            HttpResponseMessage response =
                await client.GetAsync(base_url + "/GetStaff");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Staff>>(json, options);
        }

        public static async Task<List<Category>> GetCategories()
        {
            HttpResponseMessage response =
                await client.GetAsync(base_url + "/GetCategor");

            string json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Category>>(json, options);
        }
    }
}