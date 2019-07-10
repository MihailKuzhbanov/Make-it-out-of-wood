using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainUI : MonoBehaviour
{
    private int woodCoin = 0;
    public Text WoodCoinText;

    public int WoodCoin { get => woodCoin; set => woodCoin = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WoodCoinText.text = "Wood Coin: " + WoodCoin;
    }
}
