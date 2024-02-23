using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // NÉCESSAIRE POUR FAIRE FONCTIONNER LA PATENTE!!!!

public class PlayerS5 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float _vitesse = 2;

    private float _valeurX;
    private float _valeurY;
    private float _valeurZ;

    private Vector3 _valeurRecue;

    private Rigidbody _rb;

    private int _points;

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

        Vector3 _valeurRecue = value.Get<Vector3>();
        _valeurX = _valeurRecue.x;
        _valeurY = _valeurRecue.y;
        _valeurZ = _valeurRecue.z;

    }

    //----------------------------------------------------------------

    public void Bouger(){
        _rb.velocity = new Vector3(_valeurX*_vitesse, _valeurY*_vitesse, _valeurZ*_vitesse);
    }

    //----------------------------------------------------------------

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("CubePoints")){
            Destroy(other.gameObject);
            _points++;

            Debug.Log("J'ai: " + _points + " points! Wow! C'est incroyable les cubes!");
        }

        if(other.gameObject.CompareTag("Kaboom")){
            Destroy(gameObject); //Pas besoin de 'this' quand on veut détruire l'objet lui-même
        }
    }

    //----------------------------------------------------------------
}
