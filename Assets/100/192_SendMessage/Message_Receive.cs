using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_Receive : MonoBehaviour
	{
		public Color receivedColor;
		Material material;
		private void Selected(Color _color)
		{
			if (material == null)
			{
				material = GetComponent<Renderer>().material;
			}
			receivedColor	= _color;
			material.color	= _color;
		}
	}
}
