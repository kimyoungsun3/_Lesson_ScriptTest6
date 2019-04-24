using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTest : MonoBehaviour {
	public Money money;
	// Use this for initialization
	void Start () {
		money = new Money(0);
		Debug.Log(sizeof(double));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
			money.PlusMoney(Random.Range(-10, -1));
		else if (Input.GetKeyDown(KeyCode.Alpha2))
			money.PlusMoney(Random.Range(+1, +10));

		Debug.Log(money.GetMoney() + ":" + money.ToString());	
	}
}
