using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : MonoBehaviour
{

    public PlayerScript playerScript;
    public ScoreScript scoreScript;
    public GameController gameController;
    public AudioSource collectAudio;
    public AudioSource gameOverAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collect")
        {
            collectAudio.Play();
            Destroy(other.gameObject);
            scoreScript.addScore(1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            playerScript.enabled = false;
            gameController.GameOver();
            gameOverAudio.Play();
        }
    }
}
