using UnityEngine;

public class coinaudio : MonoBehaviour
{
    public static coinaudio instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }

}
