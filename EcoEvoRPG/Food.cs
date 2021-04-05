using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour
{
    public float life = 0.5f;
    public float energy = 1;
    public float storedEnergy;
    public Transform foodSprite;
    float spriteScale;
    private void Start()
    {
        storedEnergy = 5;
        spriteScale = 1;
        
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        
        
        if (collision.transform.tag == "Sproid")
        { if (collision.GetComponent<DNA>().carnivore == false)
            { if (storedEnergy > 0)
                {
                    spriteScale -= 0.1f * Time.deltaTime;
                    storedEnergy -= energy * Time.deltaTime;
                    collision.GetComponent<Energy>().energy += energy * Time.deltaTime;
                    collision.GetComponent<Life>().life += life * Time.deltaTime;
                    foodSprite.transform.localScale = new Vector3(spriteScale, spriteScale, 0);
                   // collision.GetComponent<Life>().life += life;
                    
                }
            }
        }
        if (storedEnergy <= 0)
        {
            Destroy(gameObject);
        }


    }
}
