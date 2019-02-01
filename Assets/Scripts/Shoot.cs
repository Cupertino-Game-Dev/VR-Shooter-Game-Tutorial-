using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject projectile;
    private float time;

    // Use this for initialization
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetMouseButton(0) && time >= .5f)
        {
            time = 0;
            ShootProjectile();
        }
    }

    public void ShootProjectile()
    {
        //if game has already started, then run this block of code
        if (GameManager.startGame)
        {

        }
    }
}
