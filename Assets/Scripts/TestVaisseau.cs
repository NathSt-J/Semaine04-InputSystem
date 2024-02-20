using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // NÉCESSAIRE POUR FAIRE FONCTIONNER LA PATENTE!!!!

public class TestVaisseau : MonoBehaviour
{
    // Start is called before the first frame update

    private float _valeurX;
    private float _valeurY;

    private Vector2 _mouvementDroiteGauche;

    private Rigidbody _rb;

    //----------------------------------------------------------------

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    //----------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        Bouger();
    }

    //----------------------------------------------------------------

    public void OnMove(InputValue value){
        Vector2 _valeurRecue = value.Get<Vector2>();

        _mouvementDroiteGauche = _valeurRecue;

        _valeurX = _valeurRecue.x;
        _valeurY = _valeurRecue.y;

        Debug.Log(_mouvementDroiteGauche);
    }

    //----------------------------------------------------------------

    void Bouger(){
        _rb.velocity = new Vector3(_valeurX * 5, 0, _valeurY * 5); //Pour la vélocité, on doit savoir dans quelle direction on va
    }

    //----------------------------------------------------------------

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("CubePoints")){
            Destroy(other.gameObject);
        }
    }

    //----------------------------------------------------------------
}
