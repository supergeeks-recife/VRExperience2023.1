using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public Button startButton;
    public Image circleProgress;
    public float totalTime = 3;
    private bool gvrStatus;
    private float gvrTimer;

    public UnityEvent gvrClick;

    void Update()
    {
        if(gvrStatus == true)
        {
            gvrTimer += Time.deltaTime;
            circleProgress.fillAmount = gvrTimer / totalTime;

            if(gvrTimer > totalTime)
            {
                gvrClick.Invoke();
            }
        }
        else
        {
            gvrTimer = 0;
            circleProgress.fillAmount = 0;
        }
    }

    public void GvrOnButton()
    {
        gvrStatus = true;
    }

    public void GvrOffButton()
    {
        gvrStatus = false;
    }
}
