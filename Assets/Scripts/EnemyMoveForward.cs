using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveForward : MonoBehaviour
{
    public int CurHealth;
    public int Damage;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            CurHealth -= Damage;
        }
        else if (other.gameObject.CompareTag("Missle"))
        {
            CurHealth = 0;
        }

        Death();
    }




    private void Death()
    {
        if (CurHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
