using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LvlStartPlate : MonoBehaviour
{
    public UnityEvent onActivated;
    private bool isUsed = false;
    void OnTriggerEnter(Collider other)
    {
        if (!isUsed)
        {
            isUsed = true;
            onActivated?.Invoke();
        }
    }
       
}
