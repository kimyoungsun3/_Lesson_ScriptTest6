using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GMTest
{
	public class Player : MonoBehaviour
	{

		private void OnMouseDown()
		{
			if (GameManager.ins.gamestate != GameState.Gaming)
				return;

			Destroy(gameObject);
		}

	}
}
