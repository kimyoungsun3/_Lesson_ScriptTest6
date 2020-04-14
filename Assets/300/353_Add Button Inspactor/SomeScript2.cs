using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class SomeScript2 : MonoBehaviour {
	public GameObject prefab;
	public Transform spawnPoint;

	public void BuildObject(){

		Transform _t = (Instantiate (prefab, spawnPoint.position + UnityEngine.Random.onUnitSphere*3, Quaternion.identity) as GameObject).transform; 
		_t.SetParent (spawnPoint);
	}

}
