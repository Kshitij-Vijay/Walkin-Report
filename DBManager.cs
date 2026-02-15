using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Walkin_Report
{
    public class DBManager
    {
        private readonly string connStr =
            "server=localhost;user=root;database=walkin;password=minu_me0w;";

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
                            Store store = new Store(
                                reader.GetInt32("id"),
                                reader.GetString("sym"),
                                reader.GetString("name")
                            );

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
                            Status status = new Status(
                                reader.GetInt32("id"),
                                reader.GetString("status")
                            );

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
                            status, categor, products, store, remarks
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
                                reader["remarks"]?.ToString()
                            );

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
        (name, area, pin, phone, source, team, status, categor, products, store, remarks)
        VALUES
        (@name, @area, @pin, @phone, @source, @team, @status, @categor, @products, @store, @remarks);    ";

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

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            string query = "SELECT id, name, sym FROM categor";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category c = new Category
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Sym = reader.GetString("sym")
                        };

                        categories.Add(c);
                    }
                }
            }

            return categories;
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            string query = "SELECT id, name, sym FROM staff";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Staff s = new Staff
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Sym = reader.GetString("sym")
                        };

                        staffList.Add(s);
                    }
                }
            }

            return staffList;
        }
    }
}
