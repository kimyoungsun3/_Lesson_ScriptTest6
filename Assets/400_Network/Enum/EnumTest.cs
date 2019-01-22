using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NetworkBase;

namespace NetworkEnum
{
	public class EnumTest : MonoBehaviour
	{		
		void Start(){

			LOGIN_PROTO _codeEnum = LOGIN_PROTO.CHART_MSG_REQ | LOGIN_PROTO.ATTACK;
			Debug.Log((int)_codeEnum + " <- " + _codeEnum);

			int _code = 19;
			Debug.Log((LOGIN_PROTO)_code + " <- " + _code);
		}
	}
}
