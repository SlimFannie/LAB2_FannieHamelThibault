using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    [SerializeField] private float _vitesseRotation = 2.0f;  // Établi la vitesse de rotation du gameObject

    void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f); 
    }
}
