using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carapace : MonoBehaviour
{
    DNA dna;
    // Start is called before the first frame update
    void Start()
    {
        dna = GetComponent<DNA>();
        if (dna.carapace == true)
        {
            dna.defense += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
