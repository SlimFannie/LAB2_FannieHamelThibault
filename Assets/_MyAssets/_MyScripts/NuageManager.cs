using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuageManager : MonoBehaviour
{
    public float delta = .5f; 
    public float speed = 0.7f;
    private Vector3 startPos;

    private float nuageRate = 2.3f;
    private float nextNuage = 0.0f;
    private bool pause = false;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Hover();
        if (Time.time > nextNuage)
        {
            if (pause == false)
            {
                nextNuage = Time.time + nuageRate;
                foreach (Renderer renderer in gameObject.GetComponentsInChildren(typeof(Renderer)))
                {
                    foreach (Collider collider in gameObject.GetComponentsInChildren(typeof(Collider)))
                    {
                        renderer.enabled = true;
                        collider.enabled = true;
                    }    
                }
                pause = true;
            }
            else
            {
                nextNuage = Time.time + nuageRate;
                foreach (Renderer renderer in gameObject.GetComponentsInChildren(typeof(Renderer)))
                {
                    foreach (Collider collider in gameObject.GetComponentsInChildren(typeof(Collider)))
                    {
                        renderer.enabled = false;
                        collider.enabled = false;
                    }
                }
                pause = false;
            }
            
        }
    }

    internal void Hover()
    {
        Vector3 v = startPos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
    
}
