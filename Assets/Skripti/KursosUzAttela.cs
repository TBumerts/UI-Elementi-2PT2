using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursosUzAttela : MonoBehaviour {
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskano;
    public void uzbiditsUzAttela() 
    {
        skanasAvots.PlayOneShot(skanaKoAtskano);
    }
    public void kursorsNost() 
    {
        skanasAvots.Stop();
    }
}
