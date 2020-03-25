using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DeltaTimeTest
{
	public enum eUpdateType { Update, FixedUpdate}


	public class DeltaTimeCompare2 : MonoBehaviour
	{
		public eUpdateType kind = eUpdateType.Update;
		public float speed = 2f;
		float v;

		private void Start()
		{
			Debug.Log("0. Update move, 1:FixedUpdate");
		}

		void Update()
		{
			v = Input.GetAxisRaw("Vertical");
			if (kind == eUpdateType.Update)
			{
				Debug.Log("Update:" + Time.deltaTime);
				transform.Translate(v * Vector3.forward * speed * Time.deltaTime);
			}
		}

		private void FixedUpdate()
		{
			if (kind == eUpdateType.FixedUpdate)
			{
				Debug.Log("FixedMove:" + Time.fixedDeltaTime);
				transform.Translate(v * Vector3.forward * speed * Time.fixedDeltaTime);
			}
		}
	}
}
