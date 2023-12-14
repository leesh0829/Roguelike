using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public static Player instance;

    public int atk = 10;

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
         if(Input.GetKey(KeyCode.S)) {
            transform.Translate(0,-move_sp,0);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.Translate(move_sp,0,0);
        }
        if(Input.GetKey(KeyCode.A)) {
            transform.Translate(-move_sp,0,0);
        }
   }



    public List<slot> slotList;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Item") {

            //È¹µæ
            getItem(collision.gameObject.GetComponent<FieldItem>());
            Destroy(collision.collider.gameObject);
        }
    }

    void getItem(FieldItem item)
    {
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].tem == null)
            {
                slotList[i].tem = item;
                slotList[i].temImg.sprite = item.item.itemImage;
                break;
            }
        }
    }
}
