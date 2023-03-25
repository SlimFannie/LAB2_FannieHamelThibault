using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObs : MonoBehaviour
{

    private Player _player;
    private GestionJeu _gestionJeu;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject collisionEffet = Instantiate(
            _player.GetEffect(),
            _player.transform.position,
            Quaternion.identity);

            Debug.Log("Attention aux obstacles, S.O.S. !");
            Debug.Log("-1 points.");
            _gestionJeu.MalusObs();
        }
    }

}
