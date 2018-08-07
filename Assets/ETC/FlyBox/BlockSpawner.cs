using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour {
	public float TIME_MAX = 10f;
	public Transform block;
	public Vector2 TIME_BETWEEN = new Vector2(1f, 0.2f);
	public Vector2 angleMinMax = new Vector2 (-30f, +30f);
	public Vector2 sizeMinMax = new Vector2 (.3f, 4f);
	Vector2 screenInfo;
	Vector2 pos;
	Quaternion quat;
	float nextTime;
	public Text scoreText;
	int score = 0;
	Transform player;

	// Use this for initialization
	void Start () {
		screenInfo.Set (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize + 2f);
		//Debug.Log (screenInfo);
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > nextTime) {
			//Time > 점점 빨라짐....
			nextTime = Time.time + Mathf.Lerp(TIME_BETWEEN.x, TIME_BETWEEN.y, BBB.GetTimeInterpolate(TIME_MAX));
			pos.Set (Random.Range (-screenInfo.x, screenInfo.y), screenInfo.y);
			quat = Quaternion.Euler(Vector3.forward * Random.Range(angleMinMax.x, angleMinMax.y));

			Transform _trans = Instantiate (block, pos, quat) as Transform;
			_trans.localScale *= Random.Range (sizeMinMax.x, sizeMinMax.y);

			//Score call back Register.
			BlockMove _scp = _trans.GetComponent<BlockMove> ();
			if (_scp != null) {
				_scp.onDeath += delegate() {
					if(player != null){
						score ++;
						scoreText.text = score.ToString();
					}
				};
			}
			//_go.transform.position = new Vector2(
			//	_go.transform.position.x, 
			//	_go.transform.position.y + _go.GetComponent<Renderer> ().bounds.extents.y*2
			//);
		}
	}
}
