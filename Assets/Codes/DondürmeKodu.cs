using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DondürmeKodu : MonoBehaviour
{
    [SerializeField] Vector3 donmeYonu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(donmeYonu*Time.deltaTime);
    }
}
