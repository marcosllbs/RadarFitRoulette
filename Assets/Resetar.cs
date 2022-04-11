using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetar : MonoBehaviour
{
    public void BotaoRestart() /* Métodos/Funções - É um bloco de código que contém uma série de instruções. 
                                    Um programa faz com que as instruções sejam executadas chamando o método e especificando os argumentos de método necessários*/
    {

        SceneManager.LoadScene("SampleScene"); // Carregar uma cena por seu nome ou índice em Configurações de compilação.
    }
}
