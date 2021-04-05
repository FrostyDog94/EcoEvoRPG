using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutate : MonoBehaviour
{
    public float mutationRate; // Chance in 100 that a gene mutates
    DNA dna;
    float chance;
    MutationRate mutRat;

    // Start is called before the first frame update
    void Start()
    {
        dna = gameObject.GetComponent<DNA>();
        Mutation();
        mutRat = GameObject.Find("Resource Manager").GetComponent<MutationRate>();
    }

    // Update is called once per frame
    void Update()
    {
        mutationRate = mutRat.mutationRate;
    }

    void Mutation()
    {
        //Mutate speed
       /* if (Random.Range(0, 100) <= mutationRate)
        {
            if (Random.Range(0, 100) >= 50)
            {
                dna.speed += (Random.Range(0.1f, 1.0f));
            } else
            {
                dna.speed -= (Random.Range(0.1f, 1.0f));
            }
        }
        */

        //Mutate Size
        if (Random.Range(0, 100) < mutationRate)
        {
            colorChange();
            if (Random.Range(0, 100) >= 50)
            {
                dna.scale += 1;
                dna.energyToReproduce += 1;
            }
            else
            {
                if (dna.scale > 1)
                {
                    dna.scale -= 1;
                    dna.energyToReproduce -= 1;
                }
            }
        }

      /*  //Mutate color
        if (Random.Range(0, 100) <= mutationRate)
        {
            dna.red = Random.Range(0.0f, 1.0f);
        }
        if (Random.Range(0, 100) <= mutationRate)
        {
            dna.green = Random.Range(0.0f, 1.0f);
        }
        if (Random.Range(0, 100) <= mutationRate)
        {
            dna.blue = Random.Range(0.0f, 1.0f);
        }
        */

        //Mutate carnivore
        if (Random.Range(0, 100) < mutationRate)
        {
            colorChange();
            if (dna.carnivore == true)
            {
                dna.carnivore = false;
                dna.energyToReproduce -= 1;
            }
            else if (dna.carnivore == false)
            {
                dna.carnivore = true;
                dna.energyToReproduce += 1;
            }

        }

        //Mutate pseudopods
        if (Random.Range(0, 100) < mutationRate)
        {
            colorChange();
            if (dna.pseudopods == true)
            {
                dna.pseudopods = false;
                dna.energyToReproduce -= 1;
            }
            else if (dna.pseudopods == false)
            {
                dna.pseudopods = true;
                dna.energyToReproduce += 1;

            }

        }

        //Mutate compound eyes
        if (Random.Range(0, 100) < mutationRate)
        {
            colorChange();
            if (dna.compoundEyes == true)
            {
                dna.compoundEyes = false;
                dna.energyToReproduce -= 1;
            }
            else if (dna.compoundEyes == false)
            {
                dna.compoundEyes = true;
                dna.energyToReproduce += 1;

            }

        }

        if (Random.Range(0, 100) < mutationRate)
        {
            colorChange();
            if (dna.carapace == true)
            {
                dna.carapace = false;
                dna.energyToReproduce -= 1;
            }
            else if (dna.carapace == false)
            {
                dna.carapace = true;
                dna.energyToReproduce += 1;
            }

        }
    }

    void colorChange()
    {
        chance = Random.Range(0, 90);
        if (chance <= 30)
        {
            dna.red = Random.Range(0.0f, 1.0f);
        }
        else if (chance > 30 && chance < 60) 
        {
            dna.green = Random.Range(0.0f, 1.0f);
        }
        else if (chance >= 60)
        {
            dna.blue = Random.Range(0.0f, 1.0f);
        }
    }
}
