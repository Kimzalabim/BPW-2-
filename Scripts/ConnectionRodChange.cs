using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ConnectionRodChange : MonoBehaviour
{
    private bool isUsed = false;
    public bool hasPower = false;
    public Color activationColor;
    public Color hasPowerColor;
    public Color hasHalfPowerColor;

    private void Update()
    {
        AlreadyPowered();
    }

    public void Activated()
    {
        //if (!isUsed)
        //{
            GetComponent<MeshRenderer>().material.color = activationColor;
            Debug.Log("ActivatieKleur");
            isUsed = true;
        //}
    }

    public void Powered()
    {
        //if (!hasPower)
        //{
            GetComponent<MeshRenderer>().material.color = hasPowerColor;
            Debug.Log("PoweredKleur");
            hasPower = true;
        //}
    }

    public void HalfPowered()
    {
        {
            GetComponent<MeshRenderer>().material.color = hasHalfPowerColor;
            Debug.Log("Partly Powered");

        }
    }


    public void AlreadyPowered()
    {
        if (hasPower & !isUsed)
        {
            GetComponent<MeshRenderer>().material.color = hasPowerColor;
        }
    }

    public void AlreadyActivated()
    {
        
            GetComponent<MeshRenderer>().material.color = activationColor;
    }

}
