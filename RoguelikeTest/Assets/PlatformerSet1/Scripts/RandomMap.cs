using System.Collections;

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;



public class RandomMap : MonoBehaviour

{

    public GameObject player;
    public int n = 9;
    private int RandomNum;
    public int Room_count=0;
    public GameObject[] location1 = new GameObject[10];
    int[] RandomArray = new int[10];
void Start() {
      for(int i=0 ; i<n ; i++) {
       RandomArray[i] = 0; 
    }
}
    public void Nextmap()
    {
       
        //랜덤한 방 이동
        while (true)
        {
            RandomNum = Random.Range(0, 9);
            //Debug.Log(RandomNum);
            if(RandomArray[RandomNum] != 1) 
            {
                break;
            }
        }
        for(int i=0 ; i<n ; i++) {
            if(RandomNum == i) 
            {
                player.transform.position = new Vector2(location1[i].transform.position.x, location1[i].transform.position.y);
                RandomArray[i] = 1;
                Room_count++;
                Debug.Log("맵 " + i);
            }
        }


    }

}