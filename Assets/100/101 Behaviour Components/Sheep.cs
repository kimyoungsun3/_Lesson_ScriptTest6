using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour {
	Transform targetTrans;
	SpriteRenderer targetRender;
	Sheep3 targetScpSheep3;

	public Sheep3 scpSheep3;
	public GameObject goSheep3;
	public Transform transSheep3;
	public BoxCollider2D colSheep3;

	// Use this for initialization
	void Start () {
		targetTrans = gameObject.GetComponent<Transform> ();
		targetRender = gameObject.GetComponent<SpriteRenderer> ();
		//targetScpSheep3 = gameObject.GetComponent<Sheep3> ();
		//GameObject.Find ("Sheep3");
		//Find xxxxxxx
		//transform.Find
		targetScpSheep3 = scpSheep3;
		targetScpSheep3 = goSheep3.GetComponent<Sheep3>();
		targetScpSheep3 = transSheep3.GetComponent<Sheep3> ();
		targetScpSheep3 = colSheep3.GetComponent<Sheep3> ();

		Debug.Log (targetTrans);
		Debug.Log (targetRender);
		Debug.Log (targetScpSheep3);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
