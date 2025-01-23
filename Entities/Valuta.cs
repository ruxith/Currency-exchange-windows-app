using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1061_PICHERMAYER_RUXANDRA.Entities
{
    public class Valuta
    {
        public string ID { get; set; }
        public string Nume { get; set;}
        public string Cod { get; set; }
        public decimal Minim;
        public decimal Maxim;

        public Valuta(string id, string nume, string cod)
        {
            ID = id;
            Nume = nume;
            Cod = cod;
        }

        public Valuta(string nume, string cod, decimal minim, decimal maxim)
        {
            Guid idG = Guid.NewGuid();
            ID = idG.ToString();
            Nume = nume;
            Cod = cod;
            Minim = minim;
            Maxim = maxim;
        }

        public Valuta()
        {
        }
    }
}
