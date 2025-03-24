using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public static UIMainMenu Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI xpText;
    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        statusButton.onClick.AddListener(() => UIManager.Instance.OpenStatus());
        inventoryButton.onClick.AddListener(() => UIManager.Instance.OpenInventory());
    }

    public void UpdateUI(Character character)
    {
        nameText.text = character.Name;
        levelText.text = $"Lv. {character.Level}";
        xpText.text = $"{character.CurrentXP} / {character.MaxXP}";
        coinText.text = $"{character.Coins}G";

    }
}