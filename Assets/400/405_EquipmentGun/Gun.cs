using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentTestNameSpace
{
	public enum ENUM_GUN_KIND { Gun, AK}
	public class Gun : MonoBehaviour
	{
		public ENUM_GUN_KIND kind;
		public Bullet bullet;
		public float bulletSpeed = 20f;
		public Transform firePoint;
		public float msBetweenShoot = 200f;
		float fireTime, fireSpeed;

		private void OnEnable()
		{
			fireTime = 0;
			fireSpeed = msBetweenShoot / 1000f;
		}

		public void Shoot()
		{
			switch (kind)
			{
				case ENUM_GUN_KIND.Gun:
					if (Time.time > fireTime)
					{
						fireTime = Time.time + fireSpeed;
						Bullet _bullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as Bullet;
						_bullet.SetParameter(bulletSpeed);
					}
					break;
				case ENUM_GUN_KIND.AK:
					if (Time.time > fireTime)
					{
						fireTime = Time.time + fireSpeed;
						Bullet _bullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as Bullet;
						_bullet.SetParameter(bulletSpeed);
					}
					break;

			}
		}
	}

}