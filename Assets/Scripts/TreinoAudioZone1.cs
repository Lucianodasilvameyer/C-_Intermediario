using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TreinoAudioZone1 : MonoBehaviour
{
    public AudioMixerSnapshot zoneSnapshot;  //o que se arrasta para essas duas partes para controlar pelo codigo?
    public AudioMixerSnapshot defaultSnapshot;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        zoneSnapshot.TransitionTo(1.5f); //o AudioMixerSnapshot.TransitionTo Executa uma transição interpolada para esse instantâneo durante o intervalo de tempo especificado?
    }
    private void OnTriggerExit(Collider other)
    {
        defaultSnapshot.TransitionTo(1.5f);
    }
}
