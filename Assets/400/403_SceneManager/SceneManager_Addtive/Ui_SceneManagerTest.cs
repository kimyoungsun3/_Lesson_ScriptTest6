using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SceneManagerTest
{
	public class Ui_SceneManagerTest : MonoBehaviour
	{
		public void InvokeAdditive(Text _text)
		{
			SceneManager.LoadScene(_text.text, LoadSceneMode.Additive);
			//Application.LoadLevelAdditive(_text.text);
		}

		public void InvokeUnloadScene(Text _text)
		{
			Scene[] _scenes = SceneManager.GetAllScenes();
			bool _bFind = FindScene(_scenes, _text.text);
			Debug.Log(_bFind);
			if (_bFind)
			{
				SceneManager.UnloadScene(_text.text);
			}
		}

		private bool FindScene(Scene[] _scenes, string _name)
		{
			bool _rtn = false;
			for(int i = 0; i < _scenes.Length; i++)
			{
				if (_scenes[i].name.Equals(_name))
				{
					_rtn = true;
					break;
				}
			}
			return _rtn;
		}

		private void Update()
		{
			Debug.Log(
			SceneManager.sceneCountInBuildSettings
			+ ":" + SceneManager.sceneCount
			);
		}

		private void Start()
		{
			SceneManager.sceneLoaded		+= OnSceneLoaded;
			SceneManager.sceneUnloaded		+= OnSceneUnloaded;
			SceneManager.activeSceneChanged += OnActiveSceneChange;
		}

		void OnSceneLoaded(Scene _scene, LoadSceneMode _mode)
		{
			Debug.Log("OnSceneLoaded:" + _scene.name + ":" + _mode);
		}
		void OnSceneUnloaded(Scene _scene)
		{
			Debug.Log("OnSceneUnloaded:" + _scene.name);
		}
		void OnActiveSceneChange(Scene _scene, Scene _scene2)
		{
			Debug.Log("OnActiveSceneChange:" + _scene.name + ":" + _scene2.name);
		}
	}
}
