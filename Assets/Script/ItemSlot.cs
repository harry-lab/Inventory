using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI countText;

    public void SetItem(Item item)
    {
        iconImage.sprite = item.Icon;
        countText.text = item.Count.ToString();
    }
}