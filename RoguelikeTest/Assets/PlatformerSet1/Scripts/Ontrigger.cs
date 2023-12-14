using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Ontrigger : MonoBehaviour
{
    public RandomMap RandomMaps;
    private void OnTriggerEnter2D(Collider2D other) {
            if(RandomMaps.Room_count < 9) {
            Debug.Log("닿음");
            RandomMaps.Nextmap();
            }
    }

}
