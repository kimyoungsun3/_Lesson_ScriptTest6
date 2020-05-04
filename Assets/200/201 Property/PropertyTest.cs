using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertyTest{
	public class PropertyTest : MonoBehaviour {
		public float xxx;

		public float xxx2 { get; set; }

		private float xxx3_;
		public float xxx3
		{
			get { return xxx3_; }
			set { xxx3_ = value; }
		}

		public float damageBase, damageUpgrade, damageSpot;
		public float damage
		{
			get { return damageBase + damageUpgrade * 10 + damageSpot * 100; }
		}

		public Vector3 targetPos
		{
			set {
				StartCoroutine(Co_Move(value));
			}
		}

		IEnumerator Co_Move(Vector3 _targetPos)
		{
			float _percent = 0f;

			while(_percent <= 1f)
			{
				_percent += Time.deltaTime;
				transform.position = Vector3.Lerp(transform.position, _targetPos, _percent);
				yield return null;
			}
		}



		private void Start()
		{
			damageBase		= 1;
			damageUpgrade	= 2;
			damageSpot		= 3;
			Debug.Log(damage);
		}

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				targetPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
			}
		}
	}
}