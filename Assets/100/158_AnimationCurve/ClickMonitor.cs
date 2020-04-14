using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _158_AnimationCurve
{
	public class ClickMonitor : MonoBehaviour
	{
		[SerializeField]ClickItem target;
		Plane ground;
		Camera camera;	

		void Start()
		{
			camera = Camera.main;
		}

		void Update()
		{

			if (Input.GetMouseButtonDown(0))
			{
				Ray _ray = camera.ScreenPointToRay(Input.mousePosition);				
				RaycastHit _hit;
				if(Physics.Raycast(_ray, out _hit, 100f))
				{
					//1. 선택하기....
					target = _hit.collider.GetComponent<ClickItem>();
					if (target != null)
					{
						ground = new Plane(-camera.transform.forward, target.transform.position);
					}
				}
				else if(target != null)
				{
					//2. 이동하기...
					float _distance;
					if(ground.Raycast(_ray, out _distance))
					{
						target.MoveLerp(_ray.GetPoint(_distance));
					}					
				}
			}
		}
	}
}
