using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    void OnGUI()
    {
        foreach (Touch touch in Input.touches)
        {
            string text = "";
            text += "Identificação: " + touch.fingerId + "\n";
            text += "Qtd toques: " + touch.tapCount + "\n";
            text += "Fase: " + touch.phase.ToString() + "\n";
            text += "Posição X: " + touch.position.x + "\n";
            text += "Posição Y: " + touch.position.y + "\n";
            int num = touch.fingerId;
            GUI.Label(new Rect(0 + 130 * num, 0, 120, 100), text);
        }
    }
}
