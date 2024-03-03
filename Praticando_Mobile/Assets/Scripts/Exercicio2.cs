using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPos, Color.white);
        }
    }
}
