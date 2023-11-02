using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //
    public Rigidbody2D rd;
    //
    public float speed;

    public string playerTag = "Player";

    // Start is called before the first frame update
    void Start()
    {
        rd = this.gameObject.GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        float xMov;
        if (this.CompareTag(playerTag)) {
        xMov = Input.GetAxisRaw("Horizontal");

        rd.velocity = new Vector2(xMov * speed, rd.velocity.y);
        }
    }
}
