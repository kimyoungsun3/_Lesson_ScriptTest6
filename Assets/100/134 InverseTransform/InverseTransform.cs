using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InverseTransform
{
	public class InverseTransform : MonoBehaviour
	{
		public Text text;
		public List<Transform> list = new List<Transform>();

		private void Start()
		{
			Debug.Log(" > 카메라를 이동(x, y, z), 회전해보세요(x, y, z) ");
			Debug.Log(" > 회전해보세요(45, 45, 0) 놓고 한번 보세요.");
			Debug.Log(" > 카메라 스크립트에서 MakeChild로 자식으로 넣어보세요. ");
		}

		void Update()
		{
			string _str = "InverseTransformPoint\n";
			for(int i = 0; i < list.Count; i++)
			{
				Vector3 _dir = transform.InverseTransformPoint(list[i].position);
				_str += " [" + i + "]:" + _dir;
			}
			_str += "\nB-A\n";
			for (int i = 0; i < list.Count; i++)
			{
				Vector3 _dir = list[i].position - transform.position;
				_str += " [" + i + "]:" + _dir;
			}

			text.text = _str;
		}

		[ContextMenu("MakeChild")]
		public void MakeChild()
		{
			for (int i = 0; i < list.Count; i++)
				list[i].SetParent(transform);
		}

		[ContextMenu("ReleaseChild")]
		public void ReleaseChild()
		{
			for (int i = 0; i < list.Count; i++)
				list[i].SetParent(null);
		}
	}
}
