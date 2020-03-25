using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycleTest
{
	public class LifeCycle7_Singleton : MonoBehaviour
	{
		public static LifeCycle7_Singleton ins;
		//-----------------------
		void Awake()
		{
			ins = this;
			Debug.Log(this + " Awake");
			StartCoroutine(Co_Awake());
		}

		void OnEnable()
		{
			Debug.Log(this + " OnEnable");
			StartCoroutine(Co_OnEnable());
		}

		private void OnValidate()
		{
			Debug.Log(this + " OnValidate");
		}

		private void OnCollisionEnter(Collision collision)
		{
			//1. 충돌체에 충돌(R + C [No trigger])
		}

		private void OnTriggerEnter(Collider other)
		{
			//1. 충돌체에 충돌(R + C [trigger])
		}

		//-----------------------
		void Start()
		{
			Debug.Log(this + " Start");
			StartCoroutine(Co_Start());
		}

		//------------------------
		void FixedUpdate(){		Debug.Log(this + " FixedUpdate");	}
		void Update(){			Debug.Log(this + " Update");		}
		void LateUpdate(){		Debug.Log(this + " LateUpdate");	}

		IEnumerator Co_Awake()
		{
			//1. F -> U -> Coxxx -> L 순서에서 등록되어 사용된다...
			//2. GameObject가 살아 있으면 실행 중이다... GameObject가 비활성화 되면 종료...
			//3. Script가 비활성화 상태에서 실행중.... >> 
			while (true)
			{
				Debug.Log(this + " Co_Awake");
				yield return null;
			}
		}

		IEnumerator Co_Start()
		{
			while (true)
			{
				Debug.Log(this + " Co_Start");
				yield return null;
			}
		}

		IEnumerator Co_OnEnable()
		{
			while (true)
			{
				Debug.Log(this + " Co_OnEnable");
				yield return null;
			}
		}

		//------------------------
		void OnDisable(){
			//1. 스크립트가 비활성화 될때
			//2. 게임이 종료될때
			Debug.Log(this + " OnDisable");
		}

		private void OnApplicationQuit(){
			//1. 종료할때...
			Debug.Log(this + " OnApplicationQuit");
		}

		private void OnDrawGizmos()
		{
			//1. 에디터 중에 작동...
			//2. 실행 중에 작동....
			Debug.Log(this + " OnDrawGizmos");
		}

		public void SetData(float _hp)
		{
			Debug.Log("go:" + gameObject.activeSelf 
				+ " script:" + enabled 
				+ " >> _hp:" + _hp);
			Destroy(gameObject);
		}

		public void OnDestroy()
		{
			Debug.Log(this + " OnDestroy");
		}
	}
}
