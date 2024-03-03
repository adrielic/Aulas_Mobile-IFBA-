using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("tocando");
            }

            if (touch.phase == TouchPhase.Canceled)
            {
                Debug.Log("toque incorreto");
            }

            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("tirou o dedo");
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("moveu o dedo");
                Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                touchPos.z = 0f;
                transform.position = touchPos;
            }

            if (touch.phase == TouchPhase.Stationary)
            {
                Debug.Log("dedo parado");
            }
        }
    }
}
