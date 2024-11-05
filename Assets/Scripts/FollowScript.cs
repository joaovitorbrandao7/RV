using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importa o namespace para gerenciamento de cenas

public class FollowScript : MonoBehaviour
{
    public Transform targetObj;
    public float speed = 10f; // Variável para ajustar a velocidade do inimigo

    void Update()
    {
        // Move o inimigo em direção ao player com a velocidade ajustável
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, speed * Time.deltaTime);

        // Verifica a distância entre o inimigo e o player
        if (Vector3.Distance(transform.position, targetObj.position) < 0.5f) // Distância de colisão (ajuste conforme necessário)
        {
            Destroy(targetObj.gameObject); // Destrói o player
            SceneManager.LoadScene(2); // Carrega a cena 2
        }
    }
}
