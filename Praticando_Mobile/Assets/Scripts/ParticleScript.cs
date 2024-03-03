using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2);
    }
}
