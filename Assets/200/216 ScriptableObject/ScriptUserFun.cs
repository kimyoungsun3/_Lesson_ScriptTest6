using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjectTest
{
	[CreateAssetMenu(fileName ="SaveData", menuName ="ScriptDataTest/UserFun")]
	public class ScriptUserFun : ScriptableObject
	{
		public void CalHealth(Player2 _player, ScriptUserData _data)
		{
			_player.health -= _data.damage;
		}
	}
}
