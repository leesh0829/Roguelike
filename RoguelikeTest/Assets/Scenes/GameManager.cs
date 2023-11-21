using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void Start()
    {
        Debug.Log(Player.instance.move_sp);
    }

    private void Update()
    {
        if (Player.instance.cur_HP <= 0 )
        {
            Debug.Log("�÷��̾�����");
            gameOverPanel.SetActive(true);
        }
    }
}
