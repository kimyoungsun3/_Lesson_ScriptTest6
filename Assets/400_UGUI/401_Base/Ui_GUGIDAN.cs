using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _401_Base
{
	public class Ui_GUGIDAN : MonoBehaviour
	{
		[SerializeField] Text text;
		int gugu = 2;
		public void Invoke_GuGudan()
		{
			string _str = "";
			for(int i = 1; i <= 9; i++)
			{
				_str += gugu + " * " + i + " = " + (gugu * i) + "\n";
			}
			text.text = _str;
			gugu++;
			if (gugu > 9) gugu = 2;
		}
	}
}
