using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PatchSpot : MonoBehaviour
{
    public UnityEvent onActivated;
    public UnityEvent onDeactivated;

    public bool isPatched = false;
    public void ActivatePower()
    {
        isPatched = true;
        onActivated?.Invoke();
    }
    public void DeactivatePower()
    {
        isPatched = false;
        onDeactivated?.Invoke();
    }

}
