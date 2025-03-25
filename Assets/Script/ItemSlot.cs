using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private GameObject equippedIndicator; // "E" 표시 오브젝트

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        iconImage.sprite = item.Icon;
        countText.text = newItem.Count.ToString();
        UpdateEquippedState();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Character player = GameManager.Instance.Player;

        if (player.IsEquipped(item))
        {
            player.UnequipItem(item.Type);
        }
        else
        {
            player.EquipItem(item);
        }

        UIManager.Instance.UpdateStatus(player); // 스탯 UI 갱신
        UIInventory.Instance.Refresh();         // 인벤토리 새로고침
    }

    public void UpdateEquippedState()
    {
        equippedIndicator.SetActive(GameManager.Instance.Player.IsEquipped(item));
    }
}