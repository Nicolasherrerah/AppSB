using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour

{
    public static AudioClip deathSound, jumpSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        deathSound = Resources.Load<AudioClip>("death");
        jumpSound = Resources.Load<AudioClip>("jump");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "death":
                audioSrc.PlayOneShot(deathSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
        }
    }
}
