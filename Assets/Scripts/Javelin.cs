using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Javelin : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SummonJaveline()
    {
        Destroy(gameObject);
    }
}
