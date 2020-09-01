using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_ReceiveSingleTone : MonoBehaviour
	{
		public static Message_ReceiveSingleTone ins;
		private void Awake()
		{
			ins = this;
		}

		public Color receivedColor;
		Material material;
		public void Selected(Color _color)
		{
			if (material == null)
			{
				material = GetComponent<Renderer>().material;
			}
			receivedColor = _color;
			material.color = _color;
		}
	}
}
