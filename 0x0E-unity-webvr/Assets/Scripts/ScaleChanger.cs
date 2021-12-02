using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ScaleChanger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public GameObject rend;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Awake()
    {
        scaleChange = new Vector3(1.5f, 1.5f, 1.5f);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "effector")
        {
            rend.transform.localScale = scaleChange;
            source.PlayOneShot(clip);
        }
    }
}
