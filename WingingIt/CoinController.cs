using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public float coins;
    public GameObject coinDisplay;
    public GameObject character;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = Mathf.Round(camera.GetComponent<HeightCounterScript>().height);
        coinDisplay.GetComponent<Text>().text = coins.ToString();
    }
}
