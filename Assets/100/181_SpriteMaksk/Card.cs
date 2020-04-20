using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace _181_SpriteMask
{
	public enum eCardGrade { Normal, NormalPlus, Rare, RarePlus};
	public class Card : MonoBehaviour
	{
		[SerializeField] eCardGrade grade;
		[SerializeField] SpriteRenderer renderBack, render, renderFront;
		[SerializeField] Sprite spriteBack, sprite, spriteFront;
		// Use this for initialization
		void Start()
		{

		}

#if UNITY_EDITOR
		private void OnDrawGizmos()
		{
			renderBack.sprite	= spriteBack;
			render.sprite		= sprite;
			renderFront.sprite	= spriteFront;
		}
#endif
	}
}

