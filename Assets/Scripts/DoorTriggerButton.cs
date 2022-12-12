using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    public int iloscmobow;

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


        if (GameOverUI.score==iloscmobow) // tutaj podajemy iloœæ mobów która wyskoczy ze spawnera, do ka¿dej kolejnej bramy dodajemy iloœæ mobów z poprzedich spawnerów
        {
            door.OpenDoor();
        }
        

       
    }
}
