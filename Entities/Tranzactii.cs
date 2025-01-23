using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1061_PICHERMAYER_RUXANDRA.Entities
{
    public class Tranzactii
    {
        
        public string ID { get; set; } // Cheie primară
        public string IDValuta { get; set; } //Foreign key
        public string NumeValuta { get; set; }
        public decimal Suma { get; set; }
        public DateTime Data{ get; set; }

        public string Tip { get; set; }

        public Tranzactii(string iD, string iDValuta, string numeValuta, decimal suma, DateTime data, string tip)
        {
            ID = iD;
            IDValuta = iDValuta;
            NumeValuta = numeValuta;
            Suma = suma;
            Data = data;
            Tip = tip;
        }

        public Tranzactii(string iDValuta, string numeValuta, decimal suma, DateTime data, string tip)
        {
            Guid idG = Guid.NewGuid();
            ID = idG.ToString();
            IDValuta = iDValuta;
            NumeValuta = numeValuta;
            Suma = suma;
            Data = data;
            Tip = tip;
        }

        public Tranzactii()
        {
        }
    }
}
