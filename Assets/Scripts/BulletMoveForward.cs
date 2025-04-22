using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5.0f;
    private GameObject Player;
    PlayerController playerController;
    private GameObject Enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        playerController = GameObject.FindAnyObjectByType<PlayerController>();
        
        Enemy = GameObject.FindWithTag("Asteroid");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.hasPowerUp == true)
        {
            Debug.Log("Bullets shot will track an enemy with the powerup equipped");
            Vector3 lookDirection = Enemy.transform.position - transform.position;
            transform.Translate((lookDirection).normalized * speed);
        }
        else if(playerController.hasPowerUp == false)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        
    }
}
