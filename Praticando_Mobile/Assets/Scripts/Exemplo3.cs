using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo3 : MonoBehaviour
{
    public float speed;

    void Start()
    {
        speed = 0.2f;
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            transform.Translate(Input.touches[0].deltaPosition.x * speed, Input.touches[0].deltaPosition.y * speed, 0);
        }
    }
}
