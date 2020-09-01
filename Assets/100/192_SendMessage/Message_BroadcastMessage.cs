using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_BroadcastMessage : MonoBehaviour
	{
		public Color color = Color.green;

		private void OnMouseDown()
		{
			BroadcastMessage("Selected", color, SendMessageOptions.DontRequireReceiver);
		}
	}
}