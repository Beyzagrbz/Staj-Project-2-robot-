using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    AnimatorController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<AnimatorController>();
        FizikState(true);
        ColliderState(false);
        GetComponent<Animator>().enabled =true;
        
    }
    private void FizikState(bool state)
    {
        Rigidbody[] ChildRigidsBodys = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody child in ChildRigidsBodys)
        {
            child.isKinematic = state;
        }
    }
    private void ColliderState(bool state)
    {
        Collider[] ChildColliders = GetComponentsInChildren<Collider>();
        foreach (Collider child in ChildColliders)
        {
            child.enabled = state;
        }
    }
public void EnterRagdoll()
{
    
    GetComponentInParent<CapsuleCollider>().enabled =false;
    GetComponentInParent<Rigidbody>().isKinematic =true;
    controller.Controller.enabled=false;
    GetComponent<Animator>().SetBool("IsDead",true);
   

            GetComponent<Animator>().enabled =false;
            
            FizikState(false);
            ColliderState(true);
            Debug.Log("calisti");
        
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            EnterRagdoll();
        }
        
    }
}
