using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_Send_SingleTone : MonoBehaviour
	{
		public Color color = Color.green;

		private void OnMouseDown()
		{
			Message_ReceiveSingleTone.ins.Selected(color);
		}
	}
}