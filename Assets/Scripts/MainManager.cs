using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now
    public bool MusicEnabled = true;
    public bool SoundEffectsEnabled = true;
    public Button MusicButton;
    public Button SoundEffectsButton;
    public static MainManager Instance;
    public int PlayerId = 0;
    public AudioSource Audio;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void SelectNewPlayer(int NewPlayerId)
    {
        Instance.PlayerId = NewPlayerId;
    }

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
        if(Instance.MusicEnabled==true)
        {
            Audio.Play();
        }

    }
    
    public void TriggerMusicToggle()
    {
        if(Instance.MusicEnabled== true)
        {
            Instance.Audio.Pause();
            Instance.MusicEnabled = false;
        } 
        else
        {
            Instance.Audio.Play();
            Instance.MusicEnabled = true;
        }
    }

    public void TriggerSoundEffectsToggle()
    {
        if(Instance.SoundEffectsEnabled == true)
        {
            Instance.SoundEffectsEnabled = false;
        } 
        else
        {
            Instance.SoundEffectsEnabled = true;
        }
    }
    
   
}

