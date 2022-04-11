using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = true;
    public GameObject ponteiro;
    public int contar = 0;


    // Update is called once per frame
    void Update()
    {
        if (isSpinning == true)
        {
            transform.Rotate(0, 0, genSpeed, Space.World);
            genSpeed -= subSpeed;
        }

        if (genSpeed <= 0)
        {
            genSpeed = 0;
            isSpinning = false;
        }
    }



    public void SpinWheel()
     
    {
        StartCoroutine ("countdown");
        genSpeed = Random.Range(4.000f, 5.000f);
        subSpeed = Random.Range(0.008f, 0.009f);
        isSpinning = true;
    }

    IEnumerator countdown()
    {
        
        while (true)
        {
            contar += 1;
            //var renderComponent = GetComponent<Renderer>();
            //renderComponent.enabled = !renderComponent.enabled;
            yield return new WaitForSeconds(1f);
            if (contar == 8)
            
            {
                contar = 0;
                ponteiro.GetComponent<BoxCollider>().enabled = true;
                //ponteiro.GetComponent<MeshRenderer>().enabled = true;

                break;
            }
        }
    }
}
