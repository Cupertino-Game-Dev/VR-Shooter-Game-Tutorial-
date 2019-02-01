using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject startButton;
    public GameObject scoreText;

    private float startTime;
    public static bool startGame;

    public void Start()
    {
        startGame = false;
    }

    public void StartGame()
    {

        //setting startGame value to true lets the shooter know that it can now shoot 
        startGame = true;

        //set button invisible
        startButton.SetActive(false);
        scoreText.SetActive(false);

        //time starts now
        startTime = Time.time;
    }

    public void OnCollisionEnter(Collision collision)
    {
        //Game Over if cube collides with this object
        if (collision.gameObject.CompareTag("Cube"))
        {
            startGame = false;

            //Destroy all objects tagged with "Cube"
            //In this case, all cubes will be destroyed
            foreach (GameObject c in GameObject.FindGameObjectsWithTag("Cube"))
            {
                Destroy(c);
            }
            foreach (GameObject p in GameObject.FindGameObjectsWithTag("Projectile"))
            {
                Destroy(p);
            }
            //Set the menu back to active to reset game
            startButton.SetActive(true);
            scoreText.SetActive(true);

            //compare current time with the time when the game started
            //that number is the player's score
            scoreText.GetComponent<Text>().text = "Score: " + (Time.time - startTime);
        }
        else
        {
            //if the collider is a projectile, destroy it
            Destroy(collision.gameObject);
        }

    }
}
