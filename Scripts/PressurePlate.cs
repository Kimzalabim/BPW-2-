using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public UnityEvent onActivated;
    [SerializeField] private bool hasPower = false;
    private bool isOpened = false;
    void OnTriggerEnter(Collider other)
    {
        if (!isOpened && hasPower)
        {
            isOpened = true;
            onActivated?.Invoke();
        }

    }

    public void DeactivatePower()
    {
        isOpened = false;
        hasPower = false;
    }
    public void ActivatePower()
    {
        hasPower = true;
    }
}
