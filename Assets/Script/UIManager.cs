using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject statusUI;
    [SerializeField] private GameObject inventoryUI;

    [SerializeField] private GameObject statusButton;
    [SerializeField] private GameObject inventoryButton;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void OpenMainMenu()
    {
        mainMenuUI.SetActive(true);
        statusUI.SetActive(false);
        inventoryUI.SetActive(false);

        statusButton.SetActive(true);
        inventoryButton.SetActive(true);
    }

    public void OpenStatus()
    {
        mainMenuUI.SetActive(true);
        statusUI.SetActive(true);
        inventoryUI.SetActive(false);
        statusButton.SetActive(false);
        inventoryButton.SetActive(false);
    }

    public void OpenInventory()
    {
        mainMenuUI.SetActive(true);
        statusUI.SetActive(false);
        inventoryUI.SetActive(true);
        statusButton.SetActive(false);
        inventoryButton.SetActive(false);

        UIInventory.Instance.ShowInventory(GameManager.Instance.Player.Inventory);
    }

    public void UpdateMainMenu(Character character)
    {
        UIMainMenu.Instance.UpdateUI(character);
    }

    public void UpdateStatus(Character character)
    {
        UIStatus.Instance.UpdateUI(character);
    }
}
