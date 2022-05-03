using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    // Ressources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player player;

    // Logic
    public int Rumin;
    public int exp;

    public void SaveState()
    {
        string save = "";

        save += Rumin.ToString() + "|";
    }

    public void LoadState()
    {
        Debug.Log("LoadState");
    }
}
