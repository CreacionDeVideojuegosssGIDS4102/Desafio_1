using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Nombre: Mario Alberto Rangel Márquez
Descripción: Desafio 1
Fecha: 01/10/2024
*/
public class SpinProp : MonoBehaviour
{
    // Start is called before the first frame update

    private float  propellorSpeed = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward,propellorSpeed * Time.deltaTime);
    }
}
