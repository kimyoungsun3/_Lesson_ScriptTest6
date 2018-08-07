using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ClassesTest2{
	[System.Serializable]
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;

		public Stuff(int bul, int gre, int roc)
		{
			bullets = bul;
			grenades = gre;
			rockets = roc;
		}
	}
}
