using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject statusUI;
    [SerializeField] private GameObject inventoryUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenMainMenu()
    {
        mainMenuUI.SetActive(true);
        statusUI.SetActive(false);
        inventoryUI.SetActive(false);
    }

    public void OpenStatus()
    {
        mainMenuUI.SetActive(false);
        statusUI.SetActive(true);
        inventoryUI.SetActive(false);
    }

    public void OpenInventory()
    {
        mainMenuUI.SetActive(false);
        statusUI.SetActive(false);
        inventoryUI.SetActive(true);
    }
}