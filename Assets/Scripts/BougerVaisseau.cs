using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BougerVaisseau : MonoBehaviour
{
    private float _valeurX;
    private float _valeurY;
    private Vector2 _mouvementDroiteGauche;

    private Rigidbody _rb;

     // Start is called before the first frame update
    void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

    // Update is called once per frame
    void Update()
        {
            Bouger();
        }

    public void Bouger(){
        Vector2 _direction = new Vector2(_valeurX, 0); // (1,0) c'est la direction dans laquelle on va

        _rb.AddForce(_direction * 50,ForceMode.Force); //Ça va devenir (50,0) (-50,0)

        // new Vector2(_valeurX, 0);
        }

    public void RecevoirInfo(InputAction.CallbackContext context){
        // Debug.Log(context.ReadValue<Vector2>()); // (1,0)  (-1,0)  Les 2 choses qu'on peut recevoir comme information (valeurs reçues d'un vecteur)

        _mouvementDroiteGauche = context.ReadValue<Vector2>();
        _valeurX = _mouvementDroiteGauche.x; // Va chercher la première valeur
        _valeurY = _mouvementDroiteGauche.y; // Va chercher la deuxième valeur
        // _mouvementHorizontal = new Vector2(_valeurX, 0);
    }
}