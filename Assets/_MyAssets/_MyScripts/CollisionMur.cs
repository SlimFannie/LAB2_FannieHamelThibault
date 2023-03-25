using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMur : MonoBehaviour
{

    private Player _player;
    private GestionJeu _gestionJeu;

    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject collisionEffet = Instantiate(
            _player.GetEffect(),
            _player.transform.position,
            Quaternion.identity);

            Debug.Log("Attention S.O.S., vous avez la tête dans les nuages!");
            Debug.Log("-2 points.");
            _gestionJeu.MalusMurs();
            _player.ResetJoueur();
        }

    }

}
