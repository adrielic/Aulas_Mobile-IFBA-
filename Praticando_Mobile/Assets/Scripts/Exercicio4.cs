using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    private Vector3 position;
    private float width, height;

    void Awake()
    {
        width = (float)Screen.width / 2f;
        height = (float)Screen.height / 2f;
        position = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(-pos.x, pos.y, 0f);
                transform.position = position;
            }

            if (Input.touchCount == 2)
            {
                touch = Input.GetTouch(1);

                if (touch.phase == TouchPhase.Began)
                {
                    transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);

                }

                if (touch.phase == TouchPhase.Ended)
                {
                    transform.localScale = new Vector3(1f, 1f, 1f);
                }
            }
        }
    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = (int)(Screen.width / 25f);
        GUI.Label(new Rect(20, 20, width, height * 0.25f), "x= " + position.x.ToString("f2") + "\n\ny= " + position.y.ToString("f2"));
    }
}
