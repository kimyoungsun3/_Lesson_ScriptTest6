using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour {

	System.Action<Monster1> onDestroy;

	public void InitData(float _health, System.Action<Monster1> _on)
	{
		gameObject.SetActive(true);
		onDestroy += _on;
	}

	private void OnMouseDown()
	{
		if(onDestroy != null)
		{
			onDestroy(this);
			onDestroy = null;
		}
	}
}
