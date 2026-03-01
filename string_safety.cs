using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkin_Report
{
    public class string_safety
    {

        public string Safestring(string tb)
        {
            string val = tb.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                MessageBox.Show("Category is required", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return val;
        }

        public string SafeText(TextBox tb, int maxLen, bool required = false)
        {
            string val = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{tb.Name.Replace("_text", "")} is required");
                return null;
            }

            if (val.Length > maxLen)
                throw new Exception($"{tb.Name.Replace("_text", "")} exceeds {maxLen} characters");

            return val;
        }

        public string SafeCombo(ComboBox cb, bool required = false)
        {
            string val = cb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{cb.Name} must be selected");
                return null;
            }

            return val;
        }

        public decimal? SafeDecimal( TextBox tb, int maxDigitsBeforeDecimal,  int maxDigitsAfterDecimal,  bool required = false)
        {
            string val = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{tb.Name} is required");
                return null;
            }

            // Allow both "." and "," as decimal separator
            val = val.Replace(',', '.');

            if (!decimal.TryParse(
                    val,
                    NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                    CultureInfo.InvariantCulture,
                    out decimal number))
            {
                throw new Exception($"{tb.Name} must be a valid number");
            }

            // Split parts
            string[] parts = val.Split('.');
            string before = parts[0].Replace("-", "");
            string after = parts.Length > 1 ? parts[1] : "";

            if (before.Length > maxDigitsBeforeDecimal)
                throw new Exception($"{tb.Name} exceeds {maxDigitsBeforeDecimal} digits before decimal");

            // ✅ AUTO-ROUND instead of throwing
            if (after.Length > maxDigitsAfterDecimal)
            {
                number = Math.Round(number, maxDigitsAfterDecimal, MidpointRounding.AwayFromZero);
            }

            return number;
        }

        public string SafeNumber(TextBox tb, int maxLen, bool required = false)
        {
            string val = tb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(val))
            {
                if (required)
                    throw new Exception($"{tb.Name} is required");
                return null;
            }

            if (!val.All(char.IsDigit))
                throw new Exception($"{tb.Name} must contain only numbers");

            if (val.Length > maxLen)
                throw new Exception($"{tb.Name} exceeds {maxLen} digits");

            return val;
        }
    }
}
