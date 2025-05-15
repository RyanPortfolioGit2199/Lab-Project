using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //public GameObject Explosion;
    // Start is called before the first frame update
    public GameObject Explosion;
    
    
    public float speed;
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other) /// When colliding with an asteroid spawn the asteroid in the missile place then destroy the missile.
    {
        Debug.Log("EXPLOSION!!!!!!!");
        Instantiate(Explosion, transform.position, Explosion.transform.rotation);
        Destroy(gameObject);
            
        
        
    }

    


    


}
