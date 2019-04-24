using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//#if UNITY_EDITOR
//using UnityEditor;
//#endif

namespace SceneTest2_LoadLevelAddtive
{
	public class Ui_ChangeScene3 : MonoBehaviour
	{
		AsyncOperation async;
		public void InvokeAdditiveAsync(Text _text)
		{
			async = Application.LoadLevelAdditiveAsync(_text.text);
			//async.allowSceneActivation = false;
		}

		public void InvokeAllowSceneActivation()
		{
			Debug.Log(async + ":" + async.isDone + ":" + async.allowSceneActivation);
			if (async != null && !async.isDone)
			{
				async.allowSceneActivation = true;
			}
		}

		private void Update()
		{
			if (async != null)
			{
				Debug.Log(this + " >> " + async.progress);
				//EditorApplication.isPlaying = false;
				//EditorApplication.isPaused = true;
			}
		}
	}
}
