using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioClipRepeatable : MonoBehaviour
{
    public GameObject trigger;
    public AudioSource audioClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            trigger.SetActive(true);
            audioClip.Play();
        }
    }

    
}
