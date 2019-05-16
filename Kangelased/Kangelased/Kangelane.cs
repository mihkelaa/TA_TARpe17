using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
	class Kangelane
	{
		private string _Nimi;
		private string _Asukoht;
        private string _SuperNimi;
        private string _v6ime;

		public Kangelane(string Nimi, string Asukoht, string SuperNimi, string v6ime)
		{
			this.Nimi = Nimi;
			this.Asukoht = Asukoht;
            this._SuperNimi = SuperNimi;
            this._v6ime = v6ime;
		}

		public string Nimi { get => _Nimi; set => _Nimi = value; }
		public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

		public int Päästa(int Ohustatuid)
		{
			return (int)Math.Round(Ohustatuid * .95);
		}
		public override string ToString()
		{
			return Nimi + " hoiab " + Asukoht + " turvalisena.";
		}

        public string AnnaNimi()
        {
            return Nimi;
        }
        public string AnnaSuperNimi()
        {
            return _SuperNimi;
        }
        
        public string AnnaV6ime()
        {
            return _v6ime;
        }
	}
}
