using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip intro;
    public AudioClip music;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = intro;
        audioSource.Play();
    }

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
