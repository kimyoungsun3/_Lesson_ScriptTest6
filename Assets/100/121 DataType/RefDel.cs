using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefDel : MonoBehaviour {

	public List<GameObject> delList;// = new List<GameObject>();

	private void OnMouseDown()
	{
		delList = RefCreate.instance.list;
		if (delList.Count > 0)
		{
			int _idx = Random.Range(0, delList.Count);
			GameObject _go = delList[_idx];

			Destroy(_go);
			delList.Remove(_go);
		}
	}
}
