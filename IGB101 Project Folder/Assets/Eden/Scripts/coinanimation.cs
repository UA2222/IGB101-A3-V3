using UnityEngine;

public class coinanimation : MonoBehaviour
{
    Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPos + (Mathf.Sin(Time.time) * Vector3.up * 0.5f);
        transform.eulerAngles = Vector3.up * Time.time * 45;
    }
}
