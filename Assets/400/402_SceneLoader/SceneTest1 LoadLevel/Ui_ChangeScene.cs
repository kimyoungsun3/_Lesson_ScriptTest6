using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SceneTest1LoadLevel
{
	public class Ui_ChangeScene : MonoBehaviour
	{

		public void InvokeLoadScene(Text _text)
		{
			Application.LoadLevel(_text.text);
			Debug.Log(""
				+ "levelCount:" + Application.levelCount
				+ " loadedLevel:" + Application.loadedLevel
				+ " runInBackground:" + Application.runInBackground
				+ " loadedLevelName:" + Application.loadedLevelName
				);
		}
	}
}