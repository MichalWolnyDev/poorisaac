using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerDeathSound, playerAttack;
    static AudioSource audioSrc;
    

    void Start()
    {
        playerDeathSound = Resources.Load<AudioClip> ("death1");
        playerAttack = Resources.Load<AudioClip> ("attack1");

        audioSrc = GetComponent<AudioSource> ();
    }

   void Update()
    {

    }


    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "playerDeath":
                audioSrc.PlayOneShot (playerDeathSound);
                break;
            case "playerAttack":
                audioSrc.PlayOneShot(playerAttack);
                break;
        }
    }
}
