using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEditor;

[CustomEditor(typeof(SomeScript2))]
public class SomeScript2Editor : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector ();

		SomeScript2 _scp = (SomeScript2)target;
		if (GUILayout.Button ("Build Object")) {
			_scp.BuildObject ();
		}
	}

}
