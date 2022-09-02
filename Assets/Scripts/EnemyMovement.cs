using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	float timeElapsed;
	float lerpDuration = 3;
	float patrolZone = 3;
	Vector2 leftCoordinates;
	Vector2 rightCoordinates;
	// Start is called before the first frame update
	void Start()
	{
		leftCoordinates = transform.position;
	}

	void Update()
	{
		if (transform.position.x == leftCoordinates.x)
		{
			StartCoroutine(MoveRight());
		}
		else if (transform.position.x == rightCoordinates.x)
		{
			StartCoroutine(MoveLeft());
		}
	}

	IEnumerator MoveRight()
	{
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
		{
			transform.position = new Vector2(Mathf.Lerp(leftCoordinates.x, leftCoordinates.x - patrolZone, timeElapsed / lerpDuration), leftCoordinates.y);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(leftCoordinates.x - patrolZone, leftCoordinates.y);
		rightCoordinates = transform.position;
	}

	IEnumerator MoveLeft()
	{
		timeElapsed = Time.deltaTime;
		while (timeElapsed < lerpDuration)
		{
			transform.position = new Vector2(Mathf.Lerp(rightCoordinates.x, rightCoordinates.x + patrolZone, timeElapsed / lerpDuration), rightCoordinates.y);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
		transform.position = new Vector2(rightCoordinates.x + patrolZone, rightCoordinates.y);
		leftCoordinates = transform.position;
	}
}
