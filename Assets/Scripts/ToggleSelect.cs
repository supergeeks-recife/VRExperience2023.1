using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSelect : MonoBehaviour
{
    public GameObject predio;

    void Start()
    {
        if(PlayerPrefs.GetInt("predio") == 1)
        {
            predio.SetActive(true);
        }
        else
        {
            predio.SetActive(false);
        }
    }

}
