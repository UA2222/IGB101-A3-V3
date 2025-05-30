using UnityEngine;

public class Door : MonoBehaviour
{

    public Animation anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown("f"))
        // {
        //     anim.Play();
        // }
    }

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            anim.Play();
        }
}
}
