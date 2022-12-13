using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    public int enemyCount;

    private GameObject spawner;
    private GameObject spawner2;
    private GameObject spawner3;
    private GameObject spawner4;
    private GameObject spawner5;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemySpawner");
        spawner2 = GameObject.FindGameObjectWithTag("EnemySpawner2");
        spawner3 = GameObject.FindGameObjectWithTag("EnemySpawner3");
        spawner4 = GameObject.FindGameObjectWithTag("EnemySpawner4");
        spawner5 = GameObject.FindGameObjectWithTag("EnemySpawner5");
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Q))
        //  {
        //     //  door.OpenDoor();
        //     // gameObject.Find("EnemySpawner").SetActive(true);
            
        //     spawner.GetComponent<EnemySpawner>().spawning = true;
        //  } 
        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     // gameObject.Find("EnemySpawner").SetActive(false);
        //     spawner.GetComponent<EnemySpawner>().spawning = false;
        // } 


        // if(spawner.GetComponent<EnemySpawner>().defeated){
        //     door.OpenDoor();
        // }


        if(ScoreManager.instance.score >= 3){
            spawner2.GetComponent<EnemySpawner>().spawning = true;
            spawner3.GetComponent<EnemySpawner>().spawning = true;
        }
        if(ScoreManager.instance.score >= 13){
            spawner4.GetComponent<EnemySpawner>().spawning = true;
        }
        if(ScoreManager.instance.score >= 23){
            spawner5.GetComponent<EnemySpawner>().spawning = true;
        }

        if (ScoreManager.instance.score==enemyCount) // tutaj podajemy ilo�� mob�w kt�ra wyskoczy ze spawnera, do ka�dej kolejnej bramy dodajemy ilo�� mob�w z poprzedich spawner�w
        {
            door.OpenDoor();
        }
        

       
    }
}
