using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GMTest
{
	public class EnemyManager : MonoBehaviour
	{
		public static EnemyManager ins;
		public Enemy enemyPrefab;
		public List<Enemy> enemyList = new List<Enemy>();
		private bool bStart;

		private void Awake()
		{
			ins = this;
			Init();
		}

		public void Init()
		{
			bStart = false;
		}

		public bool CheckClearEnemy()
		{
			return (bStart && enemyList.Count <= 0);
		}

		public void SetSpawn()
		{
			bStart = true;
			Vector3 _pos = Random.onUnitSphere * 3f;
			Enemy _e = Instantiate(enemyPrefab, _pos, Quaternion.identity) as Enemy;
			enemyList.Add(_e);
		}

		public void RemoveSpawn(Enemy _enemy)
		{
			//enemyList.Find(_e => (_enemy == _e) { });

			enemyList.Remove(_enemy);
			//for(int i = 0, iMax = enemyList.Count; i < iMax; i++)
			//{
			//	if(enemyList[i] == _enemy)
			//	{
			//		enemyList.RemoveAt(i);
			//	}
			//}
		}

		public void ClearAllEnemy()
		{

			for(int i = 0, iMax = enemyList.Count; i < iMax; i++)
			{
				Destroy(enemyList[i].gameObject);
				//enemyList.RemoveAt(i);
			}
			enemyList.Clear();
		}
	}
}