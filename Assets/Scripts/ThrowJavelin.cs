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
    }

    void Shoot()
    {
        Instantiate(javelinPrefab, throwpoint.position, throwpoint.rotation);
    }
}
