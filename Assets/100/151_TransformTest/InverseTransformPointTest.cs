using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _151_TransformTest
{
	public class InverseTransformPointTest : MonoBehaviour
	{
		[SerializeField] bool bStop		= true;
		[SerializeField] float minSize	= 6f;
		[SerializeField] float edge		= 1f;
		Transform center;
		[SerializeField] List<Transform> list = new List<Transform>();

		private void OnDrawGizmos()
		{
			if (list.Count <= 0 || !Camera.main.orthographic || bStop)
				return;

			center = transform.root;
			Vector3 _pos = Vector3.zero;
			for (int i = 0; i < list.Count; i++)
			{
				_pos += list[i].position;
			}
			center.position = _pos / list.Count;


			Camera _cam = Camera.main;
			float _size = 0;
			for (int i = 0; i < list.Count; i++)
			{
				_pos = transform.InverseTransformPoint(list[i].position);

				_size = Mathf.Max(_size, Mathf.Abs(_pos.y));
				_size = Mathf.Max(_size, Mathf.Abs(_pos.x / _cam.aspect));
			}

			_size = Mathf.Max(_size, minSize);
			_size += edge;
			_cam.orthographicSize = _size;
		}
	}
}