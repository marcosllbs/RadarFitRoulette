using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle : MonoBehaviour
{
    public string scoretext;
    private void OnTriggerStay(Collider other)

    {
        //Debug.Log(scoretext);
        scoretext = other.gameObject.name;

    }
}
