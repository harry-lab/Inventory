using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    public static UIInventory Instance { get; private set; }

    [SerializeField] private Transform content;
    [SerializeField] private GameObject itemSlotPrefab;
    [SerializeField] private Button backButton;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    public void ShowInventory(List<Item> items)
    {
        foreach (Transform child in content)
            Destroy(child.gameObject);

        foreach (Item item in items)
        {
            GameObject slotObj = Instantiate(itemSlotPrefab, content);
            ItemSlot slot = slotObj.GetComponent<ItemSlot>();
            slot.SetItem(item);
        }
    }

    public void Refresh()
    {
        ShowInventory(GameManager.Instance.Player.Inventory);
    }
}