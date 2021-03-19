using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBound : MonoBehaviour
{
    private float minX,maxX,minY,maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0f));
        minX = -bounds.x + 0.3f;
        maxX = bounds.x - 0.3f;
        minY = -bounds.y + 0.4f;
        maxY = bounds.y - 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        if (temp.x < minX)
        {
            temp.x = minX;
        }
        else if (temp.x > maxX)
        {
            temp.x = maxX;
        }
        if (temp.y > maxY)
        {
            temp.y = maxY;
        }
        else if (temp.y < minY)
        {
            temp.y = minY;
        }
        transform.position = temp;
    }
}