using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string enemyTag = "Enemy";
    public string bulletTag = "Bullet";
    public string enemyBulletTag = "enemyBullet";

    public GameObject gameOverObject;
    public GameObject winScreenObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag(enemyTag).Length == 0)
        {


            //win screen is shown 
            winScreenObject.SetActive(true);
            //timescale is set to 0, pausing game
            Time.timeScale = 0f;

        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag(enemyBulletTag))
        {

            //we display the name of the object we collided with 
            Debug.Log("Colided with object " + other.gameObject.name);

            Destroy(other.gameObject);
            //the game over screen is shown
            gameOverObject.SetActive(true);
            //timescale is set to 0
           Time.timeScale = 0f;
            

        }


        if (other.CompareTag(enemyTag))
        {

            //we display the name of the object we collided with 
            Debug.Log("Colided with object " + other.gameObject.name);

           
            //the game over screen is shown
            gameOverObject.SetActive(true);
            //timescale is set to 0
            Time.timeScale = 0f;


        }



    }


}
