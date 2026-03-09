using System.Xml.Linq;

namespace Walkin_Report.login
{
    public class Token
    {
        public string jwt { get; set; }
        public bool valid { get; set; }

        public string expires_at { get; set; }

        public int seconds_remaining { get; set; }

        public string message { get; set; }
    }
}