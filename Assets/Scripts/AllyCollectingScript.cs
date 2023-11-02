using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCollectingScript : MonoBehaviour
{
    public GameObject ally;
    public string newTag = "Player";
    public string playerTag = "Player";
    public float xPos;
    public float yPos;
    public float zPos;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        xPos = other.transform.position.x;
        yPos = other.transform.position.y;
        zPos = other.transform.position.z;

        if (other.CompareTag(playerTag))
        {
            
            gameObject.tag = newTag;

            MoveGameObject();

            gameObject.GetComponent<enemyProjectileScript>().enabled = false;
            GetComponent<Collider2D>().isTrigger = false;

        }
    }

    public void MoveGameObject()
    {


        // gameObject.transform.position = new Vector3(x, y, z);

        
            gameObject.transform.position = new Vector3(xPos + 1, yPos, zPos);

           // isAlly = true;

        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.y;
        zPos = gameObject.transform.position.z;

        


      

    }



}
