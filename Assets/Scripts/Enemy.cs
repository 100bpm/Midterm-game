using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [Header("Collision Detection")]
    //
    public string projectileTag;


    [Header("Particle Effect")]
    //
   // public Transform EnemyExplosion;

    [Header("fake enemy destruction")]
    //
    public GameObject EnemyMesh;
    public Collider2D EnemyCollider;

    [Header("Enemy Shooting")]
    public Transform projectile;
    //
    public float fireRate;
    //
    float fireCooldown = 0;



    // Update is called once per frame
    void Update()
    {
        fireCooldown += Time.deltaTime;

        //
       /* if (fireCooldown > fireRate)
        {
            Shoot();
            //
            fireCooldown = 0;

        }*/
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag(projectileTag))
        {
            //
           // ScoreManager.Instance.AddScore(10);


           // Instantiate(EnemyExplosion,
            //    this.transform.position,
              //  this.transform.rotation,
                //this.transform);


            //instead of destorying game object we disable the mesh and collider
            EnemyMesh.SetActive(false);
            EnemyCollider.enabled = false;

        }


    }


    void Shoot()
    {
        //
       // Instantiate(projectile, transform.position, Quaternion.identity);

    }






}
