using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _181_SpriteMask
{
	public class ChangeList : MonoBehaviour
	{
		public SpriteRenderer renderer;
		public List<Sprite> list = new List<Sprite>();
		int index = 0;

		// Use this for initialization
		void Start()
		{
			renderer.sprite = list[index];
		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				index = (index + 1) % list.Count;
				renderer.sprite = list[index];
			}
		}
	}
}
