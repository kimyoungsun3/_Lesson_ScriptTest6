﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComponentTest{
	public class Sheep3 : MonoBehaviour {
		public void ChangeColor(){
			GetComponent<Renderer> ().material.color = Color.blue;
		}
	}
}
