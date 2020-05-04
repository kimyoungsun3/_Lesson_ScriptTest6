using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _109_UpdateAndFixedUpdate
{
	public class LifeCycleU : MonoBehaviour
	{


		void Update()
		{
			Debug.Log("Update :" + Time.deltaTime);
		}


		void FixedUpdate()
		{
			Debug.Log("FixedUpdate :" + Time.deltaTime);
		}
	}
}
