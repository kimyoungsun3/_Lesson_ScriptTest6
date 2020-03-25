using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace _160_UnityEngineTest
{
	/// <summary>
	///   <para>Quaternions are used to represent rotations.</para>
	/// </summary>
	//[NativeType(Header = "Runtime/Math/Quaternion.h")]
	//[UsedByNativeCode]
	public struct Quaternion
	{
		/// <summary>
		///   <para>X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		public float x;

		/// <summary>
		///   <para>Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		public float y;

		/// <summary>
		///   <para>Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.</para>
		/// </summary>
		public float z;

		/// <summary>
		///   <para>W component of the Quaternion. Do not directly modify quaternions.</para>
		/// </summary>
		public float w;

		private readonly static Quaternion identityQuaternion;

		public const float kEpsilon = 1E-06f;

		/// <summary>
		///   <para>Returns or sets the euler angle representation of the rotation.</para>
		/// </summary>
		public Vector3 eulerAngles
		{
			get
			{
				Vector3 vector3 = Quaternion.Internal_MakePositive(
					Quaternion.Internal_ToEulerRad(this) * Mathf.Rad2Deg
					);
				return vector3;
			}
			set
			{
				this = Quaternion.Internal_FromEulerRad(value * Mathf.Deg2Rad);
			}
		}

		/// <summary>
		///   <para>The identity rotation (Read Only).</para>
		/// </summary>
		public static Quaternion identity
		{
			get
			{
				return Quaternion.identityQuaternion;
			}
		}

		public float this[int index]
		{
			get
			{
				float single;
				switch (index)
				{
					case 0:
						{
							single = this.x;
							break;
						}
					case 1:
						{
							single = this.y;
							break;
						}
					case 2:
						{
							single = this.z;
							break;
						}
					case 3:
						{
							single = this.w;
							break;
						}
					default:
						{
							throw new IndexOutOfRangeException("Invalid Quaternion index!");
						}
				}
				return single;
			}
			set
			{
				switch (index)
				{
					case 0:
						{
							this.x = value;
							break;
						}
					case 1:
						{
							this.y = value;
							break;
						}
					case 2:
						{
							this.z = value;
							break;
						}
					case 3:
						{
							this.w = value;
							break;
						}
					default:
						{
							throw new IndexOutOfRangeException("Invalid Quaternion index!");
						}
				}
			}
		}

		static Quaternion()
		{
			Quaternion.identityQuaternion = new Quaternion(0f, 0f, 0f, 1f);
		}

		/// <summary>
		///   <para>Constructs new Quaternion with given x,y,z,w components.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="w"></param>
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		///   <para>Returns the angle in degrees between two rotations a and b.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static float Angle(Quaternion a, Quaternion b)
		{
			float single = Quaternion.Dot(a, b);
			float single1 = Mathf.Acos(Mathf.Min(Mathf.Abs(single), 1f)) * 2f * Mathf.Rad2Deg;
			return single1;
		}

		/// <summary>
		///   <para>Creates a rotation which rotates angle degrees around axis.</para>
		/// </summary>
		/// <param name="angle"></param>
		/// <param name="axis"></param>
		//[ThreadAndSerializationSafe]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_AngleAxis(angle, ref axis, out quaternion);
			return quaternion;
		}

		//[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Quaternion AxisAngle(Vector3 axis, float angle)
		//{
		//	Quaternion quaternion;
		//	Quaternion.INTERNAL_CALL_AxisAngle(ref axis, angle, out quaternion);
		//	return quaternion;
		//}

		/// <summary>
		///   <para>The dot product between two rotations.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static float Dot(Quaternion a, Quaternion b)
		{
			float single = a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
			return single;
		}

		public override bool Equals(object other)
		{
			bool flag;
			if (other is Quaternion)
			{
				Quaternion quaternion = (Quaternion)other;
				flag = (!this.x.Equals(quaternion.x) || !this.y.Equals(quaternion.y) || !this.z.Equals(quaternion.z) ? false : this.w.Equals(quaternion.w));
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		/// <summary>
		///   <para>Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public static Quaternion Euler(float x, float y, float z)
		{
			
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z) * Mathf.Deg2Rad);
			return quaternion;
		}

		/// <summary>
		///   <para>Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis.</para>
		/// </summary>
		/// <param name="euler"></param>
		public static Quaternion Euler(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler * Mathf.Deg2Rad);
		}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Quaternion EulerAngles(float x, float y, float z)
		//{
		//	return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Quaternion EulerAngles(Vector3 euler)
		//{
		//	return Quaternion.Internal_FromEulerRad(euler);
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Quaternion EulerRotation(float x, float y, float z)
		//{
		//	return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Quaternion EulerRotation(Vector3 euler)
		//{
		//	return Quaternion.Internal_FromEulerRad(euler);
		//}

		/// <summary>
		///   <para>Creates a rotation which rotates from fromDirection to toDirection.</para>
		/// </summary>
		/// <param name="fromDirection"></param>
		/// <param name="toDirection"></param>
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_FromToRotation(ref fromDirection, ref toDirection, out quaternion);
			return quaternion;
		}

		public override int GetHashCode()
		{
			int hashCode = this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2 ^ this.w.GetHashCode() >> 1;
			return hashCode;
		}

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AngleAxis(float angle, ref Vector3 axis, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AxisAngle(ref Vector3 axis, float angle, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_FromToRotation(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_FromEulerRad(ref Vector3 euler, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ToAxisAngleRad(ref Quaternion q, out Vector3 axis, out float angle);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_ToEulerRad(ref Quaternion rotation, out Vector3 value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Inverse(ref Quaternion rotation, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Lerp(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LerpUnclamped(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LookRotation(ref Vector3 forward, ref Vector3 upwards, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Slerp(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SlerpUnclamped(ref Quaternion a, ref Quaternion b, float t, out Quaternion value);

		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_Internal_FromEulerRad(ref euler, out quaternion);
			return quaternion;
		}

		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			float single = -0.005729578f;
			float single1 = 360f + single;
			if (euler.x < single)
			{
				euler.x += 360f;
			}
			else if (euler.x > single1)
			{
				euler.x -= 360f;
			}
			if (euler.y < single)
			{
				euler.y += 360f;
			}
			else if (euler.y > single1)
			{
				euler.y -= 360f;
			}
			if (euler.z < single)
			{
				euler.z += 360f;
			}
			else if (euler.z > single1)
			{
				euler.z -= 360f;
			}
			return euler;
		}

		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			Quaternion.INTERNAL_CALL_Internal_ToAxisAngleRad(ref q, out axis, out angle);
		}

		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			Vector3 vector3;
			Quaternion.INTERNAL_CALL_Internal_ToEulerRad(ref rotation, out vector3);
			return vector3;
		}

		/// <summary>
		///   <para>Returns the Inverse of rotation.</para>
		/// </summary>
		/// <param name="rotation"></param>
		public static Quaternion Inverse(Quaternion rotation)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_Inverse(ref rotation, out quaternion);
			return quaternion;
		}

		/// <summary>
		///   <para>Interpolates between a and b by t and normalizes the result afterwards. The parameter t is clamped to the range [0, 1].</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_Lerp(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		/// <summary>
		///   <para>Interpolates between a and b by t and normalizes the result afterwards. The parameter t is not clamped.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_LerpUnclamped(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="forward">The direction to look in.</param>
		/// <param name="upwards">The vector that defines in which direction up is.</param>
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref upwards, out quaternion);
			return quaternion;
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="forward">The direction to look in.</param>
		/// <param name="upwards">The vector that defines in which direction up is.</param>
		//[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			Quaternion quaternion;
			Vector3 vector3 = Vector3.up;
			Quaternion.INTERNAL_CALL_LookRotation(ref forward, ref vector3, out quaternion);
			return quaternion;
		}

		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return Quaternion.Dot(lhs, rhs) > 0.999999f;
		}

		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return !(lhs == rhs);
		}

		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			Quaternion quaternion = new Quaternion(
				lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y, 
				lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z, 
				lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x, 
				lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z);
			return quaternion;
		}

		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			Vector3 vector3 = new Vector3();
			float single = rotation.x * 2f;
			float single1 = rotation.y * 2f;
			float single2 = rotation.z * 2f;
			float single3 = rotation.x * single;
			float single4 = rotation.y * single1;
			float single5 = rotation.z * single2;
			float single6 = rotation.x * single1;
			float single7 = rotation.x * single2;
			float single8 = rotation.y * single2;
			float single9 = rotation.w * single;
			float single10 = rotation.w * single1;
			float single11 = rotation.w * single2;
			vector3.x = (1f - (single4 + single5)) * point.x + (single6 - single11) * point.y + (single7 + single10) * point.z;
			vector3.y = (single6 + single11) * point.x + (1f - (single3 + single5)) * point.y + (single8 - single9) * point.z;
			vector3.z = (single7 - single10) * point.x + (single8 + single9) * point.y + (1f - (single3 + single4)) * point.z;
			return vector3;
		}

		/// <summary>
		///   <para>Rotates a rotation from towards to.</para>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="maxDegreesDelta"></param>
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			Quaternion quaternion;
			float single = Quaternion.Angle(from, to);
			if (single != 0f)
			{
				float single1 = Mathf.Min(1f, maxDegreesDelta / single);
				quaternion = Quaternion.SlerpUnclamped(from, to, single1);
			}
			else
			{
				quaternion = to;
			}
			return quaternion;
		}

		/// <summary>
		///   <para>Set x, y, z and w components of an existing Quaternion.</para>
		/// </summary>
		/// <param name="newX"></param>
		/// <param name="newY"></param>
		/// <param name="newZ"></param>
		/// <param name="newW"></param>
		public void Set(float newX, float newY, float newZ, float newW)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
			this.w = newW;
		}

		//[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		//public void SetAxisAngle(Vector3 axis, float angle)
		//{
		//	this = Quaternion.AxisAngle(axis, angle);
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public void SetEulerAngles(float x, float y, float z)
		//{
		//	this.SetEulerRotation(new Vector3(x, y, z));
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public void SetEulerAngles(Vector3 euler)
		//{
		//	this = Quaternion.EulerRotation(euler);
		//}

		//[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public void SetEulerRotation(float x, float y, float z)
		//{
		//	this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		//}

		////[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
		//public void SetEulerRotation(Vector3 euler)
		//{
		//	this = Quaternion.Internal_FromEulerRad(euler);
		//}

		/// <summary>
		///   <para>Creates a rotation which rotates from fromDirection to toDirection.</para>
		/// </summary>
		/// <param name="fromDirection"></param>
		/// <param name="toDirection"></param>
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="view">The direction to look in.</param>
		/// <param name="up">The vector that defines in which direction up is.</param>
		//[ExcludeFromDocs]
		public void SetLookRotation(Vector3 view)
		{
			this.SetLookRotation(view, Vector3.up);
		}

		/// <summary>
		///   <para>Creates a rotation with the specified forward and upwards directions.</para>
		/// </summary>
		/// <param name="view">The direction to look in.</param>
		/// <param name="up">The vector that defines in which direction up is.</param>
		public void SetLookRotation(Vector3 view,  Vector3 up)
		{
			up = Vector3.up;
			this = Quaternion.LookRotation(view, up);
		}

		/// <summary>
		///   <para>Spherically interpolates between a and b by t. The parameter t is clamped to the range [0, 1].</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_Slerp(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		/// <summary>
		///   <para>Spherically interpolates between a and b by t. The parameter t is not clamped.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			Quaternion quaternion;
			Quaternion.INTERNAL_CALL_SlerpUnclamped(ref a, ref b, t, out quaternion);
			return quaternion;
		}

		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
			angle *= Mathf.Rad2Deg;// 57.29578f;
		}

		////[Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		//public void ToAxisAngle(out Vector3 axis, out float angle)
		//{
		//	Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		//}

		////[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		//public Vector3 ToEuler()
		//{
		//	return Quaternion.Internal_ToEulerRad(this);
		//}

		//[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		//public static Vector3 ToEulerAngles(Quaternion rotation)
		//{
		//	return Quaternion.Internal_ToEulerRad(rotation);
		//}

		////[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
		//public Vector3 ToEulerAngles()
		//{
		//	return Quaternion.Internal_ToEulerRad(this);
		//}

		/// <summary>
		///   <para>Returns a nicely formatted string of the Quaternion.</para>
		/// </summary>
		/// <param name="format"></param>
		public override string ToString()
		{
			return string.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", new object[] { this.x, this.y, this.z, this.w });
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of the Quaternion.</para>
		/// </summary>
		/// <param name="format"></param>
		public string ToString(string format)
		{
			return string.Format("({0}, {1}, {2}, {3})", new object[] { this.x.ToString(format), this.y.ToString(format), this.z.ToString(format), this.w.ToString(format) });
		}
	}
}
