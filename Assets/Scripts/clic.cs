using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clic : MonoBehaviour
{

    public float shakeSpeed = 1f;
    bool alive = true;
    public int health = 5;
    int count = 0;
    public GameObject myPrefab;

    void Shake(float speed)
    {
        var rotation = transform.eulerAngles;
        rotation.x += speed*1000;
        transform.eulerAngles = rotation;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        var rotation = transform.eulerAngles;

        if (alive == false)
        {
            Shake(shakeSpeed);
            count++;
        }
        if (count > 10)
        {
            Destroy(gameObject);
            Instantiate(myPrefab, gameObject.transform.position, Quaternion.identity);
        }
    }

    void OnMouseDown()
    {
        GetComponent<scip>().enabled = false;
        if (health > 0)
        {
            health--;
            Shake(shakeSpeed);
        }
        else alive = false;
    }
}
