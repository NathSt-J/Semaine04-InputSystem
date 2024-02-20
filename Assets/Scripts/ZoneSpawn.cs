using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Vector3 _zoneSize;
    int _valeur1;
    int _valeur2;

    //----------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        //CreerCube();

        _valeur1 = Random.Range(1,3);
        _valeur2 = Random.Range(2,4);

        InvokeRepeating("CreerCube",_valeur1,_valeur2); //Première valeur = Temps avant de spawner le premier cube; Deuxième valeur = Temps d'attente entre chaque spawn de cube
    }

    //----------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        
    }

    //----------------------------------------------------------------

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, _zoneSize);

    }

    //----------------------------------------------------------------

    void CreerCube(){
        GameObject _nouveauCube;

        _nouveauCube = Instantiate(_cubePrefab);
        
        float _posAleatoireX = Random.Range(transform.position.x - _zoneSize.x / 2,transform.position.x + _zoneSize.x / 2);
        float _posAleatoireY = Random.Range(transform.position.y - _zoneSize.y / 2,transform.position.y + _zoneSize.y / 2);
        float _posAleatoireZ = Random.Range(transform.position.z - _zoneSize.z / 2,transform.position.z + _zoneSize.z / 2);


        _nouveauCube.transform.position = new Vector3(_posAleatoireX,_posAleatoireY,_posAleatoireZ);
        
        //On met ces valeurs ici pour qu'elles deviennent aléatoire à chaque création de cube
        _valeur1 = Random.Range(1,3);
        _valeur2 = Random.Range(2,4);
    }

    //----------------------------------------------------------------
}
