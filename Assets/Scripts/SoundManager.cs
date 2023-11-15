using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    

    [SerializeField] private AudioClip soundEffect;
    [SerializeField] private float soundEffectVolume = 1.0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        CharacterAnimationController.OnMousePress += CharacterAnimationController_OnMousePress;
    }

    private void CharacterAnimationController_OnMousePress(object sender, EventArgs e)
    {
        PlaySound(soundEffect, transform.position, soundEffectVolume);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float soundEffectVolume)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, soundEffectVolume);
    }
}