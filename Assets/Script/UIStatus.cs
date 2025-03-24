using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class UIStatus : MonoBehaviour
{
    public static UIStatus Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI criticalText;
    [SerializeField] private Button backButton;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    public void UpdateUI(Character character)
    {
        attackText.text = $"Attack: {character.Attack}";
        defenseText.text = $"Defense: {character.Defense}";
        hpText.text = $"HP: {character.HP}";
        criticalText.text = $"Critical: {character.Critical}%";
    }
}