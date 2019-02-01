using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject cube;
    private float time;

    // Use this for initialization
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //only add time if the game has already started
        if (GameManager.startGame)
        {
            time += Time.deltaTime;
        }

        //spawn a cube every 0.6 seconds
        if (time >= 0.75f)
        {
            time = 0;
            SpawnCube();
        }
    }

    public void SpawnCube()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
