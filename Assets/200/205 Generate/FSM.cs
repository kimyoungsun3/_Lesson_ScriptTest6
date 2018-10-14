using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GenerateTest{
	public delegate void VOID_FUN_VOID();
	public class FSMData<T>{
		public T state;
		public VOID_FUN_VOID cbIn;
		public VOID_FUN_VOID cbLoop;
		public VOID_FUN_VOID cbOut;

		public FSMData(T _state, VOID_FUN_VOID _cbIn, VOID_FUN_VOID _cbLoop, VOID_FUN_VOID _cbOut){
			state 	= _state;
			cbIn 	= _cbIn;
			cbLoop 	= _cbLoop;
			cbOut 	= _cbOut;
		}
	}

	public class FSM<T> : MonoBehaviour {
		[HideInInspector] public T preState;
		[HideInInspector] public T curState;
		[HideInInspector] public T nextState;
		public VOID_FUN_VOID cbIn, cbLoop, cbOut;

		public Dictionary<T, FSMData<T>> dicState = new Dictionary<T, FSMData<T>>();

		public void AddState(T _t, VOID_FUN_VOID _cbIn, VOID_FUN_VOID _cbLoop, VOID_FUN_VOID _cbOut){
			if (!dicState.ContainsKey (_t)) {
				dicState.Add(_t, new FSMData<T>(_t, _cbIn, _cbLoop, _cbOut));
			}
		}

		public void MoveState(T _nextState){
			if(!dicState.ContainsKey(_nextState)){
				Debug.LogError ("Not found State:" + _nextState);
				return;
			}

			if (cbOut != null) {
				cbOut ();
			}

			preState = curState;
			curState = _nextState;
			nextState = _nextState;

			FSMData<T> _data = dicState[_nextState];
			cbIn 	= _data.cbIn;
			cbLoop 	= _data.cbLoop;
			cbOut 	= _data.cbOut;

			if (cbIn != null) {
				cbIn ();
			}
		}

		void Update(){
			if (cbLoop != null) {
				cbLoop ();
			}
		}
	}
}