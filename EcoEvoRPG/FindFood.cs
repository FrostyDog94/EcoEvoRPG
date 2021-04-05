using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFood : MonoBehaviour
{
    public Transform body;
    DNA dna;
    CircleCollider2D col;
    Movement movement;
    public bool searching;
    GameObject target;
    public List<GameObject> spLoc;
    
    // Start is called before the first frame update
    void Start()
    {
        dna = body.GetComponent<DNA>();
        col = GetComponent<CircleCollider2D>();
        movement = GetComponentInParent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        col.radius = dna.senseRadius;
        foreach (GameObject sproid in GameObject.FindGameObjectsWithTag("Sproid"))
        {
            spLoc.Add(sproid);
        }
        
    }

   /* void OnTriggerStay2D(Collider2D collision)
    {
        target = collision.gameObject;

        if (collision.tag == "Food" && dna.carnivore == false)
        {
            movement.Approach(target);
            
        }
        if (collision.tag == "Sproid" && dna.carnivore == true && collision.GetComponent<DNA>().carnivore == false)
        {
            movement.Approach(target);
            movement.speed += 0.1f;
            
        }
        if (collision.tag == "Sproid" && dna.carnivore == false && collision.GetComponent<DNA>().carnivore == true)
        {
            movement.Avoid(target);

        }
    }
    */

    
}
