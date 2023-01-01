using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControls : MonoBehaviour
{
    public float inputStrength =  40;
    // Update is called once per frame
    void Update()
    {
        
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        float input = Input.GetAxis("Horizontal");
        //rigid.AddForce(new Vector2(input*1000, 0));   // between -1 and 1
        rigid.velocity = new Vector2(input * inputStrength, 0);
    }
}
