using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    // Pickup and level completion logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;

    // Audio Proximity Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    // Update is called once per frame
    void Update(){
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    private void LevelCompleteCheck(){
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    private void UpdateGUI(){
        pickupText.text = "Pickups:" + currentPickups + "/" + maxPickups;
    }

    // Loop for playing audio proximity events - Audiosource based
    private void PlayAudioSamples(){
        for (int i = 0; i < audioSources.Length; i++){
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity){
                if(!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }

}
