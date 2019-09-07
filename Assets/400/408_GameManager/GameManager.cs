using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GMTest
{
	public enum GameState { GameInit, Gaming, GameOver, GameClear}

	public class GameManager : MonoBehaviour
	{
		public static GameManager ins;
		public Player playerPrefab;
		Player player;
		[HideInInspector]public GameState gamestate;
		public Text text;

		private void Awake()
		{
			ins = this;
		}

		// Use this for initialization
		void Start()
		{
			pInGameInit();
		}

		// Update is called once per frame
		void Update()
		{
			//Debug.Log(gamestate);
			switch (gamestate)
			{
				case GameState.GameInit:
					modifyGameInit();
					break;
				case GameState.Gaming:
					ModifyGaming();
					break;
				case GameState.GameOver:
					ModifyGameOver();
					break;
				case GameState.GameClear:
					ModifyGameClear();
					break;

			}
		}

		#region GameInit
		void pInGameInit()
		{
			
			gamestate = GameState.GameInit;
			text.gameObject.SetActive(true);
			text.text = "Game Init";
			if(player != null)
			{
				Destroy(player.gameObject);
			}
			EnemyManager.ins.ClearAllEnemy();
		}
		void modifyGameInit()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				PInGaming();
			}
			
		}
		#endregion

		#region Gaming
		void PInGaming()
		{
			EnemyManager.ins.Init();
			gamestate = GameState.Gaming;
			player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity) as Player;
			text.gameObject.SetActive(false);
		}
		void ModifyGaming()
		{
			//Debug.Log(11);
			if (player == null)
			{
				PInGameOver();
				return;
			}
			else if (EnemyManager.ins.CheckClearEnemy())
			{
				PInGameClear();
				return;
			}

			if (Input.GetMouseButtonDown(1))
			{
				EnemyManager.ins.SetSpawn();
			}
		}
		#endregion


		#region GameOver
		void PInGameOver()
		{
			//Debug.Log(12);
			gamestate = GameState.GameOver;
			text.text = "Game Over";
			text.gameObject.SetActive(true);
		}
		void ModifyGameOver()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				pInGameInit();
			}
		}
		#endregion

		#region GameClear
		void PInGameClear()
		{
			//Debug.Log(13);
			gamestate = GameState.GameClear;
			text.text = "Game Clear";
			text.gameObject.SetActive(true);
		}
		void ModifyGameClear()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				pInGameInit();
			}

		}
		#endregion
	}
}
