using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    public Image circleProgress;
    public float totalTime = 3;
    private bool gvrStatus;
    private float gvrTimer;

    public UnityEvent gvrClick;

    void Start()
    {
        
    }

    void Update()
    {
        if (gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;

            if (gvrTimer > totalTime)
            {
                gvrClick.Invoke();
                gvrTimer = 0;
            }
        }
        else
        {
            gvrTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }

    public void GvrOnObject()
    {
        gvrStatus = true;
    }

    public void GvrOffObject()
    {
        gvrStatus = false;
    }
}