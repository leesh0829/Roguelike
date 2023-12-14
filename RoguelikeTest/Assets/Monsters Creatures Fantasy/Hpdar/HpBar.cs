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
        // ������Ʈ�� ���󰡴�  HP Bar ��ġ �̵�
        m_goHpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));

        if(curHp == 0)
        {

        }
    }

    private void CallHp()
    {
        //������� ���� ������ ���� ä�°� ȣ���ؼ� �ʱ�ȭ
        hpbar.value = Mathf.Lerp(hpbar.value, imsi, Time.deltaTime * 10);
    }
}
