using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTitleAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip music;
    // Update is called once per frame
    void Update()
    {
         if (!(audioSource.isPlaying))
        {
            audioSource.clip = music;
            audioSource.Play();
        }
    }
}
