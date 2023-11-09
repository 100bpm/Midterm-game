using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public string shootbutton;

    public Transform projectile;

    public float fireRate;

    float fireCooldown = 0;

    public string playerTag = "Player";

    public AudioSource SoundPlayer;

    public AudioClip shootSound;

    // Start is called before the first frame update
    void Start()
    {

        SoundPlayer.clip = shootSound;
    }

    // Update is called once per frame
    void Update()
    {
        fireCooldown += Time.deltaTime;

        //
        if (fireCooldown > fireRate
            && Input.GetButtonDown(shootbutton)
            && this.CompareTag(playerTag)) 
        {
            Shoot();
            //
            fireCooldown = 0;

            SoundPlayer.Play();

        }
    }

    void Shoot() 
    {
    //
    Instantiate(projectile, transform.position, Quaternion.identity); 
        
    

    }
}
