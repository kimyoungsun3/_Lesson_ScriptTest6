using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;


namespace _151_TransformTest
{
	[ExecuteInEditMode]
	public class TransformTest : MonoBehaviour
	{
		[SerializeField] UILabel label;
		StringBuilder builder = new StringBuilder();

		//private void OnDrawGizmos()
		void Update()
		{
			Debug.Log(1);
			builder.Length = 0;
			builder.AppendLine("child:" + transform.childCount);
			builder.AppendLine("" + transform.root.name);
			builder.AppendLine("" + transform.parent.name);
			builder.AppendLine("Find(P47)" + transform.Find("P47"));
			builder.AppendLine("Find(P47 -> P51)" + transform.Find("P51"));
			builder.AppendLine("" + transform.localToWorldMatrix);
			builder.AppendLine("" + transform.worldToLocalMatrix);

			label.text = builder.ToString();
		}
	}
}
