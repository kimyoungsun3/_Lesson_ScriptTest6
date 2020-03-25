using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassThisTest
{
	public class Card : MonoBehaviour
	{
		public int number;
		[SerializeField] GameObject blind;

		private void OnMouseDown()
		{
			if (blind.activeSelf && CardManager.ins.isCardSelecting)
			{
				blind.SetActive(false);
				CardManager.ins.CheckCard(this);
			}
		}

		public void Blind()
		{
			blind.SetActive(true);
		}
	}
}
