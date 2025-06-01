using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animation animation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q") && Vector3.Distance(transform.position, PlayerMovement.instance.transform.position)< 6 )
            animation.Play();
    }
}
