using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	abstract class Kangelane: ISuperV6ime
	{
		protected string _Nimi;
		//private string _Asukoht;
        protected string _SuperNimi;
        protected string _v6ime;

		public Kangelane(string Nimi, /*string Asukoht,*/ string SuperNimi, string V6ime)
		{
			Nimi = _Nimi;
			//this.Asukoht = Asukoht;
            SuperNimi = _SuperNimi;
            V6ime = _v6ime;
		}



        //public string Nimi { get => _Nimi; set => _Nimi = value; }
        //public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

        public int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * .95);
        }
        //public override string ToString()
        //{
        //    return Nimi + " hoiab " + Asukoht + " turvalisena.";
        //}

        public string AnnaNimi()
        {
            return _Nimi;
        }
        public string AnnaSuperNimi()
        {
            return _SuperNimi;
        }
        
        public string AnnaV6ime()
        {
            return _v6ime;
        }
        public abstract void V6iduK6ne();
	}
}
