using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number8 : MonoBehaviour
{
    public GameObject botao1;
    public GameObject botao2;
    public GameObject botao3;
    public GameObject botao4;
    public GameObject botao5;
    public GameObject botao6;
    public GameObject botao7;
    public GameObject botao8;
    public GameObject Canvas;

    public void exec8() 
    {
     botao1.SetActive(false);
     botao2.SetActive(false);
     botao3.SetActive(false);
     botao4.SetActive(false);
     botao5.SetActive(false);
     botao6.SetActive(false);
     botao7.SetActive(false);
     botao8.SetActive(true);   
     Canvas.GetComponent<Canvas>().enabled=false;

        
    }

}