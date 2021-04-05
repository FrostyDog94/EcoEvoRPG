using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    DNA dna;
    float atkBonus;
    float def;
    float atkRoll;
    float totalAtk;
    public float health;
    float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        dna = GetComponent<DNA>();
        atkBonus = dna.attack;
        def = dna.defense;
        maxHealth = dna.health;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Fight(Collider2D col)
    {
        atkRoll = Random.Range(0, 20);
        totalAtk = atkBonus + atkRoll;
        if (totalAtk > col.transform.GetComponent<DNA>().defense)
        {
            Destroy(col.gameObject);
            GetComponent<Energy>().energy += 2;
            Debug.Log("Attack");
            GetComponent<Movement>().speed -= 0.1f;
            GetComponent<Life>().life += 3;
        }
        else
        {
            GetComponent<Life>().life -= 5;
        }
    }

    public void Damage(float dmg)
    {
        health -= dmg;
    }
}
