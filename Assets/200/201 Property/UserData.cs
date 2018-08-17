using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertyTest{
	public enum JobKind {Normal, OneChohol, TweChohol}
	public class UserData : MonoBehaviour {

		public static UserData ins { get; private set; }

		void Awake(){
			ins = this;
		}

		public int exp { get; set; }
		public int level {
			get { return exp / 100; }
		}


		public JobKind job{
			get{
				if (level < 100) {
					return JobKind.Normal;
				} else if (level < 200) {
					return JobKind.OneChohol;
				} else {
					return JobKind.TweChohol;
				}
			}
			//set;
		}
	}
}
