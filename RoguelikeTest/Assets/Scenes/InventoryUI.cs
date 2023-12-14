using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel; // �κ��丮 �г��� Inspector���� �Ҵ��մϴ�.
    bool activeInventory = false;
    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }
    void Update()
    {
        // I Ű�� ������ �� �κ��丮 â�� ����մϴ�.
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}