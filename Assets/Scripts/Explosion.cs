using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    SphereCollider explosionCollider;
    public float explosionSize = 45;
    private float explosionRate = 8;
    private float radiusRate;
    // Start is called before the first frame update
    void Start()
    {
        explosionCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Exploading();
        
    }


    void Exploading()
    {

        if (explosionCollider.radius >= explosionSize)
        {
            radiusRate = explosionRate * Time.deltaTime; // to stop the radius from get stupidly huge at high frame rates.

            explosionCollider.radius += radiusRate;
        }

        
    }



    
}
