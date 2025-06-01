using UnityEngine;

public class dooropen : MonoBehaviour
{
    public GameObject player;
    public Animation anim;
    public float distance = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            float dist = Vector3.Distance(transform.position, player.transform.position);
            if (dist <= distance)
            {
                anim.Play();
            }
        }
    }
}
