using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atv3TouchLocation : MonoBehaviour
{
    public int touchId;
    public GameObject circle;

    public Atv3TouchLocation(int newTouchId, GameObject newCircle)
    {
        touchId = newTouchId;
        circle = newCircle;
    }
}
