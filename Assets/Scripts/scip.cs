using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scip : MonoBehaviour
{
    public float speed = 0.002f;
    int nowRotation=0;
    int limitRotation = 120;
    float startRotation;
    public bool direct = true;

    

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        var rotation = transform.eulerAngles;

        if (direct == true)
        {
            if (nowRotation < limitRotation)
            {
                rotation.y += speed;
                transform.eulerAngles = rotation;
                nowRotation++;
            }
            else direct = false;
        }
        if (direct == false)
        {
            if (nowRotation > 0)
            {
                rotation.y -= speed;
                transform.eulerAngles = rotation;
                nowRotation--;
            }
            else
            {
                direct = true;
                nowRotation = 0;
            }
        }
    }
}
