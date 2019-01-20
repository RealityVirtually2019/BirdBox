using UnityEngine;

// A script that plays your chosen song.  The pitch starts at 1.0.
// You can increase and decrease the pitch and hear the change
// that is made.


[RequireComponent(typeof(AudioSource))]

public class Pitch : MonoBehaviour
{
    public GameObject Capsule;
    AudioSource audioSource;
   

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        audioSource = GetComponent<AudioSource>();

        //Initialize the pitch
        audioSource.volume = 1 ;
    }

    void Update()
    {
       audioSource.volume = Capsule.transform.position.x/100;
        }
  }








