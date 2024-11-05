using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class KILLERCICLE : MonoBehaviour
{
    public GameObject player;
    public float respawnHeight = 10f;
    public float minX = -10f;
    public float maxX = 10f;
    public float minZ = -10f;
    public float maxZ = 10f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            Respawn();
        }

        if (collision.gameObject == player)
        {
            Destroy(player); 
            SceneManager.LoadScene(2); 
        }
    }

    void Respawn()
    {
       
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

       
        transform.position = new Vector3(randomX, respawnHeight, randomZ);
    }
}
