using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BullerController : MonoBehaviour
{
    public Transform player; 

    private void OnCollisionEnter(Collision other)
    {
       
        Destroy(other.gameObject);

        
        float randomX = UnityEngine.Random.Range(-15, 15);
        float randomZ = UnityEngine.Random.Range(-15, 15);

       
        GameObject zombie = Instantiate(Resources.Load("Georgi", typeof(GameObject))) as GameObject;
        zombie.transform.position = new Vector3(randomX, 1, randomZ);
        zombie.transform.rotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);

       
        Destroy(gameObject);

       
        ScoreScript.scoreCount += 1;

        
        if (ScoreScript.scoreCount >= 5)
        {
            SceneManager.LoadScene(3); 
        }
    }
}
