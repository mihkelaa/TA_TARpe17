using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class PahaKangelane : Kangelane
    {
        public PahaKangelane(string Nimi, string SuperNimi, string V6ime) : base(Nimi, SuperNimi, V6ime)
        {
        
        }
        public override void V6iduK6ne()
        {
            Console.WriteLine("Te kõik surete!");
        }
        public void KasutaV6imet()
        {
            Console.WriteLine("Paha kangelane ",_SuperNimi, " püüab hävitada maailma");
        }
    }
}
