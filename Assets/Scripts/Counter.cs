using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Counter : MonoBehaviour
{
    public int counter;
    public TMP_Text counter_text;
    void Start()
    {
        counter = 0;
    }

    public void Increment()
    {
        counter += 1;
        counter_text.text = "PIG: " + counter;
        Debug.Log("Counter: " + counter);
    }
}
