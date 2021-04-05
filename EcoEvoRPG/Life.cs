using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float maxLife = 10;
    public float life;
    // Start is called before the first frame update
    void Start()
    {
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        life -= Time.deltaTime;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
