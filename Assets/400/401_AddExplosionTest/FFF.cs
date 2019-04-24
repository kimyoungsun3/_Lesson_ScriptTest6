using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FOV
public class FFF : MonoBehaviour {
	public float viewDistance = 5f;
	public float viewAngle = 15f; //30도.
	float checkTime;
	public float CHECK_TIME = 0.5f;
	Ray ray;
	RaycastHit hit;
	public LayerMask mask;
	void Update() {
		ray.origin = transform.position;
		ray.direction = transform.forward;
		Debug.DrawRay(ray.origin, ray.direction * viewDistance, Color.red);
		Quaternion _q = transform.rotation * Quaternion.Euler(0, viewAngle, 0);
		Debug.DrawRay(ray.origin, _q * Vector3.forward * viewDistance, Color.green);
		Quaternion _q2 = transform.rotation * Quaternion.Euler(0, -viewAngle, 0);
		Debug.DrawRay(ray.origin, _q2 * Vector3.forward * viewDistance, Color.green);

		//if (Physics.Raycast(ray, out hit))
		if (Time.time > checkTime)
		{
			checkTime = Time.time + CHECK_TIME;
			Rigidbody _rb;
			Vector3 _dir;
			float _angle, _distance;
			Material _mat;
			Collider[] _cols = Physics.OverlapSphere(ray.origin, viewDistance);
			for (int i = 0, iMax = _cols.Length; i < iMax; i++)
			{
				//Debug.Log(13);
				_rb = _cols[i].GetComponent<Rigidbody>();
				if (_rb != null)
				{
					_dir = _rb.position - ray.origin;
					_angle = Vector3.Angle(ray.direction, _dir);
					if(_angle < viewAngle)
					{
						//Debug.Log(" >> find" + _rb.name);
						_distance = _dir.magnitude;
						//if (!Physics.Raycast(ray.origin, _dir, _distance, mask)) {
						//	_rb.GetComponent<Renderer>().material.color = Color.grey;
						//}
						Physics.Raycast(ray.origin, _dir, out hit, _distance);
						if(hit.rigidbody == _rb)
						{
							_rb.GetComponent<Renderer>().material.color = Color.grey;
						}
					}
				}
			}
		}
	}
}
