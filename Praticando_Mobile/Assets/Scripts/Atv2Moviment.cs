using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atv2Moviment : MonoBehaviour
{
    float dirX;
    float moveSpeed;

    void Start()
    {
        dirX = -1f;
        moveSpeed = 5f;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + dirX * moveSpeed * Time.deltaTime, transform.position.y);

        if (transform.position.x < -8)
            dirX = 1f;
        if (transform.position.x > 8)
            dirX = -1f;
    }
}
