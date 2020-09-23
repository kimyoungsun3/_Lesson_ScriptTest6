using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathTest
{
	
	public class MathTest : MonoBehaviour
	{
		public int countPerMeter;
		public Transform p0, p1;
		List<Vector3> list = new List<Vector3>();
		public bool bCreateLine;
		public int calType;

		private void OnDrawGizmos()
		{
			if (bCreateLine && p0 && p1)
			{
				CreateLine();

				switch (calType)
				{
					case 0: Cal_Mod(0.5f);	break;
					case 1: Cal_Floor();	break;
					case 2: Cal_Ceil();		break;
					case 3: Cal_Sign();		break;
					case 4: break;
					case 5: break;
					case 6: break;
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
				_v = list[i];
				_v.y += _v.x % _mod;
				list[i] = _v;
			}
		}

		void Cal_Ceil()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v = list[i];
				_v.y += Mathf.Ceil(_v.x);
				list[i] = _v;
			}
		}

		void Cal_Floor()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v = list[i];
				_v.y += Mathf.Floor(_v.x);
				list[i] = _v;
			}
		}

		void Cal_Sign()
		{
			Vector3 _v;
			for (int i = 0, imax = list.Count; i < imax; i++)
			{
				_v = list[i];
				_v.y += Mathf.Sign(_v.x);
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
			float _d	= _distance / _count;
			list.Clear();
			list.Add(_v0);
			for (int i = 0; i < _count; i++)
			{
				_v0 += _dirN * _d;
				list.Add(_v0);
			}
		}

		void DrawLine()
		{
			Vector3 _v0 = list[0];
			Vector3 _v1;
			for (int i = 1, imax = list.Count; i < imax; i++)
			{
				_v1 = list[i];
				Gizmos.DrawLine(_v0, _v1);
				_v0 = _v1;
			}
		}
	}
}
