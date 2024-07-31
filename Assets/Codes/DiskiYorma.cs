using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroything",1f);
    }
private void Destroything()
{
Destroy(gameObject);
}
}
