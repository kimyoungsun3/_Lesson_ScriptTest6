using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _401_Base
{
	public class Ui_Skill : MonoBehaviour
	{

		[SerializeField] Image skillImage;
		[SerializeField] Image skillImage2;
		[SerializeField] float SKILL_TIME = 2f;
		float skillTime;

		public void Invoke_Skill()
		{
			if (skillTime > 0) return;
			StartCoroutine(Co_Skill(skillImage, SKILL_TIME));
		}

		public void Invoke_Skill2()
		{
			if (skillTime > 0) return;
			StartCoroutine(Co_Skill(skillImage2, SKILL_TIME));
		}

		IEnumerator Co_Skill(Image _image, float _duration)
		{
			skillTime = _duration;
			float _speed	= 1f / _duration;
			float _percent	= 0;
			//Debug.Log(Time.time);
			while (_percent < 1f)
			{
				_percent += _speed * Time.deltaTime;
				_image.fillAmount = _percent;
				yield return null;
			}
			//Debug.Log(Time.time);
			_image.fillAmount = 1f;
			skillTime = 0;
		}
	}
}
