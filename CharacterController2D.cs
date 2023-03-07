using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

 
public class CharacterController2D : MonoBehaviour
{
	 private Rigidbody2D rigidbodyCache;
	private void FixedUpdate()
	{

         if (Input.GetButtonDown("Jump"))
        {
           // Vector3 targetVelocity = new Vector2( 10f, m_Rigidbody2D.velocity.y);
            GameObject.Find("mario03").GetComponent<Rigidbody2D>().AddForce(transform.up * 100);
        }

	}
		


    void Update() {
        rigidbodyCache = GetComponent<Rigidbody2D>();
		rigidbodyCache.velocity = new Vector3(0, rigidbodyCache.velocity.y, 0); //Set X and Z velocity to 0
 
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 20, 0, 0);
		
		 if (Input.GetButtonDown("Jump"))
        {
           // Vector3 targetVelocity = new Vector2( 10f, m_Rigidbody2D.velocity.y);
            GameObject.Find("mario03").GetComponent<Rigidbody2D>().AddForce(transform.up * 100);
        }
		//transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime * 20, 0);
	}
}