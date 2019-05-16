using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
     class HeaKangelane : Kangelane
    {
        public HeaKangelane(string Nimi, string SuperNimi, string V6ime) : base(Nimi, SuperNimi, V6ime)
        {
        }

        public override void V6iduK6ne()
        {
            Console.WriteLine("Ma päästsin teid kõiki!");
        }
        public void KasutaV6imet()
        {
            Console.WriteLine("Hea kangelane ", _SuperNimi, " päästab maailma");
        }

    }
}
