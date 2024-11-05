using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importa o namespace para gerenciamento de cenas

public class MenuDiedScript : MonoBehaviour
{
    // Método para ser chamado ao clicar no botão de recomeçar
    public void RestartGame()
    {
        SceneManager.LoadScene(1); // Carrega a cena 1
    }

    // Método para ser chamado ao clicar no botão de sair
    public void QuitGame()
    {
        Application.Quit(); // Sai do jogo
        // Este comando funciona apenas após a compilação do jogo
    }
}
