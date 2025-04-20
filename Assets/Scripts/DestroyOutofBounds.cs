using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float zBound = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OutofBoundsDestroy();
    }


    void OutofBoundsDestroy()
    {
        if (transform.position.z < -zBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }
    }


}
