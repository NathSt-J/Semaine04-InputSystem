using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemple2 : MonoBehaviour
{

    [SerializeField] private GameObject _leSol;
    // Start is called before the first frame update
    void Start()
    {
        ActiverSol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiverSol(){

        _leSol.SetActive(true);
    }
}
