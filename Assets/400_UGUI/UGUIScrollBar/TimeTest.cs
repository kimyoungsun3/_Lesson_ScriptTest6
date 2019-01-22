using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UGUIScrollBar{
	public class TimeTest : MonoBehaviour {
		Slider slider;
		float time;
		public float GAME_TIME = 5 * 60f;
		float barValue;
		float barSafeValue;
		public Image fg;
		Color orginalColor;
		float GAME_PLAY_TIME = 5 * 60f;
		float GAME_SAFE_TIME = 30f;

		void Start () {
			slider = GetComponent<Slider> ();

			time 			= Time.time;
			barValue 		= 1f;
			barSafeValue = GAME_SAFE_TIME / GAME_PLAY_TIME;
			orginalColor = fg.color;
		}
		
		// Update is called once per frame
		void Update () {
			float _dt = Time.time - time;
			Debug.Log (_dt + " > ");
			_dt = GAME_PLAY_TIME - _dt % GAME_PLAY_TIME;
			barValue = _dt / GAME_PLAY_TIME;
			Debug.Log (" > " + _dt + " > " + barValue);

			slider.value = barValue;
			fg.color = orginalColor;
			if (barValue < barSafeValue) {
				fg.color = Color.red;
			}
		}
	}
}
