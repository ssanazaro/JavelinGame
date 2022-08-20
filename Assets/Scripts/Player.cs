using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private Rigidbody2D rb;
	public Javelin javelin;
	public float mapWidth = 10f;
	public bool isGrounded = false;
	public bool hasJavelin = true;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		var movement = FindObjectOfType<PlayerMovement>();

		if (hasJavelin == false && Input.GetButtonDown("Fire2"))
		{
			FindObjectOfType<Javelin>().SummonJaveline();
			hasJavelin = true;
		}
	}

	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag.Equals("Ground"))
		{
			isGrounded = true;
		}
		if (collisionInfo.gameObject.tag.Equals("Javelin"))
		{
			hasJavelin = true;
			Destroy(collisionInfo.gameObject);

		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Ground"))
		{
			isGrounded = false;
		}
	}
}
