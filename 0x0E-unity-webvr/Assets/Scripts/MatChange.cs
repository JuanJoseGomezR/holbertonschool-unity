using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MatChange : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public Material[] material;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "effector")
        {
            rend.sharedMaterial = material[1];
            source.PlayOneShot(clip);
        }
    }
}
