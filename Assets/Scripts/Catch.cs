using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    Counter contadorDePorcos;

    void Start()
    {
        contadorDePorcos = FindObjectOfType<Counter>();
    }

    void OnCollisionEnter(Collision objeto)
    {
        if(objeto.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Bateu!");
            contadorDePorcos.Increment();
        }
    }
}
