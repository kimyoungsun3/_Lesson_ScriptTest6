using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour {
	public int capacity = 4;
	public Stack<int> stack;
	// Use this for initialization
	void Start () {
		stack = new Stack<int>(capacity);
		Debug.Log("mouse 0:stack push, 1:stack pop");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			stack.Push(Random.Range(0, 10));
			Debug.Log("Push > " + stack.Count);
		}else if (Input.GetMouseButtonDown(1))
		{
			if (stack.Count > 0)
			{
				stack.Pop();
			}
			Debug.Log("Pop > " + stack.Count);
		}
	}
}
