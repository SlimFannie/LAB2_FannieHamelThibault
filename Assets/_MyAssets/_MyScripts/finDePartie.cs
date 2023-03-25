using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finDePartie : MonoBehaviour
{

    private GestionJeu _gestionJeu;
    private Material _material;
    private int noScene;
    private int _pointage = 0;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }

    private void OnTriggerEnter(Collider other)
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; 
        if (noScene == 0)
        {
            _pointage += 10 - _gestionJeu.CalculPointage();
            _gestionJeu.SetNiveauUn(_gestionJeu.GetTempsNivUn() + Time.time);

            Debug.Log("* Fin du niveau 1 *\n" +
                          "Félicitations S.O.S., vous avez franchi la zone militarisée!\n" +
                          "Il vous a fallu " + _gestionJeu.GetTempsNivUn() + " secondes pour le faire.\n" +
                          "Vous avez tapé dans " + _gestionJeu.GetMurs() + " murs jusqu'à maintenant.\n" +
                          "Vous avez tapé dans " + _gestionJeu.GetObs() + " obstacles jusqu'à maintenant.\n" +
                          "Votre pointage actuel est de " + _pointage);
            SceneManager.LoadScene(noScene + 1);
         }
         else if (noScene == 1)
         {
            _pointage = 0;
            _pointage += 20 - _gestionJeu.CalculPointage();
            _gestionJeu.SetNiveauDeux(_gestionJeu.GetTempsNivUn() + Time.time);

            Debug.Log("** Fin du niveau 2 **\n" +
                      "Super S.O.S., vous avez franchi la zone de turbulence!\n" +
                      "Il vous a fallu " + _gestionJeu.GetTempsNivDeux() + " secondes pour le faire.\n" +
                      "Vous avez tapé dans " + _gestionJeu.GetMurs() + " murs jusqu'à maintenant.\n" +
                      "Vous avez tapé dans " + _gestionJeu.GetObs() + " obstacles jusqu'à maintenant.\n" +
                      "Votre pointage actuel est de " + _pointage);
            
            SceneManager.LoadScene(noScene + 1);
        }
    }
}

