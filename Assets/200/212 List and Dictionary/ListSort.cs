using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace _212_ListAndDictionary
{
	[System.Serializable]
	public class TestData
	{
		public string name;
		public int health;
		//public float distance;
	}

	public class ListSort : MonoBehaviour
	{
		public Text t1, t2, t3;
		public List<TestData> list1 = new List<TestData>();
		public List<TestData> list2 = new List<TestData>();
		public List<TestData> list3 = new List<TestData>();

		void Start()
		{
			list2.AddRange(list1);
			list3.AddRange(list1);

		}

		float nextTime;
		private void Update()
		{
			if(Time.time > nextTime)
			{
				nextTime = Time.time + 3f;

				//health 높은
				list2.Sort((_v1, _v2) => _v1.health.CompareTo(_v2.health));

				//list3.Sort((_v1, _v2) => _v2.distance.CompareTo(_v1.distance));
				list3.Sort(delegate (TestData _v1, TestData _v2)
				{
					if (_v1.health > _v2.health) return 1;					
					return -1;
					//if (_v1.health > _v2.health) return 1;
					//else if (_v1.health < _v2.health) return -1;
					//return 0;
				});

				t1.text = GetMessage(list1);
				t2.text = GetMessage(list2);
				t3.text = GetMessage(list3);
			}
		}

		string GetMessage(List<TestData> _l)
		{
			string _rtn = "";
			TestData _data;
			for(int i = 0, imax = _l.Count; i < imax; i++)
			{
				_data = _l[i];
				_rtn += _data.name 
					+ " h:" + _data.health
					//+ " d:" + _data.distance
					+ "\n";
			}

			return _rtn;
		}
	}

}