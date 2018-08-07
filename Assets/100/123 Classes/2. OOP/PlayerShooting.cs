using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassesTest2{
	public class PlayerShooting : MonoBehaviour {
		public Rigidbody bulletPrefab;
		public Transform firePosition;
		public float bulletSpeed;

		public void Shoot (Stuff _stuff)
		{
			if(Input.GetButtonDown("Fire1") && _stuff.bullets > 0)
			{
				Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
				bulletInstance.AddForce(firePosition.forward * bulletSpeed);
				_stuff.bullets--;
			}
		}
	}
}
