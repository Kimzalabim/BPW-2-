using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DoorController : MonoBehaviour
{
    public UnityEvent onActivated;
    public UnityEvent onDeactivated;
    public UnityEvent onLinked;

    public int doorTriggerAmount = 1;
    public int currentDoorTriggerAmount = 0;

    public void DoorCheckMinus()
    {
        currentDoorTriggerAmount -= 1;
        if (currentDoorTriggerAmount <= 0)
        {
            currentDoorTriggerAmount = 0;
        }
        if (currentDoorTriggerAmount <= doorTriggerAmount)
        {
            onDeactivated?.Invoke();
        }
    }
    public void DoorCheck() {
        currentDoorTriggerAmount += 1 ;
        onLinked?.Invoke();

        if (currentDoorTriggerAmount == doorTriggerAmount)
        {
            onActivated?.Invoke();
        }
    }



}
