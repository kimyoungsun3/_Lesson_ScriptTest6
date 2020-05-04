using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _221_StringFormat
{
	public class StringFormat : MonoBehaviour
	{
		public UILabel label;
		public Text text;
		//float time;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			//time += Time.deltaTime;
			label.text = string.Format("{0:00.00}", Time.time);
			text.text = string.Format("{0:00.00}", Time.time);
		}
	}
}