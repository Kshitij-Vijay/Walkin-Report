using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkin_Report
{
    public class Store
    {
        public int Id { get; set; }
        public string Sym { get; set; }
        public string Name { get; set; }

        public Store(int id, string sym, string name)
        {
            Id = id;
            Sym = sym;
            Name = name;
        }
    }

}
