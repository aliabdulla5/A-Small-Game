using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int keysCollected = 0;
    public int totalKeys = 3;

    public TMP_Text keyText;
    public GameObject door;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void CollectKey()
    {
        keysCollected++;
        UpdateUI();

        if (keysCollected >= totalKeys)
        {
            keyText.text = "Door Unlocked!";
        }
    }

    void UpdateUI()
    {
        keyText.text = "Coins: " + keysCollected + "/" + totalKeys;
    }

    public void WinGame()
    {
        SceneManager.LoadScene("WinScene");
    }
}