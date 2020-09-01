using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace _189_Rigidbody2_AddForce
{
	public enum eForceType {
		AddForce, AddForceAtPosition,
		AddRelativeForce_Ray_Direction,
		AddRelativeForce_V3_Forward,
		AddRelativeForce_V3_Up,
		AddRelativeForce_V3_Right,
		AddExplosionForce,
		PhysicOverlap_AddExplosionForce,
		Velocity
	};
	public class RayHitAddForce : MonoBehaviour
	{
		Camera camera;
		Transform trans;
		public eForceType forceType = eForceType.AddForce;
		public ForceMode forceMode = ForceMode.Force;
		public KeyCode keyForceType = KeyCode.Alpha1;
		public KeyCode keyForceMode = KeyCode.Alpha2;

		public float distance = 100f;
		public float power = 100f;
		public Text text, text2;
		public Transform transPoint;
		public bool bDisplayGizmos = true;
		public float radius = 5f;

		public static RayHitAddForce ins;
		private void Awake()
		{
			if (ins != null)
			{
				Destroy(gameObject);
				return;
			}
			ins = this;
			DontDestroyOnLoad(gameObject);
		}

		private void Start()
		{
			trans = transform;
			camera = Camera.main; //GameObject.FindTage<Camera>("MainCamera");
		}

		// Update is called once per frame
		void Update()
		{
			//--------------------------------------
			if(camera == null) camera = Camera.main;
			Ray _ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit _hit;

			//물리 모드 변경...
			if (Input.GetKeyDown(keyForceType))
			{
				string[] _strs = System.Enum.GetNames(typeof(eForceType));
				string _str = forceType.ToString();
				int _index = 0;
				for (int i = 0; i < _strs.Length; i++)
				{
					if (_strs[i] == _str)
					{
						_index = (i + 1) % _strs.Length;
						break;
					}
				}
				forceType = (eForceType)System.Enum.Parse(typeof(eForceType), _strs[_index]);
			}
			if (Input.GetKeyDown(keyForceMode))
			{
				string[] _strs = System.Enum.GetNames(typeof(ForceMode));
				string _str = forceMode.ToString();
				int _index = 0;
				for(int i = 0; i < _strs.Length; i++)
				{
					if(_strs[i] == _str)
					{
						_index = (i + 1) % _strs.Length;
						break;
					}
				}
				forceMode = (ForceMode)System.Enum.Parse(typeof(ForceMode), _strs[_index]);
				//Debug.Log((int)forceMode);
			}

			//디버그 정보 출력...
			Debug.DrawRay(_ray.origin, _ray.direction * distance, Color.blue);
			text.text	= forceType.ToString();
			text2.text	= forceMode.ToString();
			if (Physics.Raycast(_ray, out _hit))transPoint.position = _hit.point;


			if (Input.GetMouseButtonDown(0))
			{
				//Debug.Log("마우스 눌림");
				if (Physics.Raycast(_ray, out _hit))
				{

					//Debug.Log(_hit.collider.name);
					Rigidbody _rigidbody = _hit.collider.GetComponent<Rigidbody>();
					if (_rigidbody == null)
						_rigidbody = _hit.collider.GetComponentInParent<Rigidbody>();

					//Debug.Log(_rigidbody);
					if (_rigidbody != null)
					{
						switch (forceType)
						{
							case eForceType.AddForce:
								Debug.Log(" >> hit AddForce");
								_rigidbody.AddForce(_ray.direction * power, forceMode);
								break;
							case eForceType.AddForceAtPosition:
								Debug.Log(" >> hit AddForceAtPosition");
								_rigidbody.AddForceAtPosition(_ray.direction * power, _hit.point);
								break;
							case eForceType.AddRelativeForce_Ray_Direction:
								Debug.Log(" >> hit AddRelativeForce");
								_rigidbody.AddRelativeForce(_ray.direction * power);
								break;
							case eForceType.AddRelativeForce_V3_Forward:
								Debug.Log(" >> hit AddRelativeForce");
								_rigidbody.AddRelativeForce(Vector3.forward * power);
								break;
							case eForceType.AddRelativeForce_V3_Up:
								Debug.Log(" >> hit AddRelativeForce_V3_Up");
								_rigidbody.AddRelativeForce(Vector3.up * power);
								break;
							case eForceType.AddRelativeForce_V3_Right:
								Debug.Log(" >> hit AddRelativeForce_V3_Right");
								_rigidbody.AddRelativeForce(Vector3.right * power);
								break;
							case eForceType.AddExplosionForce:
								Debug.Log(" >> hit AddExplosionForce");
								_rigidbody.AddExplosionForce(power, _hit.point, radius);
								break;
							case eForceType.PhysicOverlap_AddExplosionForce:
								Debug.Log(" >> hit PhysicOverlap_AddExplosionForce");
								Collider[] _cols = Physics.OverlapSphere(_hit.point, radius);
								for(int i = 0; i < _cols.Length; i++)
								{
									Rigidbody _r = _cols[i].GetComponentInParent<Rigidbody>();
									if(_r != null)
									{
										_r.AddExplosionForce(power, _hit.point, radius);
									}
								}
								break;
							case eForceType.Velocity:
								Debug.Log(" >> hit Velocity");
								_rigidbody.velocity = _ray.direction * power;
								break;
						}
					}
				}
			}
		}
	}

}