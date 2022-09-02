using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowJavelin : MonoBehaviour
{
    public Transform throwpoint;
    public GameObject javelinPrefab;
    public Player player;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
			if (player.hasJavelin == true)
			{
                Shoot();
                player.hasJavelin = false;
            }
        }

        //Vector2 offset = new Vector2(Input.mousePosition.x - throwpoint.position.x, Input.mousePosition.x - throwpoint.position.y);
        //float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void Shoot()
    {
        Vector3 mouse = Input.mousePosition;

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        Instantiate(javelinPrefab, throwpoint.position, throwpoint.rotation);
    }
}
