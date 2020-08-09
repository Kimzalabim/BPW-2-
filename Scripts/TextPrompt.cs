using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPrompt : MonoBehaviour
{
    //public float dezeMesh;
    [SerializeField] private float delay = 0;
    [SerializeField] private float timeVisible = 1;
    public MeshRenderer dezeMesh;


    public void Start()
    {
        MeshDisabler();
    }

    public void MeshEnabler()
    {
        StartCoroutine(MeshVisible(delay, timeVisible));
  
    }
    public void MeshDisabler()
    {
        dezeMesh.enabled = false;

    }

    IEnumerator MeshVisible(float delay, float timeVisible)
    {
        yield return new WaitForSeconds(delay);
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * 1 / timeVisible;
            dezeMesh.enabled = true;
            yield return null;
        }
        MeshDisabler();
     
    }
}
