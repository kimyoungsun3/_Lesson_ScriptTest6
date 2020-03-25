using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassesTest{
	public class PlayerModel : MonoBehaviour {
		[System.Serializable]
	    public class Stuff
	    {
	        public int bullets;
	        public int grenades;
	        public int rockets;
	        
	        public Stuff(int bul, int gre, int roc)
	        {
	            bullets = bul;
	            grenades = gre;
	            rockets = roc;
	        }
	    }
	    
	    
	    public Stuff myData = new Stuff(10, 7, 25);
	    public float speed;
	    public float turnSpeed;
	    public Rigidbody bulletPrefab;
	    public Transform firePosition;
	    public float bulletSpeed;
	    
	    
	    void Update ()
	    {
	        Movement();
	        Shoot();
	    }
	    
	    
	    void Movement ()
	    {
	        float _v	= Input.GetAxis("Vertical") ;
	        float _h		= Input.GetAxis("Horizontal") ;
	        
	        transform.Translate(Vector3.forward * _v * speed * Time.deltaTime);
	        transform.Rotate(Vector3.up * _h * turnSpeed * Time.deltaTime);
	    }
	    
	    
	    void Shoot ()
	    {
	        if(Input.GetButtonDown("Fire1") && myData.bullets > 0)
	        {
	            Rigidbody _rb = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
	            _rb.AddForce(firePosition.forward * bulletSpeed);
	            myData.bullets--;

				Destroy (_rb.gameObject, 2f);
	        }
	    }
	}
}