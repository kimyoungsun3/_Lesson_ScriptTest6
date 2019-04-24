using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentTestNameSpace
{
	public class EquipmentGun : MonoBehaviour
	{
		Gun gun;
		public Gun gunInit;
		public Transform gunSpownPoint;

		private void Start()
		{
			if(gunInit != null)
			{
				WearGun(gunInit);
			}
		}

		public void WearGun(Gun _gun)
		{
			if(gun != null)
			{
				Destroy(gun.gameObject);
			}
			gun = Instantiate(_gun, gunSpownPoint.position, gunSpownPoint.rotation) as Gun;
			gun.transform.SetParent(gunSpownPoint);
		}

		public void Shoot()
		{
			gun.Shoot();
		}

	}
}
