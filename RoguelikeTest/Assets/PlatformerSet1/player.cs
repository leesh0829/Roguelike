using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float move_sp = 0.1f;
   void Start()    
   {
    
   }

   void Update()
   {
     if(Input.GetKey(KeyCode.W)) {
            transform.Translate(0,move_sp,0);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.Translate(move_sp,0,0);
        }
        if(Input.GetKey(KeyCode.A)) {
            transform.Translate(-move_sp,0,0);
        }
   }
}
