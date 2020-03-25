using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ListAndDictionaryTest
{
	public class ListAndDictionary : MonoBehaviour
	{
		float[] t = new float[20];
		public int LOOP_MAX = 10000;
		public List<Transform> list = new List<Transform>();
		public Dictionary<Transform, GClass> dic = new Dictionary<Transform, GClass>();

		// Use this for initialization
		void Start()
		{
			Debug.Log("<transform, T>, GetComponet<T> test");
		}

		// Update is called once per frame
		void Update()
		{
			t[0] = Time.realtimeSinceStartup;
			FunHashSet();
			t[1] = Time.realtimeSinceStartup;
			FunHashSet2();
			t[2] = Time.realtimeSinceStartup;
			FunList();
			t[3] = Time.realtimeSinceStartup;
			FunList2();
			t[4] = Time.realtimeSinceStartup;
			FunDictionary();
			t[5] = Time.realtimeSinceStartup;
			FunDictionary2();
			t[6] = Time.realtimeSinceStartup;
			FunVector3();
			t[7] = Time.realtimeSinceStartup;
			FunVector32();
			t[8] = Time.realtimeSinceStartup;
			FunMyStruct();
			t[9] = Time.realtimeSinceStartup;
			FunMyStruct2();
			t[10] = Time.realtimeSinceStartup;
			FunMyStruct3();
			t[11] = Time.realtimeSinceStartup;



			Debug.Log("=========================");
			Debug.Log("FunHashSet(new) :"		+ (t[1] - t[0]));
			Debug.Log("FunHashSet2(.Clear) :"	+ (t[2] - t[1]));
			Debug.Log("FunList(new) :"			+ (t[3] - t[2]));
			Debug.Log("FunList2(.Clear) :"		+ (t[4] - t[3]));
			Debug.Log("FunDictionary(new) :"	+ (t[5] - t[4]));
			Debug.Log("FunDictionary(.Clear) :" + (t[6] - t[5]));
			Debug.Log("FunVector3(V3) :"		+ (t[7] - t[6]));
			Debug.Log("FunVector32(V3,set) :"	+ (t[8] - t[7]));
			Debug.Log("FunMyStruct(MyStruce) :" + (t[9] - t[8]));
			Debug.Log("FunMyStruct2(MyStruce,set) :" + (t[10] - t[9]));
			Debug.Log("FunMyStruct3(MyStruce,set,param) :" + (t[11] - t[10]));
		}



		void FunHashSet()
		{
			for (int i = 0; i < LOOP_MAX; i++)
			{
				HashSet<Transform> _hash = new HashSet<Transform>();
				_hash.Add(transform);
			}
		}

		void FunHashSet2()
		{
			HashSet<Transform> _hash = new HashSet<Transform>();
			for (int i = 0; i < LOOP_MAX; i++)
			{
				_hash.Clear();
				_hash.Add(transform);
			}
		}

		void FunList()
		{
			for (int i = 0; i < LOOP_MAX; i++)
			{
				List<Transform> _list = new List<Transform>();
				_list.Add(transform);
			}
		}
		void FunList2()
		{
			List<Transform> _list = new List<Transform>();
			for (int i = 0; i < LOOP_MAX; i++)
			{
				_list.Clear();
				_list.Add(transform);
			}
		}
		void FunDictionary()
		{
			for (int i = 0; i < LOOP_MAX; i++)
			{
				Dictionary<Transform, Transform> _dic = new Dictionary<Transform, Transform>();
				_dic.Add(transform, transform);
			}
		}
		void FunDictionary2()
		{
			Dictionary<Transform, Transform> _dic = new Dictionary<Transform, Transform>();
			for (int i = 0; i < LOOP_MAX; i++)
			{
				_dic.Clear();
				_dic.Add(transform, transform);
			}
		}

		void FunVector3()
		{
			for(int i = 0; i < LOOP_MAX; i++)
			{
				Vector3 _v = transform.position;
			}
		}

		void FunVector32()
		{
			Vector3 _v	= Vector3.zero;
			Vector3 _v2 = transform.position;
			for (int i = 0; i < LOOP_MAX; i++)
			{
				 _v.Set(_v2.x, _v2.y, _v2.z);
			}
		}

		void FunMyStruct()
		{
			for (int i = 0; i < LOOP_MAX; i++)
			{
				Passenger _p = new Passenger(transform, Vector3.zero, true, false);
			}
		}
		void FunMyStruct2()
		{
			Passenger _p = new Passenger(transform, Vector3.zero, true, false);
			Passenger _p2 = new Passenger(transform, Vector3.zero, true, false);
			for (int i = 0; i < LOOP_MAX; i++)
			{
				_p.Set(_p2);
			}
		}
		void FunMyStruct3()
		{
			Passenger _p = new Passenger(transform, Vector3.zero, true, false);
			Passenger _p2 = new Passenger(transform, Vector3.zero, true, false);
			for (int i = 0; i < LOOP_MAX; i++)
			{
				_p.Set(_p2.trans, _p2.move, _p2.bUp, _p2.bFirst);
			}
		}


	}

	public struct Passenger
	{
		public Transform trans;
		public Vector3 move;
		public bool bUp;
		public bool bFirst;

		public Passenger(Transform _trans, Vector3 _move, bool _bUp, bool _bFirst)
		{
			trans = _trans;
			move = _move;
			bUp = _bUp;
			bFirst = _bFirst;
		}

		public void Set(Transform _trans, Vector3 _move, bool _bUp, bool _bFirst)
		{
			trans = _trans;
			move = _move;
			bUp = _bUp;
			bFirst = _bFirst;
		}

		public void Set(Passenger _p)
		{
			trans = _p.trans;
			move = _p.move;
			bUp = _p.bUp;
			bFirst = _p.bFirst;
		}
	}
}