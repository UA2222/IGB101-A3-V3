using UnityEngine;

public class Pickup : MonoBehaviour {
    GameManager gameManager;

    void Start() {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject) {
        if (otherObject.transform.tag == "Player") {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
    }
}