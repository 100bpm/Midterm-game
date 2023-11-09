using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSound : MonoBehaviour

{


    public AudioSource SoundPlayer;

    public AudioClip shootSound;



    // Start is called before the first frame update
    void Start()
    {
        //we tell the audio source what clip it will play
        SoundPlayer.clip = shootSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
