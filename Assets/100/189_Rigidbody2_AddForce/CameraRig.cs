using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace _189_Rigidbody2_AddForce
{
	public class CameraRig : MonoBehaviour
	{
		public float speedTurn = 20f;
		public KeyCode keyPause = KeyCode.P;
		public bool bPause;
		public KeyCode keyRotateOpp = KeyCode.O;
		public int turnDir = 1;
		public KeyCode keyReload = KeyCode.R;

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(keyPause))	bPause = !bPause;
			if (Input.GetKeyDown(keyRotateOpp)) turnDir *= -1;
			if (Input.GetKeyDown(keyReload)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);

			if (bPause) return;


			transform.Rotate(turnDir * Vector3.up * speedTurn * Time.deltaTime);
		}
	}
}
