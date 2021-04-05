using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public float turnRate;
    float turn;
    DNA dna;
    public FindFood findFood;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        turn = turnRate;
        transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
        dna = GetComponent<DNA>();
        
    }
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (findFood.searching == false)
        {
            Wander();
        }
    }

   public void Wander()
    {
        speed = dna.speed;
        turnRate = -3.2f * speed + 11.6f;
        transform.Translate(0, speed * Time.deltaTime, 0);
        // rb.velocity = new Vector2(speed, 0);
        turn -= Time.deltaTime;

        if (turn <= 0)
        {
            turn = turnRate;
            transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));

        }
    }

   public void Approach(GameObject target)
    {
        speed = dna.speed;
        transform.Translate(0, speed * Time.deltaTime * 0.4f, 0);

        transform.up = target.transform.position - transform.position;
        
    }

    public void Avoid(GameObject target)
    {
        speed = dna.speed;
        transform.Translate(0, speed * Time.deltaTime * 0.4f, 0);

        transform.up = target.transform.position + transform.position;
    }
}
