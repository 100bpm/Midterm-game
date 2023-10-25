using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public string shootbutton;

    public Transform projectile;

    public float fireRate;

    float fireCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        fireCooldown += Time.deltaTime;

        //
        if (fireCooldown > fireRate
            && Input.GetButtonDown(shootbutton)) 
        {
            Shoot();
            //
            fireCooldown = 0;
        
        }
    }

    void Shoot() 
    {
    //
    Instantiate(projectile, transform.position, Quaternion.identity);
    
    }
}
