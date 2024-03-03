using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    float speed = 3f;

    void Update()
    {
        transform.Translate(new Vector2(-1, 0)*speed*Time.deltaTime);
        Destroy(gameObject, 3);
    }
}
