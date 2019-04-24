using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SceneTest2_LoadLevelAddtive
{
	public class Ui_ChangeScene2 : MonoBehaviour
	{

		//void

		public void InvokeAdditive(Text _text)
		{
			Application.LoadLevelAdditive(_text.text);
		}
	}
}
