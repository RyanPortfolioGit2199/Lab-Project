using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //public GameObject Explosion;
    // Start is called before the first frame update
    SphereCollider explosionCollider;
    void Start()
    {
        explosionCollider = GameObject.Find("Explosion").GetComponent<SphereCollider>(); // Getting the sphere collidier from the Explosion child Gameobject for the explosion needed.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EXPLOSION!!!!!!!");
        InvokeRepeating("ExplosionRadius", 0.1f, 60);
        
    }

    


    void ExplosionRadius() // A Method to increase the sphere collider radius on the Explosion Gameobject
    {
        explosionCollider.radius *= 10;
    }
}
