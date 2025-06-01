using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioSource[] audioSources;
    public float audioProx = 5.0f;

    public GameObject player;
    public Text pickupText;
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
	
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
		PlayAudioSamples();
    }

    private void PlayAudioSamples()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProx)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }

    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
        {
            levelComplete = true; 
        }
        else
        {
            levelComplete = false;
        }
    }
}
