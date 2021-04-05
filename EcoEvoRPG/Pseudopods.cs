using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pseudopods : MonoBehaviour
{
 
    DNA dna;

    // Start is called before the first frame update
    void Start()
    {
        dna = GetComponent<DNA>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dna.pseudopods == true)
        {
            dna.speed = 1f;
        } else
        {
            dna.speed = 0.5f;
        }
    }



}
