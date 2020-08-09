using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DisolverDispenser : MonoBehaviour
{
    public UnityEvent onActivated;
    [SerializeField] private bool hasPower = true;
    private bool hasDispensed = false;
    void OnTriggerEnter(Collider other)
    {
        if (!hasDispensed && hasPower)
        {
            hasDispensed = true;
            onActivated?.Invoke();
        }
    }
    public void ActivatePower()
    {
        hasPower = true;
    }
}
