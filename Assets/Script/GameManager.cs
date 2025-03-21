using UnityEngine;

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

    private void Start()
    {
        SetData();
    }

    void SetData()
    {
        // 예시 데이터
        Player = new Character("Chad", 12, 83, 100, 2500, 30, 25, 100, 15);

        // UI에 데이터 전달
        UIManager.Instance.UpdateMainMenu(Player);
        UIManager.Instance.UpdateStatus(Player);
    }
}