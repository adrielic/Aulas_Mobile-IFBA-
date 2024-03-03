using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo4 : MonoBehaviour
{
    private Touch touch;

    void Update()
    {
        if (Input.touchCount > 0) //Correção de erro
        {
            touch = Input.GetTouch(0);
            float x = -7.5f + 16 * touch.position.x / Screen.width;
            float y = -4.5f + 10 * touch.position.y / Screen.height;
            transform.position = new Vector3(x, y, 0);
        }
    }
}
