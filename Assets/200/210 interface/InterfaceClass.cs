using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceTest{
	public interface IKillable
	{
		void Kill();
	}

	public interface IDamageable<T>
	{
		void Damage(T _damage);
	}
}