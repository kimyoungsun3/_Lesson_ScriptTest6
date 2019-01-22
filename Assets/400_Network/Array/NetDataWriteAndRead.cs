using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetDataWriteAndRead : MonoBehaviour {
	public byte[] buffer = new byte[12];
	int pos;
	public int data;

	// Use this for initialization
	void Start () {
		
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			data = Random.Range(int.MinValue, int.MaxValue);
			NUtil.SetInt(buffer, pos, data);
			pos += 4;
			pos = pos % buffer.Length;
			Debug.Log("생성:" + data);

		}else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			data = Random.Range(0, 10);
			int _pos = pos - 4;
			if (_pos < 0)
				_pos = buffer.Length - 4;
			Debug.Log("읽기:" + NUtil.GetInt(buffer, _pos ));
		}
	}

}
