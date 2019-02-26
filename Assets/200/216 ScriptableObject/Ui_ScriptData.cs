using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptableObjectTest
{
	public class Ui_ScriptData : MonoBehaviour
	{
		public ScriptData saveData;
		public UILabel label;

		public static int idxStatic = 0;
		public int idxNormal = 0;
		public UILabel label2;

		private void Start()
		{
			if (saveData != null)
			{
				idxStatic++;
				idxNormal++;
				label2.text = idxStatic + ":" + idxNormal;

				label.text = saveData.idx.ToString();
			}
		}

		public void InvokeIncreaseData()
		{
			if(saveData != null)
			{
				saveData.idx++;
				label.text = saveData.idx.ToString();
			}
		}

		public void InvokeSubMethod()
		{
			if (saveData != null)
			{
				saveData.Double();
				label.text = saveData.idx.ToString();
			}
		}

		public int nextIdx;
		public void InvokeNextScene()
		{
			//Scene _scene = SceneManager.GetActiveScene();
			//int _idx = _scene.buildIndex;
			//_idx += 1;
			//Debug.Log("a " + _idx + ":" + _scene.buildIndex + ":" + SceneManager.sceneCount);
			//_idx = _idx >= SceneManager.sceneCount ? 0 : SceneManager.sceneCount;
			//Debug.Log("b " + _idx + ":" + _scene.buildIndex);
			SceneManager.LoadScene(nextIdx);
		}
	}
}
