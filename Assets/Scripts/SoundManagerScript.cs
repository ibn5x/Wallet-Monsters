using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerJumpSound, coinCollectSound, playerAttackSound, 
    playerImpactSound, playerVaporizedSound, playerLandingSound, npcImpactSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerJumpSound = Resources.Load<AudioClip>("playerJump");
        coinCollectSound = Resources.Load<AudioClip>("coinCollect");
        playerAttackSound = Resources.Load<AudioClip>("playerAttack");
        playerImpactSound = Resources.Load<AudioClip>("playerImpact");
        playerVaporizedSound = Resources.Load<AudioClip>("playerVaporized");
        playerLandingSound = Resources.Load<AudioClip>("playerLands");
        npcImpactSound = Resources.Load<AudioClip>("npcImpact");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
            case "playerJump":
            audioSrc.PlayOneShot (playerJumpSound);
            break;

            case "coinCollect":
            audioSrc.PlayOneShot (coinCollectSound);
            break;

            case "playerAttack":
            audioSrc.PlayOneShot (playerAttackSound);
            break;

            case "playerImpact":
            audioSrc.PlayOneShot (playerImpactSound);
            break;

            case "playerVaporized":
            audioSrc.PlayOneShot (playerVaporizedSound);
            break;

            case "playerLands":
            audioSrc.PlayOneShot (playerLandingSound);
            break;

            case "npcImpact":
            audioSrc.PlayOneShot (npcImpactSound);
            break;
        }
    }
}
