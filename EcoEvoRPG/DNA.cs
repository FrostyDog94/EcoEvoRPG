using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{

    public float speed;
    public float scale;
    public float red;
    public float blue;
    public float green;
    public bool carnivore;
    public bool pseudopods;
    public float energyToReproduce;
    public float senseRadius;
    public bool compoundEyes;
    public float attack;
    public float defense;
    public bool carapace;
    public float health;
    

    Movement movement;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
       
       spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (energyToReproduce <= 0)
        {
            energyToReproduce = 1;
        }
        spriteRenderer.color = new Color(red, green, blue);
    }
}
