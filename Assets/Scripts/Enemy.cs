using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	//private void OnCollision2D(Collider2D collision)
	//{
	//       if (collision.tag.Equals("Javelin"))
	//	{
	//           Destroy(gameObject);
	//	}
	//}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Javelin"))
		{
			Destroy(gameObject);
		}
	}
}
