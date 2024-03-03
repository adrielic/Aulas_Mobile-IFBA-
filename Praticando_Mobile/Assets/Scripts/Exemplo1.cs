using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo1 : MonoBehaviour
{
    void OnGUI()
    {
        foreach (Touch touch in Input.touches)
        {
            string text = "";
            text = "Id: " + touch.fingerId + "\n";
            int num = touch.fingerId;
            GUI.Label(new Rect(0 + 130 * num, 0, 120, 100), text);
        }
    }
}
