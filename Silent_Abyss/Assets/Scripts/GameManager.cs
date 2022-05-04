using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    // Ressources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player player;
    public FloatingText floatingText;

    // Logic
    public int rumin;
    public int exp;



    public void SaveState()
    {
        string save = "";

        save += rumin.ToString() + "|";
        save += exp.ToString() + "|";
        save += "0";

        PlayerPrefs.GetString("SaveState", save);
    }
    public void LoadState(Scene save, LoadSceneMode mode)
    {
        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        rumin = int.Parse(data[1]);
        exp = int.Parse(data[2]);

        Debug.Log("LoadState");
    }
}
