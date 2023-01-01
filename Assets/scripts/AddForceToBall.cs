using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToBall : MonoBehaviour
{
    public int forceX, forceY;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigi;
        rigi = GetComponent<Rigidbody2D>();
        rigi.AddForce(new Vector2(forceX, forceY));
    }
}
