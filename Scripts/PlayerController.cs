using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerController : MonoBehaviour
{

    public int tape = 1; 
    public int disolver = 1;
    public float moveSpeed = 3.5f;
    public PatchSpot currentPatchSpot;
    private new Rigidbody rigidbody;
    private Vector3 moveDir;
    public UnityEvent onActivated;
    public UnityEvent onTapeChange;
    public UnityEvent onDisolverChange;
    //public UnityEvent onTapeChange;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
        rigidbody.MovePosition(transform.position + moveDir.normalized * Time.deltaTime * moveSpeed);
        
    }
    private void Update()
    {

        float vert = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        moveDir = vert * transform.forward + hor * transform.right;


        if (Input.GetKeyDown(KeyCode.E))
        {
            PatchingTape();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            RemovingTape();
        }

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    RefillingTape();
        //    RefillingDisolver();
        //}

        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //   Debug.Log("I have"  + tape +  "pieces of tape &" + disolver + "pieces of disolver");
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            onActivated?.Invoke();
            onTapeChange?.Invoke();
            onDisolverChange?.Invoke();

        }

    }
    void OnTriggerEnter(Collider other)
    {
        PatchSpot patchSpot = other.gameObject.GetComponent<PatchSpot>();
        if (patchSpot != null)
        {
            currentPatchSpot = patchSpot;
        }

    }
    void OnTriggerExit(Collider other)
    {
        PatchSpot patchSpot = other.gameObject.GetComponent<PatchSpot>();
        if (patchSpot != null)
        {
            currentPatchSpot = null;
        }

    }
    public void PatchingTape()
    {
        if (tape > 0 && currentPatchSpot != null && !currentPatchSpot.isPatched)
        {
            currentPatchSpot.ActivatePower();
            tape -= 1;
            Debug.Log("Patching!");
            onTapeChange?.Invoke();

        }
    }
    public void RemovingTape() //(usingdisolver)
    {
        if (disolver > 0 && currentPatchSpot != null && currentPatchSpot.isPatched)
        {
            currentPatchSpot.DeactivatePower();
            disolver -= 1;
            Debug.Log("Unpatching!");
            onDisolverChange?.Invoke();

        }
    }

    public void RefillingTape()
    {
        tape += 2;
       
        Debug.Log(tape);
        onTapeChange?.Invoke();

    }

    public void RefillingDisolver()
    {
        disolver += 1;

        Debug.Log(disolver);
        onDisolverChange?.Invoke();

    }

    public void TapeReset()
    {
        tape = 1;
        Debug.Log("New Level/Reset");
    }
}