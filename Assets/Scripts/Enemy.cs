using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    
    public string bulletTag = "Bullet";
    public string enemyTag = "Enemy";
    public string enemyBulletTag = "enemyBullet";

    //
    // public Transform EnemyExplosion;





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

        
        Debug.DrawRay(this.transform.position + raycastOriginalOffset,
           -Vector2.up * maxDistance, Color.red);

        //
        RaycastHit2D downRay = Physics2D.Raycast(transform.position + raycastOriginalOffset, -Vector2.up, 
            maxDistance, raycastLayers);


        //
        if (fireCooldown > fireRate
            && downRay.collider != null
            && GameObject.FindGameObjectsWithTag(enemyBulletTag).Length < 1)
        {

        Debug.Log(downRay.collider.name);
           

            Shoot();
            //
            fireCooldown = 0;

        }


        

    }

    //if enemy takes damage it will be destroyed
    private void OnTriggerEnter2D(Collider2D other) {

        if (other.CompareTag(bulletTag))
        {
            //
            ScoreManager.Instance.AddScore(10);


            // Instantiate(EnemyExplosion,
            //   this.transform.position,
            // this.transform.rotation,
            //this.transform);

            Destroy(this.gameObject);
            Destroy(other.gameObject);
           

        }


    }


    void Shoot()
    {
        //
       Instantiate(projectile, transform.position, Quaternion.identity);

    }






}
