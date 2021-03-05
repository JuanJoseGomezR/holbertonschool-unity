using System.Dynamic;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    Animator anim;
    int flagFalling = 0;
    public Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
        }
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (playerPos.position.y < -10.0f)
        {
            Debug.Log("checked");
            anim.SetTrigger("isFalling");
            flagFalling = 1;
        }

        if (flagFalling == 1 && (int)playerPos.position.y == 1)
        {
            Debug.Log("impacted");
            anim.SetTrigger("Impact");
            anim.ResetTrigger("isFalling");
            flagFalling = 0;
        }
    }
}
