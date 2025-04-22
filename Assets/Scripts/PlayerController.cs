using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    public float horizontalInput;
    private float xBound = 22;
    public GameObject projectilePrefab;
    public bool hasPowerUp;
    public GameObject powerupIndicator; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        ControlPlayer();

        RestrictPlayer();
       
    }

    // Controlls the player by arrow keys and let the player shoot by left mouse button
    void ControlPlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    //Restrict the Player movement on the x-axis so they dont fall off the map
    void RestrictPlayer()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            powerupIndicator.gameObject.SetActive(true);
            StartCoroutine(PowerUpCountdown());
        }
    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(10);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
