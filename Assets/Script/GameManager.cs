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
        // ���� ������
        Player = new Character("Chad", 12, 83, 100, 2500, 30, 25, 100, 15);

        // UI�� ������ ����
        UIManager.Instance.UpdateMainMenu(Player);
        UIManager.Instance.UpdateStatus(Player);
    }
}