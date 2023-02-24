using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Step215
{
	public class Monster : MonoBehaviour
	{
		System.Action<Monster> on;
		public void InitData(float _health, System.Action<Monster> _on)
		{
			gameObject.SetActive(true);
			on += _on;
		}
		

		private void OnMouseDown()
		{
			//지우기...
			if(on != null)
			{
				on(this);
				on = null;
			}
		}
	}
}