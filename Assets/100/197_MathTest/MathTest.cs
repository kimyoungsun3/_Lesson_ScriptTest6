using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathTest
{
	public enum eCalType { Mod, Floor, Ceil, Round, Sign, Int }
	public class MathTest : MonoBehaviour
	{
		public int countPerMeter;
		public Transform p0, p1;
		public bool bCreateLine;
		public float modValue = 0.5f;
		public eCalType type = eCalType.Mod;
		List<Vector3> list = new List<Vector3>();

		private void OnDrawGizmos()
		{
			if (bCreateLine && p0 && p1)
			{
				CreateLine();

				switch (type)
				{
					case eCalType.Mod:		Cal_Mod(modValue);break;
					case eCalType.Ceil:		Cal_Ceil();		break;
					case eCalType.Floor:	Cal_Floor();	break;
					case eCalType.Round:	Cal_Round();	break;
					case eCalType.Sign:		Cal_Sign();		break;
					case eCalType.Int:		Cal_Int();		break;
				}
			}

			if(list.Count >= 2)
			{				
				DrawLine();
			}
		}

		void Cal_Mod(float _mod)
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v		= list[i];
				_v.y	= _v.x % _mod;
				list[i] = _v;
			}
		}

		void Cal_Ceil()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v		= list[i];
				_v.y	= Mathf.Ceil(_v.x);
				list[i] = _v;
			}
		}

		void Cal_Round()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v			= list[i];
				_v.y		= Mathf.Round(_v.x);
				list[i]		= _v;
			}
		}

		void Cal_Floor()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v		= list[i];
				_v.y	= Mathf.Floor(_v.x);
				list[i] = _v;
			}
		}

		void Cal_Int()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v		= list[i];
				_v.y	= (int)(_v.x);
				list[i] = _v;
			}
		}

		void Cal_Sign()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v		= list[i];
				_v.y	= Mathf.Sign(_v.x);
				list[i] = _v;
			}
		}



		void CreateLine()
		{			
			bCreateLine = !bCreateLine;

			Vector3 _dir	= p1.position - p0.position;
			Vector3 _dirN	= _dir.normalized;
			float _distance = _dir.magnitude;
			int _count		= (int)_distance * countPerMeter;

			Vector3 _v0 = p0.position;
			Vector3 _v1 = p1.position;
			float _d	= _distance / (_count );
			list.Clear();
			list.Add(_v0);
			for (int i = 0; i < _count; i++)
			{
				_v0 += _dirN * _d;
				list.Add(_v0);
			}
			list.Add(_v1);
		}

		void DrawLine()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawLine(p0.position, p1.position);
			Gizmos.DrawLine(list[0], list[list.Count - 1]);

			Vector3 _v0 = list[0];
			Vector3 _v1;
			Gizmos.color = Color.green;
			for (int i = 1, imax = list.Count; i < imax; i++)
			{
				_v1 = list[i];
				Gizmos.DrawLine(_v0, _v1);
				_v0 = _v1;
			}
		}
	}
}
