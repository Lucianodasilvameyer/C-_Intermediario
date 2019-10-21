using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioZone : MonoBehaviour
{
    public AudioMixerSnapshot zoneSnapshot;
    public AudioMixerSnapshot defaultSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        //Trocar para o snapshot "enter"
        zoneSnapshot.TransitionTo(1.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        defaultSnapshot.TransitionTo(1.5f);
    }
}
