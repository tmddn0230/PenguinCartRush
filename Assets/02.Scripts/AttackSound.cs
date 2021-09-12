using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSound : MonoBehaviour
{
    AudioSource attackSound; 


    // Start is called before the first frame update
    void Start()
    {
        attackSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAttackSound()
    {
        attackSound.Play();
    }

}
