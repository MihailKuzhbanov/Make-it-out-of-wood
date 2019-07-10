using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        try {
            GameObject.Find("mainUI").GetComponentInChildren<mainUI>().WoodCoin++;
        }
        catch {
            print("huiny");
        };

        Destroy(gameObject);
        //add coins
    }
}
