using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public static Vector3 SpawnPosition;

public static void SaveData()
     {
        PlayerPrefs.SetFloat("SpawnPositionX", SpawnPosition.x);
        PlayerPrefs.SetFloat("SpawnPositionY", SpawnPosition.y);
        PlayerPrefs.SetFloat("SpawnPositionZ", SpawnPosition.z);
        
        
     }
     public static void LoadData()
     {
        SpawnPosition.x=PlayerPrefs.GetFloat("SpawnPositionX");
        SpawnPosition.y=PlayerPrefs.GetFloat("SpawnPositionY");
        SpawnPosition.z=PlayerPrefs.GetFloat("SpawnPositionZ");
        
     }
}
