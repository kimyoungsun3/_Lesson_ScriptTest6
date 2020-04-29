using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace _180_2DSpriteAtlas
{
	public class ChangeSprite : MonoBehaviour
	{
		[SerializeField] SpriteAtlas atlas;
		SpriteRenderer renderer;
		[SerializeField] List<string> spriteNames = new List<string>();
		string currentName;
		int index = 0;

		// Use this for initialization
		void Start()
		{
			renderer	= GetComponent<SpriteRenderer>();
			currentName	= spriteNames[index];
			renderer.sprite = atlas.GetSprite(currentName);
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.anyKeyDown)
			{
				index = (index + 1) % spriteNames.Count;
				//Debug.Log(currentName + ":" + index + ":" + spriteNames[index]);
			}

			if (currentName != (spriteNames[index]))
			{
				currentName = spriteNames[index];
				renderer.sprite = atlas.GetSprite(currentName);
			}

		}
	}
}
