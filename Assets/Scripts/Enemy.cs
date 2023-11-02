using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [Header("Collision Detection")]
    //
    public string playerProjectileTag = "Player";


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

    //how far the player must be from the enemy for it to shoot 
    public float maxDistance;
    //
    public Vector3 raycastOriginalOffset;

    public LayerMask raycastLayers;

    // Update is called once per frame
    void Update()
    {
        fireCooldown += Time.deltaTime;

        //Ray2D floordetection = new Ray2D(this.transform.position, -Vector2.up);
        Debug.DrawRay(this.transform.position + raycastOriginalOffset,
           -Vector2.up * maxDistance, Color.red);

        // Cast a ray straight down.
        RaycastHit2D downRay = Physics2D.Raycast(transform.position + raycastOriginalOffset, -Vector2.up, 
            maxDistance, raycastLayers);


        //
        if (fireCooldown > fireRate
            && downRay.collider != null)
        {
        Debug.Log(downRay.collider.name);
            Shoot();
            //
            fireCooldown = 0;

        }
    }

    //if enemy takes damage it will be destroyed
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag(playerProjectileTag))
        {
            //
            ScoreManager.Instance.AddScore(10);


            // Instantiate(EnemyExplosion,
            //   this.transform.position,
            // this.transform.rotation,
            //this.transform);

            Destroy(this.gameObject);
            //
            //EnemyMesh.SetActive(false);
            //EnemyCollider.enabled = false;

        }


    }


    void Shoot()
    {
        //
       Instantiate(projectile, transform.position, Quaternion.identity);

    }






}
