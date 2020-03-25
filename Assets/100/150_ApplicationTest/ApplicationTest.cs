using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;

namespace ApplicationTest
{
	public class ApplicationTest : MonoBehaviour
	{
		[SerializeField] UILabel label;

		private void Start()
		{
			Debug.Log("absoluteURL:" + Application.absoluteURL);
			Debug.Log("backgroundLoadingPriority:" + Application.backgroundLoadingPriority);
			Debug.Log("buildGUID:" + Application.buildGUID);
			Debug.Log("cloudProjectId:" + Application.cloudProjectId);
			Debug.Log("companyName:" + Application.companyName);
			Debug.Log("dataPath:" + Application.dataPath);
			Debug.Log("genuine:" + Application.genuine);
			Debug.Log("genuineCheckAvailable:" + Application.genuineCheckAvailable);
			Debug.Log("identifier:" + Application.identifier);
			Debug.Log("installerName:" + Application.installerName);
			Debug.Log("isEditor:" + Application.isEditor);
			Debug.Log("isFocused:" + Application.isFocused);
			Debug.Log("isPlaying:" + Application.isPlaying);
			Debug.Log("levelCount:" + Application.levelCount);
			Debug.Log("SceneManager.sceneCountInBuildSettings:" + SceneManager.sceneCountInBuildSettings);
			Debug.Log("loadedLevel:" + Application.loadedLevel);
			Debug.Log("SceneManager.GetActiveScene().buildIndex:" + SceneManager.GetActiveScene().buildIndex);
			Debug.Log("loadedLevel:" + Application.loadedLevel);
			Debug.Log("persistentDataPath:" + Application.persistentDataPath);
			Debug.Log("platform:" + Application.platform);
			Debug.Log("productName:" + Application.productName);
			Debug.Log("runInBackground:" + Application.runInBackground);
			Debug.Log("systemLanguage:" + Application.systemLanguage);
			Debug.Log("targetFrameRate:" + Application.targetFrameRate);
			Debug.Log("unityVersion:" + Application.unityVersion);
			Debug.Log("version:" + Application.version);
			GetInfo("Start");
		}

		
		private void Update()
		{
			GetInfo("Update");
		}

		StringBuilder msg = new StringBuilder();
		void GetInfo(string _where)
		{
			msg.Length = 0;
			msg.AppendLine(_where);
			msg.AppendLine("version:" + Application.version);
			msg.AppendLine("identifier:" + Application.identifier);
			//msg.AppendLine("companyName:" + Application.companyName);
			//msg.AppendLine("productName:" + Application.productName);

			msg.AppendLine("");
			msg.AppendLine("dataPath:" + Application.dataPath);
			msg.AppendLine("persistentDataPath:" + Application.persistentDataPath);

			msg.AppendLine(""); 
			msg.AppendLine("isPlaying:" + Application.isPlaying);
			msg.AppendLine("isFocused:" + Application.isFocused);
			msg.AppendLine("platform:" + Application.platform);
			msg.AppendLine("runInBackground:" + Application.runInBackground);
			msg.AppendLine("systemLanguage:" + Application.systemLanguage);
			msg.AppendLine("targetFrameRate:" + Application.targetFrameRate);
			msg.AppendLine("isEditor:" + Application.isEditor);

			label.text = msg.ToString();
		}


		private void OnDrawGizmos()
		{
			GetInfo("OnDrawGizmos");
		}
	}
}
