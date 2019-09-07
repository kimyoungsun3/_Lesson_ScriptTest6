using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GMTest
{
	public class Enemy : MonoBehaviour
	{
		private void OnMouseDown()
		{
			if (GameManager.ins.gamestate != GameState.Gaming)
				return;

			EnemyManager.ins.RemoveSpawn(this);
			Destroy(gameObject);
		}
	}
}