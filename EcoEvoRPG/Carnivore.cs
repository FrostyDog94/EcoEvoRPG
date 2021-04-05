using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carnivore : MonoBehaviour
{
    DNA dna;
    bool carnivore;
    public SpriteRenderer carnMouth;
    Combat combat;
    // Start is called before the first frame update
    void Start()
    {
        dna = gameObject.GetComponent<DNA>();
        combat = GetComponent<Combat>();
    }

    // Update is called once per frame
    void Update()
    {
        carnivore = dna.carnivore;
        if (carnivore == true)
        {
            carnMouth.enabled = true;
        } else
        {
            carnMouth.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (carnivore == true)
        {
            if (collision.gameObject.tag == "Sproid")
            {
                if (collision.gameObject.GetComponent<DNA>().carnivore == false)
                {
                    //Destroy(collision.gameObject);
                    //GetComponent<Energy>().energy += 1;
                    combat.Fight(collision);

                }
            }
        }
    }


}
