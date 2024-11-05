using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILLERCUBE : MonoBehaviour
{
    public float speed = 5f; 
    private Vector3 direction = Vector3.forward; 

    public GameObject player; 

    void Update()
    {
        
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Wall"))
        {
            
            direction = -direction;
        }

       
        if (collision.gameObject == player)
        {
            Destroy(player); 
        }
    }
}
