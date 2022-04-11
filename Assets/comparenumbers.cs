using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comparenumbers : MonoBehaviour
{
    public GameObject wheel;
    public GameObject SendValue;
    public GameObject Pointer;
    public string botaovalor;
    public string textovalor;
    public bool stop;
    //public float stop;
    public void Update()
    
    {
        botaovalor = SendValue.GetComponent<sendvalue>().buttonvalue;
        textovalor = Pointer.GetComponent<Pointer>().scoretext;
        stop = wheel.GetComponent<Spinner>().isSpinning;
       // stop = wheel.GetComponent<Spinner>().genSpeed;
        //if (stop == false)
        
        
        //if (textovalor != botaovalor)
       // {
       //     Debug.Log("PERDEU");
       // }
        
       // if (textovalor == botaovalor)
      //  {
            //Debug.Log("GANHOU");
        
       // }
        
    }
}