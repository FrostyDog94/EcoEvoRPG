using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateFood : MonoBehaviour
{
    public GameObject food;
    public int spawnRate = 20;
    GameObject[] allFood;
    GameObject[] allSproid;
    float ranX;
    float ranY;
    public Text foodPop;
    public Text sproidPop;
    public float spawnTimer = 3;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        allFood = GameObject.FindGameObjectsWithTag("Food");
        allSproid = GameObject.FindGameObjectsWithTag("Sproid");
        ranX = Random.Range(-20.00f, 20.00f);
        ranY = Random.Range(-20.00f, 20.00f);
        timer -= Time.deltaTime;

        if (allFood.Length < spawnRate)
        {
            if (timer <= 0)
            {
                Instantiate(food, new Vector2(ranX, ranY), Quaternion.identity);
                timer = spawnTimer;
            }
        }

        foodPop.text = allFood.Length.ToString();
        sproidPop.text = allSproid.Length.ToString();

    }
}
