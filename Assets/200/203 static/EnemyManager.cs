using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	//-----------------------------
	public class Enemy{
		public static int enemyCount = 0;
		public Enemy(){
			enemyCount ++;
		}
	}

	public class GenericClass<T>{
		public T item;
	}

	//----------------------------
	void Start () {
		Enemy enemy1 = new Enemy ();
		Enemy enemy2 = new Enemy ();
		Enemy enemy3 = new Enemy ();
		Enemy enemy4 = new Enemy ();

		Debug.Log ("--Class 변수에 static변수 사용, 한번만 초기화--");
		Debug.Log ("static int enemyCount:" + Enemy.enemyCount);

		Debug.Log ("--static class에서 함수 사용--");
		Debug.Log ("static class method(float) : " 	+ Utilities.Add (10.1f, 20.1f));
		Debug.Log ("static class method(int) : " 	+ Utilities.Add (10, 20));

		Debug.Log ("-- T Generic :GetComponent<T>(), List<T>() --");
		GenericClass<int> _gc = new GenericClass<int> ();
		GenericClass<string> _gc2 = new GenericClass<string> ();
		_gc.item = 10;
		_gc2.item = "itemname";
		Debug.Log("Generic class:" + _gc.item);
		Debug.Log("Generic class2:" + _gc2.item);
		Debug.Log ("Generic method :" + Utilities.Add2<int> (10));
	}

}
