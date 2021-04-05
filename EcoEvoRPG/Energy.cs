using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public float energyToReproduce;
    public float energy;
    public Transform birth;
    public GameObject Sproid;
    GameObject spawn;
    DNA dna;
    // Start is called before the first frame update
    void Start()
    {
        energy = 0;
        dna = GetComponent<DNA>();
       
    }

    // Update is called once per frame
    void Update()
    {
        energyToReproduce = dna.energyToReproduce;


        if (energy >= energyToReproduce)
        {
            spawn = Instantiate(Sproid, birth.position, Quaternion.identity);
            //spawn.GetComponent<DNA>().speed = gameObject.GetComponent<DNA>().speed;
            energy = 0;
        }
    }




}
