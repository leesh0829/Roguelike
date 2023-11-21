using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public static Player instance;

   public float move_sp = 0.1f;

    public float cur_HP = 0;

    private void Awake()
    {
        instance = this;
    }

    void Update()
   {
    if(Input.GetKey(KeyCode.S)) {
            transform.Translate(0,-move_sp,0);
        }
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
