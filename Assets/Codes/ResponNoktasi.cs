using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResponNoktasi : MonoBehaviour
{
 
private void Start()
    {
        DataBase.LoadData();
        if(DataBase.SpawnPosition == Vector3.zero)
        {
            DataBase.SpawnPosition = transform.position;
            Debug.Log("spawn position 0");
        }
        transform.position =DataBase.SpawnPosition;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position =DataBase.SpawnPosition;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            DataBase.SpawnPosition=Vector3.zero;
            DataBase.SaveData();
        }
    }
private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "Restart")
    {
        DataBase.SpawnPosition = other.transform.position;
        DataBase.SaveData();
        Debug.Log("calisti");

    }
}
}
