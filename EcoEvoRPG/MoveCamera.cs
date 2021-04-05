using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float speed;
    float tarOrtho;
    // Start is called before the first frame update
    void Start()
    {
        tarOrtho = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            tarOrtho -= scroll * 1;
            tarOrtho = Mathf.Clamp(tarOrtho, 1, 20);
        }

        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, tarOrtho, 2 * Time.deltaTime);
    }
}
