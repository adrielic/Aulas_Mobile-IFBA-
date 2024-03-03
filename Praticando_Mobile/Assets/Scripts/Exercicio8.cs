using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    public GameObject particle;

    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                if (Physics.Raycast(ray))
                {
                    Instantiate(particle, transform.position, transform.rotation);
                }
            }
        }
    }
}
