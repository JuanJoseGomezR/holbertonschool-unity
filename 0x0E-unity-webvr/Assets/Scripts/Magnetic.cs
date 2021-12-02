using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Magnetic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "sword")
        {
            // creates joint
            FixedJoint joint = gameObject.AddComponent<FixedJoint>(); 
            // sets joint position to point of contact
            joint.anchor = col.contacts[0].point; 
            // conects the joint to the other object
            joint.connectedBody = col.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>(); 
            // Stops objects from continuing to collide and creating more joints
            joint.enableCollision = false; 
            source.PlayOneShot(clip);
        }
    }
}
