using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompoundEyes : MonoBehaviour
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
        if (dna.compoundEyes == true)
        {
            dna.senseRadius = 1f;
        } else
        {
            dna.senseRadius = 0.5f;
        }
    }
}
