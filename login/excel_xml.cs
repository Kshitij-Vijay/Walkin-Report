using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YourProject;

namespace Walkin_Report.login
{
    public class excel_xml
    {
        public string get_xml_tag(string tagName)
        {
            string path = "dbconfig.xml";

            if (!File.Exists(path))
                return null;

            XDocument doc = XDocument.Load(path);

            XElement element = doc.Descendants(tagName).FirstOrDefault();

            if (element == null)
                return null;

            return element.Value;
        }

        public void set_xml_tag(string tagName, string value)
        {
            string path = "dbconfig.xml";

            XDocument doc;

            if (File.Exists(path))
                doc = XDocument.Load(path);
            else
                doc = new XDocument(new XElement("config"));

            XElement element = doc.Descendants(tagName).FirstOrDefault();

            if (element == null)
            {
                doc.Root.Add(new XElement(tagName, value));
            }
            else
            {
                element.Value = value;
            }

            doc.Save(path);
        }

        public static async Task excel_data()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select folder to save Walkins CSV";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string folder = dialog.SelectedPath;
                string file = Path.Combine(folder, "walkins.csv");

                List<Walkin> walkins = await HttpService.GetWalkins();

                StringBuilder csv = new StringBuilder();

                csv.AppendLine("Id,Name,Area,Pin,Phone,Source,Team,Status,Category,Products,Store,Remarks,Amount,Followup,CreatedAt");

                foreach (var w in walkins)
                {
                    csv.AppendLine(
                        $"{w.Id},{w.Name},{w.Area},{w.Pin},{w.Phone},{w.Source},{w.Team},{w.Status},{w.Category},{w.Products},{w.Store},{w.Remarks},{w.amount},{w.followup},{w.CreatedAt}"
                    );
                }

                File.WriteAllText(file, csv.ToString());

                MessageBox.Show("Walkins exported successfully!");
            }
        }

        public static async Task excel_data_full()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select folder to export all data";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string folder = dialog.SelectedPath;

                var walkins = await HttpService.GetWalkins();
                var stores = await HttpService.GetStores();
                var status = await HttpService.GetStatus();
                var staff = await HttpService.GetStaff();
                var categories = await HttpService.GetCategories();

                // Walkins
                StringBuilder wcsv = new StringBuilder();
                wcsv.AppendLine("Id,Name,Area,Pin,Phone,Source,Team,Status,Category,Products,Store,Remarks,Amount,Followup,CreatedAt");

                foreach (var w in walkins)
                {
                    wcsv.AppendLine($"{w.Id},{w.Name},{w.Area},{w.Pin},{w.Phone},{w.Source},{w.Team},{w.Status},{w.Category},{w.Products},{w.Store},{w.Remarks},{w.amount},{w.followup},{w.CreatedAt}");
                }

                File.WriteAllText(Path.Combine(folder, "walkins.csv"), wcsv.ToString());

                // Stores
                StringBuilder scsv = new StringBuilder();
                scsv.AppendLine("Id,Sym,Name");

                foreach (var s in stores)
                    scsv.AppendLine($"{s.Id},{s.Sym},{s.Name}");

                File.WriteAllText(Path.Combine(folder, "stores.csv"), scsv.ToString());

                // Status
                StringBuilder stcsv = new StringBuilder();
                stcsv.AppendLine("Id,Name");

                foreach (var s in status)
                    stcsv.AppendLine($"{s.Id},{s.Name}");

                File.WriteAllText(Path.Combine(folder, "status.csv"), stcsv.ToString());

                // Staff
                StringBuilder staffcsv = new StringBuilder();
                staffcsv.AppendLine("Id,Name,Sym");

                foreach (var s in staff)
                    staffcsv.AppendLine($"{s.Id},{s.Name},{s.Sym}");

                File.WriteAllText(Path.Combine(folder, "staff.csv"), staffcsv.ToString());

                // Categories
                StringBuilder ccsv = new StringBuilder();
                ccsv.AppendLine("Id,Name,Sym");

                foreach (var c in categories)
                    ccsv.AppendLine($"{c.Id},{c.Name},{c.Sym}");

                File.WriteAllText(Path.Combine(folder, "categories.csv"), ccsv.ToString());

                MessageBox.Show("All data exported successfully!");
            }
        }
    }
}
