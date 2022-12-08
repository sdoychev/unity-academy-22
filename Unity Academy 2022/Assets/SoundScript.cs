using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip alarm;
    public AudioClip beep;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.PlayOneShot(beep, 0.25f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioSource.PlayDelayed(3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //Play on Awake 
        }
    }
}
