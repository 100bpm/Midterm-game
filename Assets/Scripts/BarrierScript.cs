using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    public int health = 3;
    private int hits;

    public string enemyTag = "Enemy";

    public Collider2D BarrierCollider;


    // Update is called once per frame
    void Update()
    {
        if (health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    public void Deducthealth(int damangeAmount) 
    {

        health -= damangeAmount;
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.CompareTag(enemyTag)) 
        {
            Deducthealth(1);
            Destroy(other.gameObject);
        
        }
    }
}
