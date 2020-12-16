using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://github.com/Unity-Technologies/UnityCsReference/blob/master/Runtime/Export/Geometry/Plane.cs
namespace _199_PlaneTest
{
	public class PlaneGetSide2 : MonoBehaviour
	{
		public Plane topLine;
		public Plane bottomLine;
		public Plane leftLine;
		public Plane rightLine;
		public Text text;
		public Transform topT, bottomT, leftT, rightT;
		public Material mT, bT, lT, rT;
		Color color;

		// Use this for initialization
		void Start()
		{
			mT = topT.GetComponent<Renderer>().material;
			bT = bottomT.GetComponent<Renderer>().material;
			lT = leftT.GetComponent<Renderer>().material;
			rT = rightT.GetComponent<Renderer>().material;
			color = mT.color;

			topLine		= new Plane(Vector3.down, topT.position);
			bottomLine	= new Plane(Vector3.up, bottomT.position);
			leftLine	= new Plane(Vector3.right, leftT.position);
			rightLine	= new Plane(Vector3.left, rightT.position);
		}

		// Update is called once per frame
		void Update()
		{
			//Debug.DrawRay(goalLine1.normal, )
			text.text	= topLine.normal.ToString() + ":" + topLine.distance 
				+ ":" + topLine.GetSide(transform.position).ToString();
			if (topLine.GetSide(transform.position))
				mT.color = color;
			else
				mT.color = Color.red;


			text.text	+= "\n" + bottomLine.normal.ToString() + ":" + bottomLine.distance
				+ ":" + bottomLine.GetSide(transform.position).ToString();
			if (bottomLine.GetSide(transform.position))
				bT.color = color;
			else
				bT.color = Color.red;


			text.text += "\n" + leftLine.normal.ToString() + ":" + leftLine.distance
				+ ":" + leftLine.GetSide(transform.position).ToString();
			if (leftLine.GetSide(transform.position))
				lT.color = color;
			else
				lT.color = Color.red;


			text.text += "\n" + rightLine.normal.ToString() + ":" + rightLine.distance
				+ ":" + rightLine.GetSide(transform.position).ToString();
			if (rightLine.GetSide(transform.position))
				rT.color = color;
			else
				rT.color = Color.red;


		}

		//private void OnDrawGizmos()
		//{
		//	Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
		//}
	}
}