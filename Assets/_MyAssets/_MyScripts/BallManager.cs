using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    private GestionJeu _gestionJeu;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward, ForceMode.Impulse);
        Destroy(gameObject, 2.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Vous avez été touché, S.O.S.!");
            Debug.Log("-1 points.");
            _gestionJeu.MalusObs();
        }
    }

}
