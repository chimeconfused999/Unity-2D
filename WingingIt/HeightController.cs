using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HeightController : MonoBehaviour
{

    private int input;
    public GameObject character;
    public GameObject inputField;
    public Type input_type;

    public void GetInput()
    {
        input_type = input.GetType();
        Debug.Log(input_type);
        if (input_type == typeof(char))
        {
            Debug.Log("Please enter something valid!");
        }
        input = int.Parse(inputField.GetComponent<Text>().text);
        Debug.Log(input);
        character.GetComponent<StickmanScript>().jump = input;
        character.GetComponent<StickmanScript>().isjumping = false;

    }
}
