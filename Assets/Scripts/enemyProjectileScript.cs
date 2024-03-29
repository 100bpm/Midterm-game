using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectileScript : MonoBehaviour
{


    public float speed;

    public float lifetime;

    private float lifetimeCounter = 0;

    // Update is called once per frame
    void Update()
    {

        MoveProjectile();
        //
        lifetimeCounter += Time.deltaTime;
        //
        if (lifetimeCounter > lifetime)
        {
            //destory this object
            Destroy(this.gameObject);
        }
    }

    void MoveProjectile()
    {   //
        Vector3 newPos = transform.position;
        //
        newPos += -transform.up * speed * Time.deltaTime;
        //
        transform.position = newPos;
    }


}
