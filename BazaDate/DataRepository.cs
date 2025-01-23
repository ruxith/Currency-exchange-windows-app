using _2_1061_PICHERMAYER_RUXANDRA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1061_PICHERMAYER_RUXANDRA.BazaDate
{
    public class DataRepository
    {
        public List<Valuta> Valuta = new List<Valuta>();
        public List<Tranzactii> Tranzactii = new List<Tranzactii>();
        public List<CursuriValutare> CursuriValutare = new List<CursuriValutare>();

        public void deleteTranzactie(Tranzactii tranzactie)
        {           
            Tranzactii.Remove(tranzactie);
            
        }

        internal void deleteValuta(Valuta val)
        {
            Valuta.Remove(val);
        }
    }
}
