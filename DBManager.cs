using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Walkin_Report
{
    public class DBManager
    {
        private string connStr;


        public DBManager()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "dbconfig.xml"
            );

            if (!File.Exists(path))
            {
                MessageBox.Show($"Config file not found:\n{path}");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            string server = doc.SelectSingleNode("/database/server")?.InnerText;
            string db = doc.SelectSingleNode("/database/name")?.InnerText;
            string user = doc.SelectSingleNode("/database/user")?.InnerText;
            string pass = doc.SelectSingleNode("/database/password")?.InnerText;

            if (string.IsNullOrWhiteSpace(server) ||
                string.IsNullOrWhiteSpace(db) ||
                string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Invalid database configuration");
                return;
            }

            connStr = $"Server={server};Database={db};Uid={user};Pwd={pass};";
        }

        public bool test_connection()
        {
            bool conect = false;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    conect = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return conect;
        }

        // ✅ METHOD TO GET ALL STORES
        public List<Store> GetAllStores()
        {
            List<Store> stores = new List<Store>();

            string query = "SELECT id, sym, name FROM store";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.IsDBNull(reader.GetOrdinal("id"))
                                ? 0
                                : reader.GetInt32("id");

                            string sym = reader.IsDBNull(reader.GetOrdinal("sym"))
                                ? string.Empty
                                : reader.GetString("sym");

                            string name = reader.IsDBNull(reader.GetOrdinal("name"))
                                ? string.Empty
                                : reader.GetString("name");

                            Store store = new Store(id, sym, name);
                            stores.Add(store);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return stores;
        }

        public List<Status> GetAllStatuses()
        {
            List<Status> statuses = new List<Status>();

            string query = "SELECT id, status FROM status";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.IsDBNull(reader.GetOrdinal("id"))
                                ? 0
                                : reader.GetInt32("id");

                            string statusText = reader.IsDBNull(reader.GetOrdinal("status"))
                                ? string.Empty
                                : reader.GetString("status");

                            Status status = new Status(id, statusText);
                            statuses.Add(status);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return statuses;
        }

        public List<Walkin> GetAllWalkins()
        {
            List<Walkin> walkins = new List<Walkin>();

            string query = @"SELECT id, name, area, pin, phone, source, team,
                            status, categor, products, store, remarks, created_at, amount, followup
                     FROM walkins";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Walkin walkin = new Walkin(
                                reader.GetString("name"),
                                reader["area"]?.ToString(),
                                reader["pin"]?.ToString(),
                                reader["phone"]?.ToString(),
                                reader["source"]?.ToString(),
                                reader["team"]?.ToString(),
                                reader["status"]?.ToString(),
                                reader["categor"]?.ToString(),
                                reader["products"]?.ToString(),
                                reader.GetString("store"),
                                reader["remarks"]?.ToString(),
                                reader.GetDateTime("created_at")
                            );
                            walkin.Id = reader.GetInt32("id");
                            walkin.amount = reader.GetFloat("amount");
                            walkin.followup = reader.GetInt32("followup");

                            walkins.Add(walkin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return walkins;
        }

        public void InsertWalkin(Walkin w)
        {
            string query = @"
        INSERT INTO walkins
        (name, area, pin, phone, source, team, status, categor, products, store, remarks, created_at, amount, followup)
        VALUES
        (@name, @area, @pin, @phone, @source, @team, @status, @categor, @products, @store, @remarks, @created_at, @amount, @followup);
    ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", w.Name);
                cmd.Parameters.AddWithValue("@area", w.Area);
                cmd.Parameters.AddWithValue("@pin", w.Pin);
                cmd.Parameters.AddWithValue("@phone", w.Phone);
                cmd.Parameters.AddWithValue("@source", w.Source);
                cmd.Parameters.AddWithValue("@team", w.Team);
                cmd.Parameters.AddWithValue("@status", w.Status);
                cmd.Parameters.AddWithValue("@categor", w.Category);
                cmd.Parameters.AddWithValue("@products", w.Products);
                cmd.Parameters.AddWithValue("@store", w.Store);
                cmd.Parameters.AddWithValue("@remarks", w.Remarks);
                cmd.Parameters.AddWithValue("@amount", w.amount);
                cmd.Parameters.AddWithValue("@followup", w.followup);

                cmd.Parameters.Add("@created_at", MySqlDbType.DateTime)
                              .Value = w.CreatedAt;   // ✅ BEST PRACTICE

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            string query = "SELECT id, name, sym FROM categor";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category c = new Category
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("id"))
                                    ? 0
                                    : reader.GetInt32("id"),

                                Name = reader.IsDBNull(reader.GetOrdinal("name"))
                                    ? string.Empty
                                    : reader.GetString("name"),

                                Sym = reader.IsDBNull(reader.GetOrdinal("sym"))
                                    ? string.Empty
                                    : reader.GetString("sym")
                            };

                            categories.Add(c);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return categories;
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            string query = "SELECT id, name, sym FROM staff";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staff s = new Staff
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("id"))
                                    ? 0
                                    : reader.GetInt32("id"),

                                Name = reader.IsDBNull(reader.GetOrdinal("name"))
                                    ? string.Empty
                                    : reader.GetString("name"),

                                Sym = reader.IsDBNull(reader.GetOrdinal("sym"))
                                    ? string.Empty
                                    : reader.GetString("sym")
                            };

                            staffList.Add(s);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return staffList;
        }

        public void UpdateWalkin(Walkin w)
        {
            string query = @"
        UPDATE walkins SET
            name = @name,
            area = @area,
            pin = @pin,
            phone = @phone,
            source = @source,
            team = @team,
            status = @status,
            categor = @categor,
            products = @products,
            store = @store,
            remarks = @remarks,
            created_at = @created_at,
            amount = @amount,
            followup = @followup 
        WHERE id = @id;
    ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", w.Id);
                cmd.Parameters.AddWithValue("@name", w.Name);
                cmd.Parameters.AddWithValue("@area", w.Area);
                cmd.Parameters.AddWithValue("@pin", w.Pin);
                cmd.Parameters.AddWithValue("@phone", w.Phone);
                cmd.Parameters.AddWithValue("@source", w.Source);
                cmd.Parameters.AddWithValue("@team", w.Team);
                cmd.Parameters.AddWithValue("@status", w.Status);
                cmd.Parameters.AddWithValue("@categor", w.Category);
                cmd.Parameters.AddWithValue("@products", w.Products);
                cmd.Parameters.AddWithValue("@store", w.Store);
                cmd.Parameters.AddWithValue("@remarks", w.Remarks);
                cmd.Parameters.AddWithValue("@created_at", w.CreatedAt);
                cmd.Parameters.AddWithValue("@amount", w.amount);
                cmd.Parameters.AddWithValue("@followup", w.followup);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetWalkinColumns()
        {
            List<string> columns = new List<string>();

            string query = @"
        SELECT COLUMN_NAME
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_SCHEMA = DATABASE()
          AND TABLE_NAME = 'walkins';
    ";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader.GetString("COLUMN_NAME"));
                    }
                }
            }

            return columns;
        }

        public bool test_connection_trial(string st)
        {
            bool conect = false;

            using (MySqlConnection conn = new MySqlConnection(st))
            {
                try
                {
                    conn.Open();
                    conect = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return conect;
        }

        public void delete_walkin_by_id(int id)
        {
            string query = "DELETE FROM walkins WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("No record found with the given ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed:\n" + ex.Message);
                }
            }
        }
    }
}
