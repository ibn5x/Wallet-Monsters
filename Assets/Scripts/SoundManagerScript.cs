using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound, coinCollect;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Audio.Load<AudioClip>("Jump");
        coinCollect = Audio.Load<AudioClip>("Collect");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
            case "Jump":
            audioSrc.PlayOneShot(jumpSound);
            break;

            case "Collect":
            audioSrc.PlayOneShot(coinCollect);
            break;
        }
    }
}
