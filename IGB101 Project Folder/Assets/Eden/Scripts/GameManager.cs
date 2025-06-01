using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject player;
    public Text pickupText;

    // level logic stuffs
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;


    private void UpdateGUI()
    {
        pickupText.text = "Coins: " + currentPickups + "/" + maxPickups;
    }

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }
}
