using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDuJeu : MonoBehaviour
{

    private GestionJeu _gestionJeu;
    private Player _player;
    private int _pointage = 0;
    private bool _touche = false;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && !_touche)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            _gestionJeu.AugmenterCounter();
            _touche = true;
        }

        if (_gestionJeu.GetCounter() == 4)
        {
            _pointage += 30 - _gestionJeu.CalculPointage();
            _gestionJeu.SetNiveauTrois(_gestionJeu.GetTempsNivDeux() + Time.time);
            Debug.Log("*** Fin du niveau 3 ***\n" +
                 "Félicitations S.O.S., vous vous êtes sorti du pétrin!\n" +
                 "Il vous a fallu " + _gestionJeu.GetTempsNivTrois() + " secondes pour terminer le dernier niveau.\n" +
                 "Il vous a fallu " + _gestionJeu.GetTemps() + " secondes pour terminer l'aventure.\n" +
                 "Vous avez tapé dans " + _gestionJeu.GetMurs() + " murs.\n" +
                 "Vous avez tapé dans " + _gestionJeu.GetObs() + " obstacles.\n" +
                 "Votre pointage final est de " + _pointage);
            _player.gameObject.SetActive(false);
        }
    }
}
