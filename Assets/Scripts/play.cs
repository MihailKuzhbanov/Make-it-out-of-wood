using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{

    public int firewood = 5;
    public int cuttedTrees = 0;
    public int firePower = 10;
    public int AxeState = 10;
    public int BeardState = 0;
    public int temperature = 10;
    public int time = 1;
    public int magicTempConst = 100;
    public int magicTimeConst = 10;



        // Start is called before the first frame update
        void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        time++;
        if (time % ((magicTempConst - temperature) * magicTimeConst) == 0)
        {
            time = 1;
            firePower--;
            print("Fire Power: " + firePower);
        }
        else if (firePower < 1)
        {
            print("GameOver");
            
        }
    }
}
