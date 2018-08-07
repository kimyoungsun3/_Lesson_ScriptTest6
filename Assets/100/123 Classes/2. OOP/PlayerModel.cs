using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassesTest2{
	public class PlayerModel : MonoBehaviour {
	    
	    public Stuff myStuff = new Stuff(10, 7, 25);

		PlayerController controller;
		PlayerShooting shooting;

		void Start(){
			controller = GetComponent<PlayerController> ();
			shooting = GetComponent<PlayerShooting> ();
		}
	    
	    
	    void Update ()
	    {
			controller.Movement();
			shooting.Shoot(myStuff);
	    }
	    
	    
	    
	}
}