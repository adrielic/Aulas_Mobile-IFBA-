using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.ReorderableList;

public class Exercicio7 : MonoBehaviour
{
    public Vector2 startPos, direction;
    public TMP_Text m_Text;
    string message;

    void Update()
    {
        m_Text.text = "Touch: " + message + " in direction " + direction;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                startPos = touch.position;
                message = "Began";
                break;
                case TouchPhase.Moved:
                direction = touch.position - startPos;
                message = "Moving";
                break;
                case TouchPhase.Ended:
                message = "Ended";
                break;
            }
        }
    }
}
