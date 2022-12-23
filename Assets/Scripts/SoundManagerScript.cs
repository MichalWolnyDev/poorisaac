using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerDeathSound, playerAttack, gateSound, zombieDeath, winner; 
    static AudioSource audioSrc;
    

    void Start()
    {
        playerDeathSound = Resources.Load<AudioClip> ("death1"); // przypisanie do zmiennej konkretnego pliku dŸwiêkowego
        playerAttack = Resources.Load<AudioClip> ("attack1");
        gateSound = Resources.Load<AudioClip>("gate");
        zombieDeath = Resources.Load<AudioClip>("zombiedeath");
        winner = Resources.Load<AudioClip>("winner");
        audioSrc = GetComponent<AudioSource> ();
    }

   void Update()
    {

    }


    public static void PlaySound (string clip) // funkcja odpowiadaj¹ca za odtwarzanie dŸwiêku
    {
        switch (clip) {
            case "playerDeath":
                audioSrc.PlayOneShot (playerDeathSound); 
                break;
            case "playerAttack":
                audioSrc.PlayOneShot(playerAttack);
                break;
            case "gateSound":
                audioSrc.PlayOneShot(gateSound);
                break;
            case "zombieDeath":
                audioSrc.PlayOneShot(zombieDeath);
                break;
            case "winner":
                audioSrc.PlayOneShot(winner);
                break;
        }
    }
}
