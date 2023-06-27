using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    public GameObject sky;
    private GameObject newsky;
    public int height;
    // Start is called before the first frame update
    void Start()
    {
        height = 20;
    }
    void Update()
    {
        newsky = Instantiate(sky, new Vector3(transform.position.x, height), transform.rotation);
        height = height + 20;
    }


}
