using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace YourProject
{

    public static class HttpService
    {
        private static readonly string base_url = "http://127.0.0.1:8000";
        private static HttpClient client = new HttpClient();

        private static string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MiwibmFtZSI6IktzaGl0aWoiLCJ0eXBlIjoiYWRtaW4iLCJleHAiOjE3NzI4OTYwMTd9.Yb3CnfLf3BRjBPeiZTeDg63wb-5dSXDg_Uv07Ei_Guk";

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

            if (!response.IsSuccessStatusCode)
                throw new Exception("Failed to fetch users");

            string json = await response.Content.ReadAsStringAsync();

            List<Userz> users =
                JsonSerializer.Deserialize<List<Userz>>(json);

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
    }
}