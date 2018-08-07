using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit {

	public Fruit(){
		Debug.Log ("1st Fruit Constructor Called");
	}

	public virtual void Chop()
	{
		Debug.Log ("Fruit Chop");
	}

	public virtual void SayHello()
	{
		Debug.Log ("Fruit SayHello");
	}
}
