using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	public class Player : MonoBehaviour
	{
		[HideInInspector]public float health;
		public ScriptUserData userdata;

		private void Start()
		{
			health = userdata.health;
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				health -= userdata.damage;
				Debug.Log(this + " > " + health);
			}
		}
	}
}
