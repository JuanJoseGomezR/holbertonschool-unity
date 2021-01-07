using System.Net.Sockets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private CharacterController character_controller;

    public int health = 5;

    private Vector3 move_Direction;

    private int score = 0;

    public float speed = 5f;
    public float gravity = 20f;

    private float vertical_Velocity;

    void Start() {
        character_controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        MoveThePlayer();
    }

    void MoveThePlayer() {
        move_Direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        character_controller.Move(move_Direction);
    } // move player

    public Image WinLoseBG;

    public Text WinLoseText;

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Pickup")
        {
            score += 1;
        }
        if (other.tag == "Trap")
        {
            health -= 1;
        }
        if (other.tag == "Goal")
        {
            WinLoseText.text = "You Win!";
            WinLoseText.color = Color.black;
            WinLoseBG.color = Color.green;
            WinLoseBG.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));
        }
    }
    IEnumerator LoadScene(float seconds) {
        yield return new WaitForSeconds(3);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    void Update() {
        if ( Input.GetKeyDown(KeyCode.Escape) == true )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (health == 0)
        {
            WinLoseText.text = "Game Over!";
            WinLoseText.color = Color.white;
            WinLoseBG.color = Color.red;
            WinLoseBG.gameObject.SetActive(true);
            StartCoroutine(LoadScene(3));   
        }
        SetScoreText();
        SetHealthText();
    }

    public Text scoreText;

    public Text healthText;

    void SetScoreText() {
        scoreText.text = "Score: " + score.ToString();
    }

    void SetHealthText() {
        healthText.text = "Health " + health.ToString();
    }
}
