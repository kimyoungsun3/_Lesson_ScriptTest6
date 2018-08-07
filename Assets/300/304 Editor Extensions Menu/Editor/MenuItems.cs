using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuItems {

	[MenuItem("Tools/Clear PlayerPrefs %#.")]
	private static void ClearPlayerPrefs()
	{
		Debug.Log (" > Clear PlayerPrefs");
		PlayerPrefs.DeleteAll ();		
	}

	[MenuItem("Tools/SubMenu/Option")]
	private static void NewSubMenuOption(){
		Debug.Log (" > NewSubMenuOption");
	}

	[MenuItem("Window/New Option")]
	private static void NewOption(){
		Debug.Log (" > NewOption");
	}

	//------------------------------
	[MenuItem("Assets/Load Additive Scene")]
	private static void LoadAdditiveScene(){
		Debug.Log (" > LoadAdditiveScene");
		//var selected = Selection.activeObject;
		//EditorApplication.OpenSceneAdditive (AssetDatabase.GetAssetPath (selected));
	}

	[MenuItem("Assets/Create/Add Configuration")]
	private static void AddConfig(){
		Debug.Log (" > AddConfig");
	}

	[MenuItem("CONTEXT/Rigidbody/New Option")]
	private static void NewOpenForRigidbody(){
		Debug.Log (" > New Option");
	}
}
