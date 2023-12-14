using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    private GameObject m_goHpBar;

    [SerializeField]
    private Slider hpbar;
    private float maxHp = 100;
    private float curHp = 100;
    float imsi;
    void Start()
    {
        hpbar.value = (float)curHp / (float)maxHp;
        m_goHpBar = GameObject.Find("Canvas/Slider");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (curHp > 0)
            {
                curHp -= 10;
            }
            else
            {
                curHp = 0;
            }
            CallHp();
        }
        // 오브젝트를 따라가는  HP Bar 위치 이동
        m_goHpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));

        if(curHp == 0)
        {

        }
    }

    private void CallHp()
    {
        //대미지를 받을 때마다 현재 채력값 호출해서 초기화
        hpbar.value = Mathf.Lerp(hpbar.value, imsi, Time.deltaTime * 10);
    }
}
