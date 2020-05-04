using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _404_ButtoneEffect
{
	public class EffectWaypoint : MonoBehaviour
	{
		[SerializeField] Transform target;
		[SerializeField] float speed = 2f;
		[SerializeField] List<Transform> wayPoints = new List<Transform>();
		Vector3[] ways;
		int index;
		Vector3 point;
		

		void Start()
		{
			ways = new Vector3[wayPoints.Count];

			for(int i = 0, imax = wayPoints.Count; i < imax; i++)
			{
				ways[i] = wayPoints[i].position;
			}

			index = 0;
			point = ways[index];
			target.position = point;
		}

		// Update is called once per frame
		void Update()
		{
			if(target.position == point)
			{
				index = (index + 1) % ways.Length;
				point = ways[index];
			}

			target.position = Vector3.MoveTowards(target.position, point, speed * Time.deltaTime);
		}
	}
}
