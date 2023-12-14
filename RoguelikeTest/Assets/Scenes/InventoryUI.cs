using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel; // 인벤토리 패널을 Inspector에서 할당합니다.
    bool activeInventory = false;
    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }
    void Update()
    {
        // I 키를 눌렀을 때 인벤토리 창을 토글합니다.
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}