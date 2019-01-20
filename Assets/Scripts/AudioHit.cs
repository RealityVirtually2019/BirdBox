using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]

public class AudioHit : MonoBehaviour {
 
  //Add this Script Directly to The Death Zone

    public AudioClip saw;    // Add your Audi Clip Here;
    private string object1;

    // This Will Configure the  AudioSource Component; 
    // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected

    {
        GetComponent<AudioSource>().Play();
        Debug.Log("hit: " + object1);
    }
    // Make sure that deathzone has a collider, box, or mesh.. ect..,
    // Make sure to turn "off" collider trigger for your deathzone Area;
    // Make sure That anything that collides into deathzone, is rigidbody;
}
