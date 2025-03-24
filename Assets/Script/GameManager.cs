using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    private IEnumerator Start()
    {

        while (
            UIManager.Instance == null ||
            UIMainMenu.Instance == null ||
            UIStatus.Instance == null ||
            UIInventory.Instance == null)
        {
            yield return null;
        }

        yield return null;

        SetData();
    }

    void SetData()
    {

        Player = new Character("Chad", 12, 83, 100, 2500, 30, 25, 100, 15);

        UIManager.Instance.UpdateMainMenu(Player);
        UIManager.Instance.UpdateStatus(Player);

        UIManager.Instance.OpenMainMenu(); // 메인 메뉴 UI 강제 호출
    }
}