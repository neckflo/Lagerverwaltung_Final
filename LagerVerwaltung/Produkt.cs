using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerVerwaltung
{
    class Produkt                                                   // Get'er Set'er für DB
    {
        public int Nummer { get; set; }
        public string Name { get; set; }
        public string Bezeichnung { get; set; }
        public int Bestand { get; set; }
        public int Lagerort { get; set; }
        public int Preis { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
