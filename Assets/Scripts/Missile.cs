using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //public GameObject Explosion;
    // Start is called before the first frame update
    SphereCollider explosionCollider;
    public float explosionSize = 45;
    public bool MaxSize;
    public float speed;
    void Start()
    {
        explosionCollider = GameObject.Find("Explosion").GetComponent<SphereCollider>(); // Getting the sphere collidier from the Explosion child Gameobject for the explosion needed.

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EXPLOSION!!!!!!!");
        speed = 0;
        MaxSize = true;
        ExplosionRadius();
        
    }

    


    void ExplosionRadius() // A Method to increase the sphere collider radius on the Explosion Gameobject
    {

        while (MaxSize)
        {
            explosionCollider.radius += 5 * Time.deltaTime;
        } 
        
    }

    void RadiusCheck()
    {
        if (explosionCollider.radius == explosionSize)
        {
            MaxSize = false;
        }
    }
}
