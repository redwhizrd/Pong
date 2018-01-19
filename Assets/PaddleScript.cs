using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    public bool isFirst = false;
    // Use this for initialization
    AudioSource asss;
    void Start () {

        asss = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (isFirst)
        {
            Vector3 position = this.transform.position;
           
            
            if (Input.GetKey(KeyCode.W))
                position.y+=.1f;
            if (Input.GetKey(KeyCode.S))
                position.y-=.1f;

            this.transform.position = position;
        }
        else
        {
            Vector3 position = this.transform.position;
            if (Input.GetKey(KeyCode.UpArrow))
                position.y+=.1f;
            if (Input.GetKey(KeyCode.DownArrow))
                position.y-=.1f;

            this.transform.position = position;
        }
	}


    void OnCollisionEnter2D(Collision2D col)
    {

        asss.Play();
        if (isFirst)
        {
        }
        else
        {
            
        }
    }

}
