using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    public int enemyCount;

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F))
         {
             door.OpenDoor();
         } 
        if (Input.GetKeyDown(KeyCode.G))
        {
            door.CloseDoor();
        } */


        if (GameOverUI.score==enemyCount) // tutaj podajemy ilo�� mob�w kt�ra wyskoczy ze spawnera, do ka�dej kolejnej bramy dodajemy ilo�� mob�w z poprzedich spawner�w
        {
            door.OpenDoor();
        }
        

       
    }
}
