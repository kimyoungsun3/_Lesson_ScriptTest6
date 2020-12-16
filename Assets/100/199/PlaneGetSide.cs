using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://github.com/Unity-Technologies/UnityCsReference/blob/master/Runtime/Export/Geometry/Plane.cs
namespace _199_PlaneTest
{
	public class PlaneGetSide : MonoBehaviour
	{
		public Plane goalLine1;
		public Plane goalLine2;
		public Plane leftSideLine;
		public Plane rightSideLine;
		public Text text;

		// Use this for initialization
		void Start()
		{
			goalLine1		= new Plane(Vector3.down, Vector3.up);
			goalLine2		= new Plane(Vector3.up, Vector3.down);
			leftSideLine	= new Plane(Vector3.right, Vector3.left);
			rightSideLine	= new Plane(Vector3.left, Vector3.right);
		}

		int GoalScored(Vector3 ballPos)
		{
			// If the ball is within the sidelines...
			if (!leftSideLine.GetSide(ballPos) && !rightSideLine.GetSide(ballPos))
			{
				// If the ball is over goal line 1 then it's a goal for team 1...
				if (goalLine1.GetSide(ballPos))
				{
					return 1;
				}
				// ...else if the ball is over goal line 2 then it's a goal for team 2.
				else if (goalLine2.GetSide(ballPos))
				{
					return 2;
				}
			}

			// Otherwise, it isn't a goal for either team.
			return 0;
		}

		// Update is called once per frame
		void Update()
		{
			//Debug.DrawRay(goalLine1.normal, )
			text.text	= goalLine1.normal.ToString() + ":" + goalLine1.distance 
				+ ":" + goalLine1.GetSide(transform.position).ToString();
			text.text	+= "\n" + goalLine2.normal.ToString() + ":" + rightSideLine.distance
				+ ":" + goalLine2.GetSide(transform.position).ToString();
			text.text += "\n" + leftSideLine.normal.ToString() + ":" + rightSideLine.distance
				+ ":" + leftSideLine.GetSide(transform.position).ToString();
			text.text += "\n" + rightSideLine.normal.ToString() + ":" + rightSideLine.distance
				+ ":" + rightSideLine.GetSide(transform.position).ToString();
		}

		private void OnDrawGizmos()
		{
			Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
		}
	}
}