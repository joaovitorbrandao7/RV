using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importa o namespace para gerenciamento de cenas

public class FollowScript : MonoBehaviour
{
    public Transform targetObj;
    public float speed = 10f; // Vari�vel para ajustar a velocidade do inimigo

    void Update()
    {
        // Move o inimigo em dire��o ao player com a velocidade ajust�vel
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, speed * Time.deltaTime);

        // Verifica a dist�ncia entre o inimigo e o player
        if (Vector3.Distance(transform.position, targetObj.position) < 0.5f) // Dist�ncia de colis�o (ajuste conforme necess�rio)
        {
            Destroy(targetObj.gameObject); // Destr�i o player
            SceneManager.LoadScene(2); // Carrega a cena 2
        }
    }
}
