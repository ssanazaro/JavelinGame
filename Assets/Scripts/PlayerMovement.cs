using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;
	public Player player;
	public bool facingRight = true;
	public float speed = 5f;
	public float jumpAmount = 10f;


	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded == true)
		{
			Debug.Log("Jump");
			Jump();
		}
		Movement();
	}

	Vector2 Movement()
	{
		if (Input.GetKey(KeyCode.A))
		{
			if (facingRight == true)
			{
				Flip();
				facingRight = false;
			}
			return rb.velocity = new Vector2(-speed, rb.velocity.y);
		}
		else
		{
			if (Input.GetKey(KeyCode.D))
			{
				if (facingRight == false)
				{
					Flip();
					facingRight = true;
				}
				return rb.velocity = new Vector2(+speed, rb.velocity.y);
			}
			else
			{
				return rb.velocity = new Vector2(0, rb.velocity.y);
			}
		}
	}

	public void Jump()
	{
		rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
	}

	private void Flip()
	{
		transform.Rotate(0f, 180f, 0f);
	}
}
