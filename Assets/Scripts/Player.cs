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
		rb.constraints = RigidbodyConstraints2D.FreezeRotation;
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
		if (collisionInfo.gameObject.tag.Equals("Ground") || collisionInfo.gameObject.tag.Equals("Javelin"))
		{
			isGrounded = true;
		}
		if (collisionInfo.gameObject.tag.Equals("Wall"))
		{
			isGrounded = false;
		}
		if (collisionInfo.gameObject.tag.Equals("Enemy") || collisionInfo.gameObject.tag.Equals("Hazard"))
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Ground") || collision.gameObject.tag.Equals("Javelin"))
		{
			isGrounded = false;
		}
	}
}
