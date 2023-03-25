using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{

    private int _murs;
    private int _obstacles;
    private int _pointage;

    private int counter = 0;

    private float _tempsNiveauUn = 0.0f;
    private float _tempsNiveauDeux = 0.0f;
    private float _tempsNiveauTrois = 0.0f;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
        if (noScene == 0)
        {
            Debug.Log("**** Les vrais aventures vraies de Simon-Olivier Soucis ****\n" +
                "Le pilote S.O.S. cherche à rentrer au bercail après plusieurs semaines d'aventures!\n" +
                "Ramène-le chez lui en déplaçant son avion jusqu'à l'objectif brillant des trois niveaux du jeu.\n" +
                "Ne t'égare pas dans les nuages et attention aux obstacles!");
            Debug.Log("* Niveau 1: Zone militarisée *");
        }
        else if (noScene == 1)
        {
            Debug.Log("** Niveau 2: Zone de turbulence **");
        }
        else if (noScene == 2)
        {
            Debug.Log("*** Niveau 3: L'oeil de la tempête ***");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MalusMurs()
    {
        _murs++;
    }

    public int GetMurs()
    {
        return _murs;
    }

    public void MalusObs()
    {
        _obstacles++;
    }

    public int GetObs()
    {
        return _obstacles;
    }

    public int CalculPointage()
    {
        return _pointage = (GetMurs() * 2) + GetObs();
    }

    public float GetTempsNivUn()
    {
        return _tempsNiveauUn;
    }

    public float GetTempsNivDeux()
    {
        return _tempsNiveauDeux;
    }

    public float GetTempsNivTrois()
    {
        return _tempsNiveauTrois;
    }

    public float GetTemps()
    {
        return GetTempsNivUn() + GetTempsNivDeux() + GetTempsNivTrois();
    }

    public void SetNiveauUn(float tempsNivUn)
    {
        _tempsNiveauUn = tempsNivUn;
    }

    public void SetNiveauDeux(float tempsNivDeux)
    {
        _tempsNiveauDeux = tempsNivDeux;
    }

    public void SetNiveauTrois(float tempsNivTrois)
    {
        _tempsNiveauTrois = tempsNivTrois;
    }

    public void AugmenterCounter()
    {
        counter++;
    }

    public int GetCounter()
    {
        return counter;
    }

}
