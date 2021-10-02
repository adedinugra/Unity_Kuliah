using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBEventHandler : MonoBehaviour
{
    public GameObject whale;
    public AudioClip musik;
    GameObject paus;

    void Start()
    {
        whale = GameObject.Find("VirtualButton");
        whale.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        whale.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        paus = GameObject.FindWithTag("paus");
    }

    //button di tekan
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        paus.GetComponent<Animation>().Play();// jika button di tekan maka animasi paus dijalankan
        GetComponent<AudioSource>().Play();
        Debug.Log("Button pressed");
    }

    //button di lepas
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        paus.GetComponent<Animation>().Stop(); //jika button di lepas maka animasi paus akan berhenti
        GetComponent<AudioSource>().Pause();
        Debug.Log("Button released");
    }
}
