using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _192_SendMessage
{
	public class Message_SendMessgeUpward : MonoBehaviour
	{
		public Color color = Color.green;

		private void OnMouseDown()
		{
			SendMessageUpwards("Selected", color, SendMessageOptions.DontRequireReceiver);
		}
	}
}