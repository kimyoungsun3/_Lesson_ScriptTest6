using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Humanoid human = new Humanoid ();
		Enemy enemy = new Enemy ();
		Orc orc = new Orc ();

		human.Yell ();	//human
		enemy.Yell ();	//enemy
		orc.Yell ();	//orc


		Humanoid human2 = new Humanoid ();
		Humanoid enemy2 = new Enemy ();
		Humanoid orc2 = new Orc ();

		human2.Yell ();	//human
		enemy2.Yell ();	//human
		orc2.Yell ();	//human
	}

}
