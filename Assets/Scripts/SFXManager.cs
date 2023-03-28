using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    private void Awake()
    {
        instance = this;  
    }

    public AudioSource gemSound, exploadeSound, stoneSound, roundOverSound;

    public void PlayGemBreak()
    {
        gemSound.Stop();

        gemSound.pitch = Random.Range(.8f, 1.2f);

        gemSound.Play();
    }

    public void PlayExplode()
    {
        exploadeSound.Stop();

        exploadeSound.pitch = Random.Range(.8f, 1.2f);

        exploadeSound.Play();
    }

    public void PlayStoneBreak()
    {
        stoneSound.Stop();

        stoneSound.pitch = Random.Range(.8f, 1.2f);

        stoneSound.Play();
    }

    public void PlayRaounOver()
    {
        roundOverSound.Play();
    }






}
