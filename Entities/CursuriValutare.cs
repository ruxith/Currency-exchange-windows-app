using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1061_PICHERMAYER_RUXANDRA.Entities
{
    public class CursuriValutare
    {
        public string ID{ get; set; } 
        public string IDValuta { get; set; }
        public string NumeValuta { get; set; }
        public DateTime DataCursului { get; set; }
        public decimal CursCumparare { get; set; }
        public decimal CursVanzare { get; set; }

        public CursuriValutare(string Id, string iDValuta, string numeValuta, 
            DateTime dataCursului, decimal cursCumparare, decimal cursVanzare)
        {
            ID = Id;
            IDValuta = iDValuta;
            NumeValuta = numeValuta;
            DataCursului = dataCursului;
            CursCumparare = cursCumparare;
            CursVanzare = cursVanzare;
        }

        public CursuriValutare(string iDValuta, string numeValuta,
            DateTime dataCursului, decimal cursCumparare, decimal cursVanzare)
        {
            Guid idG = Guid.NewGuid();
            ID = idG.ToString();
            IDValuta = iDValuta;
            NumeValuta = numeValuta;
            DataCursului = dataCursului;
            CursCumparare = cursCumparare;
            CursVanzare = cursVanzare;
        }

        public CursuriValutare()
        {
        }

    }

}
