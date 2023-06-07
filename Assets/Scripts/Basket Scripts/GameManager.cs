using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int points;
    public TMP_Text text_points;

    void Start()
    {
        
    }

    void Update()
    {
        text_points.text = "Pontos: " + points.ToString();
    }

    public void AddPoints(int point)
    {
        this.points += point;
    }

    public void RemovePoints(int point)
    {
        this.points -= point;
    }
}