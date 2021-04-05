using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    float scale;
    DNA dna;

    // Start is called before the first frame update
    void Start()
    {
        dna = gameObject.GetComponent<DNA>();
    }

    // Update is called once per frame
    void Update()
    {
        scale = dna.scale;
        transform.localScale = new Vector3(scale, scale, 0);


    }
}
