using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource music;
    public static AudioManager Instance { get; private set; }
    private AudioSource audioSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        } else
        {
            Debug.Log("Cuidado! Más de un AudioManager en escena.");
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    public void ReproducirSonido(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }

}