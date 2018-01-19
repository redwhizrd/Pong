using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public Rigidbody2D rb;
    private Vector2 inDirection;
    private float speed = .1f;
    public CircleCollider2D cc2d;
    // Use this for initialization


    void Start () {
        inDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.Translate(inDirection * speed, Space.World);
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        var contactPoint = col.contacts[0].point;
        Vector2 ballLocation = transform.position;
        var inNormal = (ballLocation - contactPoint).normalized;
        inDirection = Vector2.Reflect(inDirection, inNormal);
        
    }

  
}
