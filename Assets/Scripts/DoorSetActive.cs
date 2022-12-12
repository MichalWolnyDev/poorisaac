using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    public void OpenDoor()
    {
        gameObject.SetActive(false);
        SoundManagerScript.PlaySound("gateSound");
    }

    public void CloseDoor()
    {
        gameObject.SetActive(true);
        SoundManagerScript.PlaySound("gateSound");
    }
}
