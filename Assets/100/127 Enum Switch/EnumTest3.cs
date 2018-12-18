using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnumTest3Block{
	public enum ENUM_EQUIPMENT_PART { Hair, Chest, Legs, Toes, Arms };
	public class EnumTest3 : MonoBehaviour {
		//public ENUM_EQUIPMENT_PART[] partsc; 
		// -> 사이즈가 없으면 초기 오류가 난다...
		//    처음에는 아무것도 없는 상태....
		//    int[] a;
		// -> 1번 실행 오류가 발생하면.... 0 size
		//    int[] a = new int[0];
		//    이와같이 된다.... 음......
		//    결론 > 초기 사이즈를 [0]으로 설정해서 사용하자....

		public ENUM_EQUIPMENT_PART[] partsc = new ENUM_EQUIPMENT_PART[0];
		public ENUM_EQUIPMENT_PART[] parts2 = new ENUM_EQUIPMENT_PART[0];
		public ENUM_EQUIPMENT_PART[] parts3 = new ENUM_EQUIPMENT_PART[0];

		void Start(){
			foreach (ENUM_EQUIPMENT_PART _part in partsc) {
				Debug.Log ("partz -> " + _part); 
			}

			foreach (ENUM_EQUIPMENT_PART _part in parts2) {
				Debug.Log ("part2 -> " + _part); 
			}

			foreach (ENUM_EQUIPMENT_PART _part in parts3) {
				Debug.Log ("part3 -> " + _part); 
			}
		}

	}
}
