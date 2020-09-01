using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _189_Rigidbody2_AddForce
{
	public class AddForecTest : MonoBehaviour
	{
		TextMesh text;
		Rigidbody rigidbody;
		[SerializeField] float radius = 2.5f;
		[SerializeField] Vector3 gizmosOffset = new Vector3(0, 0, 0);
		private void OnDrawGizmos()
		{
			DisPlay();
		}
		//private void OnValidate()
		//{
		//	DisPlay();
		//}
		private void DisPlay()
		{
			if(text == null)text = GetComponentInChildren<TextMesh>();
			if (rigidbody == null) rigidbody = GetComponent<Rigidbody>();

			if (text != null && rigidbody != null) text.text = "" + rigidbody.mass.ToString();
			else if (text != null) text.text = "No R";

			if(Application.isPlaying && RayHitAddForce.ins.bDisplayGizmos)
			{
				DrawGizmos();
			}
			else if (!Application.isPlaying)
			{
				DrawGizmos();
			}
		}

		
		private void DrawGizmos()
		{

			Gizmos.color = Color.red;
			Gizmos.DrawRay(transform.position + transform.rotation*gizmosOffset, transform.right * radius);
			Gizmos.color = Color.green;
			Gizmos.DrawRay(transform.position + transform.rotation * gizmosOffset, transform.up * radius);
			Gizmos.color = Color.blue;
			Gizmos.DrawRay(transform.position + transform.rotation * gizmosOffset, transform.forward * radius);
		}
	}
}