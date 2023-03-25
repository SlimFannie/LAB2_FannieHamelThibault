using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vitesse = 200.0f;
    [SerializeField] private GameObject _collisionEffect;
    private Rigidbody _rb;

    void Start()
    {
        transform.position = new Vector3(-35f, 0.5f, -35f);
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MouvementJoueur();
    }

    private void MouvementJoueur() {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f,  positionZ);
        direction.Normalize();
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

    internal void ResetJoueur() {
        transform.position = new Vector3(-35f, 0.5f, -35f);
    }

    internal GameObject GetEffect()
    {
        return _collisionEffect;
    }

}
