using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Javelin : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D collider;
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

    private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (!collisionInfo.gameObject.tag.Equals("Player"))
		{
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Enemy"))
		{
            rb.constraints = RigidbodyConstraints2D.None;
		}

    }
}
