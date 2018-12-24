using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefCreate : MonoBehaviour {

	public List<GameObject> list = new List<GameObject>();
	public GameObject prefabTarget;
	public static RefCreate instance;
	private void Awake()
	{
		instance = this;
	}

	private void OnMouseDown()
	{
		Vector3 _pos = 5f * Random.insideUnitSphere;
		Quaternion _rot = Quaternion.identity;
		GameObject _go = Instantiate(prefabTarget, _pos, _rot);
		list.Add(_go);
		//리스트 추가..
	}
}
