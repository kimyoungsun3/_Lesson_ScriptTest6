using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace _196_JsonUtility
{

	public class JsonExample : MonoBehaviour
	{
		public JTestClass jtc;
		[TextArea(10, 15)]public string jsonData;
		public JTestClass jtc2;

		// Use this for initialization
		void Start()
		{
			jtc			= new JTestClass(true);
			jsonData	= ToJson(jtc, true);
			jtc2		= FromJson<JTestClass>(jsonData);
		}



		string ToJson(object _obj, bool _pretty = false)
		{
			return JsonUtility.ToJson(_obj, _pretty);
		}

		T FromJson<T>(string _jsonData)
		{
			return JsonUtility.FromJson<T>(_jsonData);
		}
	}

	[System.Serializable]
	public class JTestClass
	{
		public int i;
		public float f;
		public bool b;

		public Vector3 v;
		public string str;
		public int[] iArray;
		public List<int> iList = new List<int>();

		public JTestClass() { }

		public JTestClass(bool isSet)
		{
			if (isSet)
			{
				i = 10;
				f = 99.9f;
				b = true;

				v = new Vector3(39.56f, 21.2f, 6.4f);
				str = "JSON Test String";
				iArray = new int[] { 1, 1, 3, 5, 8, 13, 21, 34, 55 };

				for (int idx = 0; idx < 5; idx++)
				{
					iList.Add(2 * idx);
				}
			}
		}
	}

}