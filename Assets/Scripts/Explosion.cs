using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    SphereCollider explosionCollider;
    private float explosionRate = 1;
    private float radiusRate;
    private float startDelay = 0.1f;
    private float radiusInterval = 0.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        explosionCollider = GetComponent<SphereCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {

        InvokeRepeating("Exploading", startDelay, radiusInterval);
        StartCoroutine(ExplosionTimer());
        
    }


    void Exploading()
    {

        radiusRate = explosionRate * Time.deltaTime; // to stop the radius from get stupidly huge at high frame rates.

        explosionCollider.radius += radiusRate;
      
    }

    IEnumerator ExplosionTimer()
    {
        yield return new WaitForSeconds(4);
        CancelInvoke("Exploding");
        Destroy(gameObject);
    }

    
}
