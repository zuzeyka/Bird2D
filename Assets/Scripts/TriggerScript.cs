using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "FinalSquare")
        {
            m_AudioSource.Play();
            GameObject.Find("WIN").GetComponent<TMP_Text>().text = "TADAAAAAAAAA";
        }
    }
}
