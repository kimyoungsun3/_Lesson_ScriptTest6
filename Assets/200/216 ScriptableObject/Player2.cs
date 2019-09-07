using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	public class Player2 : MonoBehaviour
	{
		[HideInInspector]public float health;
		public ScriptUserData userdata;
		public ScriptUserFun userfun;

		private void Start()
		{
			health = 100 + userdata.health;
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				userfun.CalHealth(this, userdata);
				Debug.Log(this + " > " + health);
			}
		}
	}
}
