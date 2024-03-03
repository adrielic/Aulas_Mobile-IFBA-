using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisando4 : MonoBehaviour
{
    [SerializeField]
    private GameObject slide, tap;
    private Touch touch;
    private Vector2 beginTouchPosition, endTouchPosition;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    beginTouchPosition = touch.position;
                    break;
                case TouchPhase.Ended:
                    endTouchPosition = touch.position;
                    if (beginTouchPosition == endTouchPosition)
                        Instantiate(tap, transform.position, Quaternion.identity);
                    if (beginTouchPosition != endTouchPosition)
                        Instantiate(slide, transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}
