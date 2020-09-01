using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_SendMessage : MonoBehaviour
	{
		public Color color = Color.green;

		private void OnMouseDown()
		{
			SendMessage("Selected", color, SendMessageOptions.DontRequireReceiver);
		}
	}
}