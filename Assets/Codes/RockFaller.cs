using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFaller : MonoBehaviour
{
     float SonDusenTasZamani;
     float TetiklenmeZamani;
     [SerializeField] GameObject Rock;
     GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player=GameObject.FindWithTag("Player");
        TetiklenmeZamani=1;
        SonDusenTasZamani=0f;
    }
   

    // Update is called once per frame
    void Update()
    {
        Vector3 RockSpawnPositon;
        if(Time.time>=TetiklenmeZamani+SonDusenTasZamani)
        {
            SonDusenTasZamani=Time.time;
           RockSpawnPositon =Player.transform.position;
           RockSpawnPositon.y += 5f;
           Instantiate(Rock,RockSpawnPositon,Quaternion.identity);
        }
    }
}
