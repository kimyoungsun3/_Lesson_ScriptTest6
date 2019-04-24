using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money  {
	private int a, b, c;
	int divide = 3;

	public Money(int _m)
	{
		InitMoney(_m);
	}

	public void InitMoney(int _m)
	{
		int _val = _m / divide;
		a = _val;
		b = _val;
		c = _m - _val * 2;
	}

	public void PlusMoney(int _plus)
	{
		if(GetMoney() + _plus < 0)
			return;

		int _val = _plus / divide;
		a += _val;
		b += _val;
		c += _plus - _val * 2;
	}

	public int GetMoney()
	{
		return a + b + c;
	}

	public override string ToString()
	{
		return a + ":" + b + ":" + c;
	}
}
