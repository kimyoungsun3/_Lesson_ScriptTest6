using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour {
	string name;
	float price, att, def;

	public void SetInfo(string _name, float _price, float _att, float _def){
		name = _name;
		price = _price;
		att = _att;
		def = _def;
	}

	public void Display(){
		Debug.Log (name
			+ " price:" + price
			+ " att:" + att
			+ " def:" + def);
	}
}
