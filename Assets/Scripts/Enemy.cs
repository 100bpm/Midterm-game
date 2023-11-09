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
  

    public float speed;



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
        moveEnemy();

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


            SoundPlayer.Play();

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


            Destroy(this.gameObject);
            Destroy(other.gameObject);
           

        }


    }
    void moveEnemy()
    {

        Vector3 newPos = transform.position;
        //
        newPos += -transform.up * speed * Time.deltaTime;
        //
        transform.position = newPos;

    }

    void Shoot()
    {
        //
       Instantiate(projectile, transform.position, Quaternion.identity);

       

    }






}
