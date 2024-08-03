using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character001Controller : MonoBehaviour
{
    // Start is called before the first frame update

        RagdollController RagdolController;
        void Start()
        {
RagdolController = GetComponentInChildren<RagdollController>();
        }
        private void OnCollisionEnter(Collision collision)
        {
       if(collision.gameObject.tag == "EnterRagdol") 
       {
        RagdolController.EnterRagdoll();

        }
        }

}
