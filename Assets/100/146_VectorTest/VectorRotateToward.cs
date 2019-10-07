using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _146_VectorTest
{
	public class VectorRotateToward : MonoBehaviour
	{
		[SerializeField] Transform p1;
		[SerializeField] float speedRadius = 2f;
		[SerializeField] float speedDegree = 2f;
		public bool bModeRadius = true;
		public bool bClear = false;
		private void Update()
		{

			if (bModeRadius)
			{
				Vector3 _dir = p1.position - transform.position;
				Vector3 _dir2 = Vector3.RotateTowards(transform.forward, _dir, speedRadius * Time.deltaTime, 0);
				Debug.DrawRay(transform.position, _dir2, Color.red);
				transform.rotation = Quaternion.LookRotation(_dir2);
			}
			else
			{
				Vector3 _dir = p1.position - transform.position;
				Quaternion _dirQ = Quaternion.LookRotation(_dir);
				transform.rotation = Quaternion.RotateTowards(transform.rotation, _dirQ, speedDegree * Time.deltaTime);
			}


			if (bClear)
			{
				bClear = false;
				transform.rotation = Quaternion.identity;
			}
		}

		//public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		//{
		//	Vector3 vector3;
		//	Vector3.INTERNAL_CALL_RotateTowards(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out vector3);
		//	return vector3;
		//}

		public static float SignedAngle(Vector3 _form, Vector3 _to, Vector3 axis)
		{
			Vector3 _fromNor	= _form.normalized;
			Vector3 _toNor		= _to.normalized;
			float _angle	= Mathf.Acos(Mathf.Clamp(Vector3.Dot(_fromNor, _toNor), -1f, 1f)) * 57.29578f;
			float _sign		= Mathf.Sign(Vector3.Dot(axis, Vector3.Cross(_fromNor, _toNor)));
			return _angle * _sign;
		}

		///// <summary>
		/////   <para>Spherically interpolates between two vectors.</para>
		///// </summary>
		///// <param name="a"></param>
		///// <param name="b"></param>
		///// <param name="t"></param>
		//[ThreadAndSerializationSafe]
		//public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		//{
		//	Vector3 vector3;
		//	Vector3.INTERNAL_CALL_Slerp(ref a, ref b, t, out vector3);
		//	return vector3;
		//}

		///// <summary>
		/////   <para>Spherically interpolates between two vectors.</para>
		///// </summary>
		///// <param name="a"></param>
		///// <param name="b"></param>
		///// <param name="t"></param>
		//public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		//{
		//	Vector3 vector3;
		//	Vector3.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t, out vector3);
		//	return vector3;
		//}

		//[ExcludeFromDocs]
		//public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		//{
		//	float single = Time.deltaTime;
		//	Vector3 vector3 = Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, single);
		//	return vector3;
		//}

		//[ExcludeFromDocs]
		//public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		//{
		//	float single = Time.deltaTime;
		//	float single1 = float.PositiveInfinity;
		//	Vector3 vector3 = Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, single1, single);
		//	return vector3;
		//}

		//public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		//{
		//	smoothTime = Mathf.Max(0.0001f, smoothTime);
		//	float single = 2f / smoothTime;
		//	float single1 = single * deltaTime;
		//	float single2 = 1f / (1f + single1 + 0.48f * single1 * single1 + 0.235f * single1 * single1 * single1);
		//	Vector3 vector3 = current - target;
		//	Vector3 vector31 = target;
		//	vector3 = Vector3.ClampMagnitude(vector3, maxSpeed * smoothTime);
		//	target = current - vector3;
		//	Vector3 vector32 = (currentVelocity + (single * vector3)) * deltaTime;
		//	currentVelocity = (currentVelocity - (single * vector32)) * single2;
		//	Vector3 vector33 = target + ((vector3 + vector32) * single2);
		//	if (Vector3.Dot(vector31 - current, vector33 - vector31) > 0f)
		//	{
		//		vector33 = vector31;
		//		currentVelocity = (vector33 - vector31) / deltaTime;
		//	}
		//	return vector33;
		//}
	}

}