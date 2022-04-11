using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Pointer : MonoBehaviour

{
    public GameObject canvasbotao1;
    public GameObject canvasbotao2;
    public GameObject canvasbotao3;
    public GameObject canvasbotao4;
    public GameObject canvasbotao5;
    public GameObject canvasbotao6;
    public GameObject canvasbotao7;
    public GameObject canvasbotao8;
    public GameObject botao1;
    public GameObject botao2;
    public GameObject botao3;
    public GameObject botao4;
    public GameObject botao5;
    public GameObject botao6;
    public GameObject botao7;
    public GameObject botao8;
    public string scoretext;

    private void OnTriggerEnter(Collider other)
    
    {
        //Debug.Log(scoretext);
        
        scoretext = other.gameObject.name;
         
         if(botao1 == botao1)
       {
            if (other.tag == "Um")  
        {
            Debug.Log ("Vitoria!!");
         canvasbotao1.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }
         
         if(botao2 == botao2)
        {
            if (other.tag == "Dois")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao2.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }



         
         if(botao3 == botao3)
        {
            if (other.tag == "Tres")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao3.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }

  
         
         if(botao4 == botao4)
        {
            if (other.tag == "Quatro")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao4.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }

          if(botao5 == botao5)
        {
            if (other.tag == "Cinco")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao5.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }
        
    
         
         if(botao6 == botao6)
        {
            if (other.tag == "Seis")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao6.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }

     
         
         if(botao7 == botao7)
        {
            if (other.tag == "Sete")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao7.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }

     
         
         if(botao8 == botao8)
        {
            if (other.tag == "Oito")  
        {
            Debug.Log ("Vitoria!!");
            canvasbotao8.GetComponent<Canvas>().enabled=true;
           
            //Destroy(other.gameObject);
        }
        }
        


    }
    

}
