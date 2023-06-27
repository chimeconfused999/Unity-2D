using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightCounterScript : MonoBehaviour
{
    public GameObject character;
    public Text heightDisplay;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        height = character.GetComponent<Transform>().position.y;
        heightDisplay.GetComponent<Text>().text = "Height: " + height;
    }
}
