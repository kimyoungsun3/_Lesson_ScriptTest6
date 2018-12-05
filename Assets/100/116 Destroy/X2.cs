using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X2 : MonoBehaviour {
	public enum KIND { D2, D3};
	public Collider rb;
	public Collider2D rb2;
	public int count = 1000;
	public KIND kind = KIND.D2;

	// Use this for initialization
	void Start () {
		if (kind == KIND.D3) {
			for (int i = 0; i < count; i++) {
				Instantiate (rb, Random.insideUnitSphere * 50f, Quaternion.identity);
			}		
		} else {
			for (int i = 0; i < count; i++) {
				Instantiate (rb2, Random.insideUnitSphere * 50f, Quaternion.identity);
			}		
		}
		
	}
}
