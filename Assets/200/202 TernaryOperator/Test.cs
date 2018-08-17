using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ternary{
	public class Test : MonoBehaviour {
		public bool bShow;

		public Light light;
		public SpriteRenderer renderer;

		void Start(){
			OnFunIf ();
			OnFunTernary ();
		}

		void Update(){
			light.enabled = bShow ? true : false;
			renderer.enabled = bShow ? true : false;
		}

		//-------------------------------------
		void OnFunIf(){
			Debug.Log ("FunIf > ");
			if (bShow)
				Debug.Log ("Show");
			else 
				Debug.Log ("Not Show");
				
		}

		void OnFunTernary(){
			Debug.Log ("FunTernary > ");
			Debug.Log( (bShow) ? "Show" : ("Not Show"));
		}
	}
}
