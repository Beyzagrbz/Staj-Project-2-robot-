using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject RockParticle;
    [SerializeField] GameObject BloodLake;
    GameObject PlayerObj;
    
    private void Start()
    {
        PlayerObj= GameObject.FindGameObjectWithTag("PlayerAnimation");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag !="Player")
        
        {
            Instantiate(RockParticle,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag=="Player")
        {
            PlayerObj.GetComponent<Animator>().SetBool("IsDead",true);
            Instantiate(BloodLake,collision.contacts[0].point,Quaternion.identity,collision.gameObject.transform);

        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
