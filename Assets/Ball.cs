using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        Launch();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity  = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
        transform.position = startPosition;
    }
}
