using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoints : MonoBehaviour
{
    public GameManager juiz;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bola")
        {
            juiz.AddPoints(1);
        }
    }
}