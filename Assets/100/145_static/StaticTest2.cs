using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest2 : MonoBehaviour {

	public static StaticTest2 ins;


	public int x1;
	public int x2;
	public static int x3 = -1;

	private void Awake()
	{
		if(ins != null)
		{
			Destroy(gameObject);
			return;
		}
		ins = this;
	}

	void Start () {
	}

	public bool isChange = false;
	void Update () {
		if (isChange == true)

			x1++;
			x2++;
			x3++;
			ins = this;		{
			isChange = false;
		}

		Debug.Log(this  + " >> " + x1 + ", " + x2 + ", " + x3 + ", " + ins.name);

	}
}
