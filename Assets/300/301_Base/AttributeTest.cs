using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _301_Base
{
	public class AttributeTest : MonoBehaviour
	{
		[Range(0f, 1f)] public float interval;
		[Range(1, 10)] public int level;

		[Multiline(5)]
		public string multiline;

		[TextArea(3, 5)]
		public string textarea;

		public int number;

		[ContextMenu("Random Number")]
		public void RandomNumber()
		{
			number = Random.Range(0, 100);
		}

		[ContextMenu("Reset Number")]
		public void ResetNumber()
		{
			number = 0;
		}

		[Space(10)]
		[ColorUsage(true)] public Color c1;
		[Space(10)]
		[ColorUsage(false)] public Color c2;
		[Space(20)]
		public Color c3;

		[Tooltip("Show Tool Tip")]
		public int x2;

		[SerializeField] int x3;
		[HideInInspector] public int x4;
	}
}
