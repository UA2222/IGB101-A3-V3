using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainFade : MonoBehaviour
{
    AudioSource rainFind;
    const float fadeTime = 5;
    float VolumeRain = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rainFind = GetComponent<AudioSource>();
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        var timeElapsed = 0f;

        while (rainFind.volume < 1)
        {
            rainFind.volume = Mathf.Lerp(0, VolumeRain, timeElapsed / fadeTime);
            timeElapsed += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
