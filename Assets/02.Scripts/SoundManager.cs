using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource get3points;
    public AudioSource get5points;
    public AudioSource minusLife;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound3p()
    {
        get3points.Play();

    }

    public void PlaySound5p()
    {
        get5points.Play();

    }

    public void PlaySoundMinus()
    {
        minusLife.Play();
    }
}
