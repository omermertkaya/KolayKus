using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerHitSound, playerPointSound, playerDieSound, playerWingSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("sfx_hit");
        playerPointSound = Resources.Load<AudioClip>("sfx_point");
        playerDieSound = Resources.Load<AudioClip>("sfx_die");
        playerWingSound = Resources.Load<AudioClip>("sfx_wing");

        audioSrc = GetComponent<AudioSource>();
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "sfx_hit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "sfx_point":
                audioSrc.PlayOneShot(playerPointSound);
                break;
            case "sfx_die":
                audioSrc.PlayOneShot(playerDieSound);
                break;
            case "sfx_wing":
                audioSrc.PlayOneShot(playerWingSound);
                break;
        }
        
    }

}
