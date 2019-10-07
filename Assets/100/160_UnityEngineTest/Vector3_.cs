using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _160_UnityEngineTest
{
	class Vector3_
	{
		/// <summary>
		///   <para>Representation of 3D vectors and points.</para>
		/// </summary>
		//[NativeType(Header = "Runtime/Math/Vector3.h")]
		//[UsedByNativeCode]
		public struct Vector3
		{
			public const float kEpsilon = 1E-05f;

			/// <summary>
			///   <para>X component of the vector.</para>
			/// </summary>
			public float x;

			/// <summary>
			///   <para>Y component of the vector.</para>
			/// </summary>
			public float y;

			/// <summary>
			///   <para>Z component of the vector.</para>
			/// </summary>
			public float z;

			private readonly static Vector3 zeroVector;

			private readonly static Vector3 oneVector;

			private readonly static Vector3 upVector;

			private readonly static Vector3 downVector;

			private readonly static Vector3 leftVector;

			private readonly static Vector3 rightVector;

			private readonly static Vector3 forwardVector;

			private readonly static Vector3 backVector;

			private readonly static Vector3 positiveInfinityVector;

			private readonly static Vector3 negativeInfinityVector;

			/// <summary>
			///   <para>Shorthand for writing Vector3(0, 0, -1).</para>
			/// </summary>
			public static Vector3 back
			{
				get
				{
					return Vector3.backVector;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(0, -1, 0).</para>
			/// </summary>
			public static Vector3 down
			{
				get
				{
					return Vector3.downVector;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(0, 0, 1).</para>
			/// </summary>
			public static Vector3 forward
			{
				get
				{
					return Vector3.forwardVector;
				}
			}

			//[Obsolete("Use Vector3.forward instead.")]
			//public static Vector3 fwd
			//{
			//	get
			//	{
			//		return new Vector3(0f, 0f, 1f);
			//	}
			//}

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
						default:
							{
								throw new IndexOutOfRangeException("Invalid Vector3 index!");
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
						default:
							{
								throw new IndexOutOfRangeException("Invalid Vector3 index!");
							}
					}
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(-1, 0, 0).</para>
			/// </summary>
			public static Vector3 left
			{
				get
				{
					return Vector3.leftVector;
				}
			}

			/// <summary>
			///   <para>Returns the length of this vector (Read Only).</para>
			/// </summary>
			public float magnitude
			{
				get
				{
					float single = Mathf.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
					return single;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).</para>
			/// </summary>
			public static Vector3 negativeInfinity
			{
				get
				{
					return Vector3.negativeInfinityVector;
				}
			}

			/// <summary>
			///   <para>Returns this vector with a magnitude of 1 (Read Only).</para>
			/// </summary>
			public Vector3 normalized
			{
				get
				{
					return Vector3.Normalize(this);
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(1, 1, 1).</para>
			/// </summary>
			public static Vector3 one
			{
				get
				{
					return Vector3.oneVector;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).</para>
			/// </summary>
			public static Vector3 positiveInfinity
			{
				get
				{
					return Vector3.positiveInfinityVector;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(1, 0, 0).</para>
			/// </summary>
			public static Vector3 right
			{
				get
				{
					return Vector3.rightVector;
				}
			}

			/// <summary>
			///   <para>Returns the squared length of this vector (Read Only).</para>
			/// </summary>
			public float sqrMagnitude
			{
				get
				{
					return this.x * this.x + this.y * this.y + this.z * this.z;
				}
			}

			public float sqrMagnitude2
			{
				get
				{
					return x * x + y * y + z * z;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(0, 1, 0).</para>
			/// </summary>
			public static Vector3 up
			{
				get
				{
					return Vector3.upVector;
				}
			}

			/// <summary>
			///   <para>Shorthand for writing Vector3(0, 0, 0).</para>
			/// </summary>
			public static Vector3 zero
			{
				get
				{
					return Vector3.zeroVector;
				}
			}

			static Vector3()
			{
				Vector3.zeroVector = new Vector3(0f, 0f, 0f);
				Vector3.oneVector = new Vector3(1f, 1f, 1f);
				Vector3.upVector = new Vector3(0f, 1f, 0f);
				Vector3.downVector = new Vector3(0f, -1f, 0f);
				Vector3.leftVector = new Vector3(-1f, 0f, 0f);
				Vector3.rightVector = new Vector3(1f, 0f, 0f);
				Vector3.forwardVector = new Vector3(0f, 0f, 1f);
				Vector3.backVector = new Vector3(0f, 0f, -1f);
				Vector3.positiveInfinityVector = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
				Vector3.negativeInfinityVector = new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
			}

			/// <summary>
			///   <para>Creates a new vector with given x, y, z components.</para>
			/// </summary>
			/// <param name="x"></param>
			/// <param name="y"></param>
			/// <param name="z"></param>
			public Vector3(float x, float y, float z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}

			/// <summary>
			///   <para>Creates a new vector with given x, y components and sets z to zero.</para>
			/// </summary>
			/// <param name="x"></param>
			/// <param name="y"></param>
			public Vector3(float x, float y)
			{
				this.x = x;
				this.y = y;
				this.z = 0f;
			}

			/// <summary>
			///   <para>Returns the angle in degrees between from and to.</para>
			/// </summary>
			/// <param name="from">The vector from which the angular difference is measured.</param>
			/// <param name="to">The vector to which the angular difference is measured.</param>
			/// <returns>
			///   <para>The angle in degrees between the two vectors.</para>
			/// </returns>
			public static float Angle(Vector3 from, Vector3 to)
			{
				float single = Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f)) * 57.29578f;
				return single;
			}

			public static float Angle2(Vector3 _from, Vector3 _to)
			{
				return Mathf.Acos(Mathf.Clamp(Vector3.Dot(_from.normalized, _to.normalized), -1f, 1f)) * Mathf.Rad2Deg;
			}

			//[Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
			//public static float AngleBetween(Vector3 from, Vector3 to)
			//{
			//	float single = Mathf.Acos(Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
			//	return single;
			//}

			/// <summary>
			///   <para>Returns a copy of vector with its magnitude clamped to maxLength.</para>
			/// </summary>
			/// <param name="vector"></param>
			/// <param name="maxLength"></param>
			public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
			{
				Vector3 vector3;
				vector3 = (vector.sqrMagnitude <= maxLength * maxLength ? vector : vector.normalized * maxLength);
				return vector3;
			}

			public static Vector3 ClampMagnitude2(Vector3 _v, float _maxLength)
			{
				return _v.sqrMagnitude <= _maxLength * _maxLength ? _v : _v.normalized * _maxLength;
			}

			/// <summary>
			///   <para>Cross Product of two vectors.</para>
			/// </summary>
			/// <param name="lhs"></param>
			/// <param name="rhs"></param>
			public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
			{
				Vector3 vector3 = new Vector3(lhs.y * rhs.z - lhs.z * rhs.y, lhs.z * rhs.x - lhs.x * rhs.z, lhs.x * rhs.y - lhs.y * rhs.x);
				return vector3;
			}

			/// <summary>
			///   <para>Returns the distance between a and b.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			public static float Distance(Vector3 a, Vector3 b)
			{
				Vector3 vector3 = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
				float single = Mathf.Sqrt(vector3.x * vector3.x + vector3.y * vector3.y + vector3.z * vector3.z);
				return single;
			}

			public static float Distance2(Vector3 _a, Vector3 _b)
			{
				Vector3 _v = _a - _b;
				return Mathf.Sqrt(_v.x * _v.x + _v.y * _v.y + _v.z * _v.z);
			}

			/// <summary>
			///   <para>Dot Product of two vectors.</para>
			/// </summary>
			/// <param name="lhs"></param>
			/// <param name="rhs"></param>
			public static float Dot(Vector3 lhs, Vector3 rhs)
			{
				float single = lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
				return single;
			}

			public static float Dot2(Vector3 _l, Vector3 _r)
			{
				return _l.x * _r.x + _l.y * _r.y + _l.z * _r.z;
			}

			/// <summary>
			///   <para>Returns true if the given vector is exactly equal to this vector.</para>
			/// </summary>
			/// <param name="other"></param>
			public override bool Equals(object other)
			{
				bool flag;
				if (other is Vector3)
				{
					Vector3 vector3 = (Vector3)other;
					flag = (!this.x.Equals(vector3.x) || !this.y.Equals(vector3.y) ? false : this.z.Equals(vector3.z));
				}
				else
				{
					flag = false;
				}
				return flag;
			}

			public bool Equals2(object other)
			{
				bool _flag = false;

				if (other is Vector3)
				{
					Vector3 _v = (Vector3)other;
					_flag = !x.Equals(_v.x) || !y.Equals(_v.y) || !z.Equals(_v.z);
				}
				return _flag;
			}

			//[Obsolete("Use Vector3.ProjectOnPlane instead.")]
			//public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
			//{
			//	return fromThat - Vector3.Project(fromThat, excludeThis);
			//}

			public override int GetHashCode()
			{
				int hashCode = this.x.GetHashCode() ^ this.y.GetHashCode() << 2 ^ this.z.GetHashCode() >> 2;
				return hashCode;
			}

			//[GeneratedByOldBindingsGenerator]
			//[MethodImpl(MethodImplOptions.InternalCall)]
			//private static extern void INTERNAL_CALL_Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b);

			//[GeneratedByOldBindingsGenerator]
			//[MethodImpl(MethodImplOptions.InternalCall)]
			//private static extern void INTERNAL_CALL_Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c);

			//[GeneratedByOldBindingsGenerator]
			//[MethodImpl(MethodImplOptions.InternalCall)]
			//private static extern void INTERNAL_CALL_RotateTowards(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 value);

			//[GeneratedByOldBindingsGenerator]
			//[MethodImpl(MethodImplOptions.InternalCall)]
			//private static extern void INTERNAL_CALL_Slerp(ref Vector3 a, ref Vector3 b, float t, out Vector3 value);

			//[GeneratedByOldBindingsGenerator]
			//[MethodImpl(MethodImplOptions.InternalCall)]
			//private static extern void INTERNAL_CALL_SlerpUnclamped(ref Vector3 a, ref Vector3 b, float t, out Vector3 value);

			//private static void Internal_OrthoNormalize2(ref Vector3 a, ref Vector3 b)
			//{
			//	Vector3.INTERNAL_CALL_Internal_OrthoNormalize2(ref a, ref b);
			//}

			//private static void Internal_OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
			//{
			//	Vector3.INTERNAL_CALL_Internal_OrthoNormalize3(ref a, ref b, ref c);
			//}

			/// <summary>
			///   <para>Linearly interpolates between two vectors.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <param name="t"></param>
			public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
			{
				t = Mathf.Clamp01(t);
				Vector3 vector3 = new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
				return vector3;
			}

			public static Vector3 Lerp2(Vector3 a, Vector3 b, float t)
			{
				t = Mathf.Clamp01(t);
				return a + (b - a) * t;
			}

			/// <summary>
			///   <para>Linearly interpolates between two vectors.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <param name="t"></param>
			public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
			{
				Vector3 vector3 = new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
				return vector3;
			}

			public static Vector3 LerpUnclamped2(Vector3 a, Vector3 b, float t)
			{
				return a + (b - a) * t;
			}

			public static float Magnitude(Vector3 vector)
			{
				float single = Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
				return single;
			}

			public static float Magnitude2(Vector3 _v)
			{
				return Mathf.Sqrt(_v.x * _v.x + _v.y * _v.y + _v.z * _v.z);
			}

			/// <summary>
			///   <para>Returns a vector that is made from the largest components of two vectors.</para>
			/// </summary>
			/// <param name="lhs"></param>
			/// <param name="rhs"></param>
			public static Vector3 Max(Vector3 lhs, Vector3 rhs)
			{
				Vector3 vector3 = new Vector3(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));
				return vector3;
			}

			public static Vector3 Max2(Vector3 _l, Vector3 _r)
			{
				return new Vector3(Mathf.Max(_l.x, _r.x), Mathf.Max(_l.y, _r.y), Mathf.Max(_l.z, _r.z));
			}

			/// <summary>
			///   <para>Returns a vector that is made from the smallest components of two vectors.</para>
			/// </summary>
			/// <param name="lhs"></param>
			/// <param name="rhs"></param>
			public static Vector3 Min(Vector3 lhs, Vector3 rhs)
			{
				Vector3 vector3 = new Vector3(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));
				return vector3;
			}

			/// <summary>
			///   <para>Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta.</para>
			/// </summary>
			/// <param name="current">The position to move from.</param>
			/// <param name="target">The position to move towards.</param>
			/// <param name="maxDistanceDelta">Distance to move current per call.</param>
			/// <returns>
			///   <para>The new position.</para>
			/// </returns>
			public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
			{
				Vector3 vector3;
				Vector3 vector31 = target - current;
				float single = vector31.magnitude;
				vector3 = (single <= maxDistanceDelta || single < 1.401298E-45f ? target : current + ((vector31 / single) * maxDistanceDelta));
				return vector3;
			}

			public static Vector3 MoveTowards2(Vector3 _current, Vector3 _target, float _maxDistanceDelta)
			{
				Vector3 _dir = _target - _current;
				float _distance = _dir.magnitude;
				return _distance <= _maxDistanceDelta || _distance < float.Epsilon ? _target : _current + _dir / _distance * _maxDistanceDelta;
			}

			/// <summary>
			///   <para>Makes this vector have a magnitude of 1.</para>
			/// </summary>
			/// <param name="value"></param>
			public static Vector3 Normalize(Vector3 value)
			{
				Vector3 vector3;
				float single = Vector3.Magnitude(value);
				vector3 = (single <= 1E-05f ? Vector3.zero : value / single);
				return vector3;
			}

			public static Vector3 Normalize2(Vector3 _v)
			{
				float _distance = Vector3.Magnitude(_v);
				return _distance <= float.Epsilon ? Vector3.zero : _v / _distance;
			}

			public void Normalize()
			{
				float single = Vector3.Magnitude(this);
				if (single <= 1E-05f)
				{
					this = Vector3.zero;
				}
				else
				{
					this /= single;
				}
			}

			public static Vector3 operator +(Vector3 a, Vector3 b)
			{
				Vector3 vector3 = new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
				return vector3;
			}

			//public static Vector3 operator +(Vector3 a, Vector3 b)
			//{
			//	return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
			//}

			//public static Vector3 operator /(Vector3 a, float d)
			//{
			//	Vector3 vector3 = new Vector3(a.x / d, a.y / d, a.z / d);
			//	return vector3;
			//}

			public static Vector3 operator /(Vector3 a, float d)
			{
				return new Vector3(a.x / d, a.y / d, a.z / d);
			}

			//public static bool operator ==(Vector3 lhs, Vector3 rhs)
			//{
			//	return Vector3.SqrMagnitude(lhs - rhs) < 9.99999944E-11f;
			//}

			public static bool operator ==(Vector3 a, Vector3 b)
			{
				return Vector3.SqrMagnitude(a - b) < 9.99999944E-11f;
			}

			//public static bool operator !=(Vector3 lhs, Vector3 rhs)
			//{
			//	return !(lhs == rhs);
			//}

			public static bool operator !=(Vector3 a, Vector3 b)
			{
				return !(a == b);
			}

			//public static Vector3 operator *(Vector3 a, float d)
			//{
			//	Vector3 vector3 = new Vector3(a.x * d, a.y * d, a.z * d);
			//	return vector3;
			//}
			public static Vector3 operator *(Vector3 a, float b)
			{
				return new Vector3(a.x * b, a.y * b, a.z * b);
			}

			//public static Vector3 operator *(float d, Vector3 a)
			//{
			//	Vector3 vector3 = new Vector3(a.x * d, a.y * d, a.z * d);
			//	return vector3;
			//}

			public static Vector3 operator *(float b, Vector3 a)
			{
				return new Vector3(a.x * b, a.y * b, a.z * b);
			}

			//public static Vector3 operator -(Vector3 a, Vector3 b)
			//{
			//	Vector3 vector3 = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
			//	return vector3;
			//}
			public static Vector3 operator -(Vector3 a, Vector3 b)
			{
				return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
			}

			//public static Vector3 operator -(Vector3 a)
			//{
			//	Vector3 vector3 = new Vector3(-a.x, -a.y, -a.z);
			//	return vector3;
			//}

			public static Vector3 operator -(Vector3 a)
			{
				return new Vector3(-a.x, -a.y, -a.z);
			}

			//public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
			//{
			//	Vector3.Internal_OrthoNormalize2(ref normal, ref tangent);
			//}

			//public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
			//{
			//	Vector3.Internal_OrthoNormalize3(ref normal, ref tangent, ref binormal);
			//}

			/// <summary>
			///   <para>Projects a vector onto another vector.</para>
			/// </summary>
			/// <param name="vector"></param>
			/// <param name="onNormal"></param>
			public static Vector3 Project(Vector3 vector, Vector3 onNormal)
			{
				Vector3 vector3;
				float _distance = Vector3.Dot(onNormal, onNormal);
				vector3 = (_distance >= Mathf.Epsilon ? (onNormal * Vector3.Dot(vector, onNormal)) / _distance : Vector3.zero);
				return vector3;
			}

			/// <summary>
			///   <para>Projects a vector onto a plane defined by a normal orthogonal to the plane.</para>
			/// </summary>
			/// <param name="planeNormal">The direction from the vector towards the plane.</param>
			/// <param name="vector">The location of the vector above the plane.</param>
			/// <returns>
			///   <para>The location of the vector on the plane.</para>
			/// </returns>
			public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
			{
				return vector - Vector3.Project(vector, planeNormal);
			}

			/// <summary>
			///   <para>Reflects a vector off the plane defined by a normal.</para>
			/// </summary>
			/// <param name="inDirection"></param>
			/// <param name="inNormal"></param>
			public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
			{
				Vector3 vector3 = (-2f * Vector3.Dot(inNormal, inDirection) * inNormal) + inDirection;
				return vector3;
			}

			/// <summary>
			///   <para>Rotates a vector current towards target.</para>
			/// </summary>
			/// <param name="current">The vector being managed.</param>
			/// <param name="target">The vector.</param>
			/// <param name="maxRadiansDelta">The distance between the two vectors  in radians.</param>
			/// <param name="maxMagnitudeDelta">The length of the radian.</param>
			/// <returns>
			///   <para>The location that RotateTowards generates.</para>
			/// </returns>
			//public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
			//{
			//	Vector3 vector3;
			//	Vector3.INTERNAL_CALL_RotateTowards(ref current, ref target, maxRadiansDelta, maxMagnitudeDelta, out vector3);
			//	return vector3;
			//}

			/// <summary>
			///   <para>Multiplies two vectors component-wise.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			public static Vector3 Scale(Vector3 a, Vector3 b)
			{
				Vector3 vector3 = new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
				return vector3;
			}

			/// <summary>
			///   <para>Multiplies every component of this vector by the same component of scale.</para>
			/// </summary>
			/// <param name="scale"></param>
			public void Scale(Vector3 scale)
			{
				this.x *= scale.x;
				this.y *= scale.y;
				this.z *= scale.z;
			}

			/// <summary>
			///   <para>Set x, y and z components of an existing Vector3.</para>
			/// </summary>
			/// <param name="newX"></param>
			/// <param name="newY"></param>
			/// <param name="newZ"></param>
			public void Set(float newX, float newY, float newZ)
			{
				this.x = newX;
				this.y = newY;
				this.z = newZ;
			}

			/// <summary>
			///   <para>Returns the signed angle in degrees between from and to.</para>
			/// </summary>
			/// <param name="from">The vector from which the angular difference is measured.</param>
			/// <param name="to">The vector to which the angular difference is measured.</param>
			/// <param name="axis">A vector around which the other vectors are rotated.</param>
			public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
			{
				Vector3 _fromNormal = from.normalized;
				Vector3 _toNormal = to.normalized;
				float _angle = Mathf.Acos(Mathf.Clamp(Vector3.Dot(_fromNormal, _toNormal), -1f, 1f)) * 57.29578f;
				float _sign = Mathf.Sign(Vector3.Dot(axis, Vector3.Cross(_fromNormal, _toNormal)));
				return _angle * _sign;
			}

			/// <summary>
			///   <para>Spherically interpolates between two vectors.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <param name="t"></param>
			//[ThreadAndSerializationSafe]
			//public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
			//{
			//	Vector3 vector3;
			//	Vector3.INTERNAL_CALL_Slerp(ref a, ref b, t, out vector3);
			//	return vector3;
			//}

			/// <summary>
			///   <para>Spherically interpolates between two vectors.</para>
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <param name="t"></param>
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

			////[ExcludeFromDocs]
			//public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
			//{
			//	float single = Time.deltaTime;
			//	float single1 = float.PositiveInfinity;
			//	Vector3 vector3 = Vector3.SmoothDamp(current, target, ref currentVelocity, smoothTime, single1, single);
			//	return vector3;
			//}

			//public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity, float deltaTime = Time.deltaTime)
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

			public static float SqrMagnitude(Vector3 vector)
			{
				float single = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
				return single;
			}

			/// <summary>
			///   <para>Returns a nicely formatted string for this vector.</para>
			/// </summary>
			/// <param name="format"></param>
			public override string ToString()
			{
				return string.Format("({0:F1}, {1:F1}, {2:F1})", new object[] { this.x, this.y, this.z });
			}

			/// <summary>
			///   <para>Returns a nicely formatted string for this vector.</para>
			/// </summary>
			/// <param name="format"></param>
			public string ToString(string format)
			{
				return string.Format("({0}, {1}, {2})", new object[] { this.x.ToString(format), this.y.ToString(format), this.z.ToString(format) });
			}
		}
	}

}