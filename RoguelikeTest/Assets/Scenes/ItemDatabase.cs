using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this; 
    }
    public List<Item> itemDB = new List<Item>();
    public List<slot> slotDB = new();


    public void GetItem()
    {
        slotDB[0].
    }
}
