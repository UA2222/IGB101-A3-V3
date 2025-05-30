using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class LevelScript : MonoBehaviour {

    GameManager gameManager;
    public string nextLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject){

        if (otherObject.transform.tag == "Player") {

            if(gameManager.levelComplete){
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
