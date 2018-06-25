using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPOpSound : MonoBehaviour
{



    public AudioClip SoundToPlay;
    public AudioSource source;


    void Awake()
    {

        source = GetComponent<AudioSource>();
    }

    void playSound()
    {

        source.PlayOneShot(SoundToPlay);
        Debug.Log("Audio");
    }

    void Update()
    {






    }
}
