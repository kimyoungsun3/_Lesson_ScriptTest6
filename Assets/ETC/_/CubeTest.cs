using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour {
	
	public void OnTooltip (bool show){
		if(show)
			Debug.Log (name);

		Ui_ToopTip.ins.Show (name, show, transform.position);
	}
}
