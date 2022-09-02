using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kordamine_OOP.Koduloom;

namespace Kordamine_OOP
{
    class Hamsters : Koduloom
    {
        public enum toug { Djungaria, Hiina, Süüria, Campbelli, Roborovski };
        public toug Toug;


        public Hamsters(toug Toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = Toug;
        }
        public Hamsters(Hamsters hamsters)
        {
            this.Toug = hamsters.Toug;
            this.nimi = hamsters.nimi;
            this.varv = hamsters.varv;
            this.loomaSugu = hamsters.loomaSugu;
            this.kaal = hamsters.kaal;
            this.vanus = hamsters.vanus;
            this.elav = hamsters.elav;

        }
        public override void print_Haal()
        {
            Console.WriteLine("Pi, Pipipipi");
        }

        public override void print_Info()
        {
            Console.WriteLine("{0} hamsters. Nimi: {1} {2} ta on {3} ja tema kaal on {4} gramm ja ta on {5} aastat vana", Toug, nimi, varv, loomaSugu, kaal, vanus);
        }

        public void muudatNimi(string uusNimi) { nimi = uusNimi; }
        public void muudatVarv(string uusVarv) { varv = uusVarv; }
        public void muudatKaal(int uusKaal) { kaal = uusKaal; }
        public void muudatVanus(int uusVanus) { vanus = uusVanus; }
    }

}

