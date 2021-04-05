using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSproid : MonoBehaviour
{

    DNA dna;
    DNAGUI dnagui;
    List<string> traits;
    string traitList;
    Life combat;

    // Start is called before the first frame update
    void Start()
    {
        dna = GetComponent<DNA>();
        dnagui = GameObject.Find("GUI Manager").GetComponent<DNAGUI>();
        traits = new List<string>();
        combat = GetComponent<Life>();


        if (dna.scale <= 1)
        {
            traits.Add("Tiny");
        }
        if (dna.scale == 2)
        {
            traits.Add("Small");
        }
        if (dna.scale == 3)
        {
            traits.Add("Medium");
        }
        if (dna.scale == 4)
        {
            traits.Add("Large");
        }
        if (dna.scale >= 5)
        {
            traits.Add("Huge");
        }
        if (dna.carnivore == true)
        {
            traits.Add("Carnivore");
        }
        else
        {
            traits.Add("Herbivore");
        }
        if (dna.pseudopods == true)
        {

            traits.Add("Fins");
        }


        if (dna.compoundEyes == true)
        {
            traits.Add("Compound Eyes");
        }

        if (dna.carapace == true)
        {
            traits.Add("Kitin Carapace");
        }


        foreach (var listMember in traits)
        {
            traitList += listMember.ToString() + "\n";
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        dnagui.diet.text = traitList;
        dnagui.energy.text = dna.energyToReproduce.ToString();
        dnagui.atk.text = dna.attack.ToString();
        dnagui.def.text = dna.defense.ToString();
        dnagui.health.text = combat.life.ToString(); 
    }
}
