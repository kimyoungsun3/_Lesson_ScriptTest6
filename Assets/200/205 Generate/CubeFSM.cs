using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerateTest{
	public class CubeFSM : FSM<CubeFSM.State> {
		public enum State { Move, Rotate, Wait }
		Vector3 nextPoint;
		Quaternion nextRotation;
		float nextTime;
		public float moveSpeed = 2f;
		public float turnSpeed = 30f;
		public float NEXT_TIME = 1f;

		void Start () {
			AddState (State.Move, 	PInMove, 	ModifyMove, 	OutMove);
			AddState (State.Rotate, PInRotate, 	ModifyRotate, 	null);
			AddState (State.Wait, 	PInWait, 	ModifyWait, 	null);

			MoveState (State.Move);
		}

		//---------------------------
		void PInMove(){
			nextPoint = transform.position + transform.forward * 2f;
		}

		void ModifyMove(){
			if (transform.position == nextPoint) {
				MoveState (State.Rotate);
				return;
			}

			transform.position = Vector3.MoveTowards (transform.position, nextPoint, moveSpeed * Time.deltaTime);
		}
		void OutMove(){
			Debug.Log ("EndMove");
		}


		//---------------------------
		void PInRotate(){
			nextRotation = transform.rotation * Quaternion.Euler(Vector3.up * 90f);
		}

		void ModifyRotate(){
			if (transform.rotation == nextRotation) {
				MoveState (State.Wait);
				return;
			}

			transform.rotation = Quaternion.RotateTowards (transform.rotation, nextRotation, turnSpeed * Time.deltaTime);
		}

		//---------------------------
		void PInWait(){
			nextTime = Time.time + NEXT_TIME;
		}

		void ModifyWait(){
			if (Time.time > nextTime) {
				MoveState (State.Move);
				return;
			}
		}
	}
}
