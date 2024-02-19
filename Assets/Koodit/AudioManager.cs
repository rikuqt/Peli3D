using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource TaustaMusiikki;
    public AudioClip kuolema;
    public AudioClip musiikki;

    private void Start()
    {
        TaustaMusiikki.clip = musiikki;
        SFXSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
