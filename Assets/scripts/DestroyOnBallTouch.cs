using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBallTouch : MonoBehaviour
{
    public GameObject textUI;
    void OnCollisionEnter2D(Collision2D other)
    {
        AdjustScore adjustScore = textUI.GetComponent<AdjustScore>();
        adjustScore.incrementScore();

        GameObject.Destroy(gameObject);
    }
}
