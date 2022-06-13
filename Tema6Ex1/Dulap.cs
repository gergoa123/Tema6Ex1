using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6Ex1
{
	public class Dulap
	{
		private int lungime;
		private int latime;
		private int inaltime;

		public Dulap()
		{
			lungime = 1;
			latime = 1;
			inaltime = 1;

		}

		public Dulap(int lungime, int latime, int inaltime)
		{
			this.lungime = lungime;
			this.latime = latime;
			this.inaltime = inaltime;
		}

		public int volum()
		{
			return latime * lungime * inaltime;
		}
	}
}
