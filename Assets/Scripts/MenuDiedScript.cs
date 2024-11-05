using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importa o namespace para gerenciamento de cenas

public class MenuDiedScript : MonoBehaviour
{
    // M�todo para ser chamado ao clicar no bot�o de recome�ar
    public void RestartGame()
    {
        SceneManager.LoadScene(1); // Carrega a cena 1
    }

    // M�todo para ser chamado ao clicar no bot�o de sair
    public void QuitGame()
    {
        Application.Quit(); // Sai do jogo
        // Este comando funciona apenas ap�s a compila��o do jogo
    }
}
