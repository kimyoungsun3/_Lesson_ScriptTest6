using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest{
	public class EnemyClass : MonoBehaviour, IKillable, IDamageable<float> {
		public void Kill()
		{
			Debug.Log (this + " > Kill");
		}


		public void Damage(float _damage)
		{
			Debug.Log (this + " > Damage:" + _damage);
		}
	}
}
