using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float rand;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke ("GoFire",2f);
    }

    void GoFire()
    {
        rand = Random.Range(0, 2);
        if (rand == 0) rb2d.AddForce(new Vector2(20, -15));
        else rb2d.AddForce(new Vector2(-20, -15));
    }
    public void RestartGame()
    {
        ResetBall();
        Invoke("GoFire", 2f);
    }
    private void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
}