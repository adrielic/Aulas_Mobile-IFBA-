using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniTeste : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2 && transform.position.x > -0.75f)
                {
                    transform.position = new Vector2(transform.position.x - 0.75f, transform.position.y);
                }

                if (touch.position.x > Screen.width / 2 && transform.position.x < 0.75f)
                {
                    transform.position = new Vector2(transform.position.x + 0.75f, transform.position.y);
                }
            }
        }
    }
}
