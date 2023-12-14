using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
 Rigidbody2D rb;
float speed = 10f;

       

   void Start()    
   {
     rb = gameObject.GetComponent<Rigidbody2D>();
   }

   void Update()
   {
     float xMove = Input.GetAxis("Horizontal");
     float zMove = Input.GetAxis("Vertical");

     Vector3 getVel = new Vector3(xMove, zMove, 0) * speed;
     rb.velocity = getVel;
   }
}
