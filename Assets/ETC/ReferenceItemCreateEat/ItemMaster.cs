using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaster : MonoBehaviour {
	public ItemInfo scpPrefab;
	public List<ItemInfo> list = new List<ItemInfo> ();

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			ItemInfo _scp = Instantiate (scpPrefab, 
				                Random.insideUnitSphere * 5f, 
				                transform.rotation
			                );
			_scp.SetInfo (
				"name" + list.Count.ToString (),
				Random.Range (100, 200),
				Random.Range (1000, 2000),
				Random.Range (1000, 2000));
			list.Add (_scp);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			foreach (ItemInfo _scp in list) {
				_scp.Display ();
			}
		}
	}
}
