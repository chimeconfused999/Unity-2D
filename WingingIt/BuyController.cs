using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyController : MonoBehaviour
{
    public GameObject buyPanel;
    public GameObject jetpack;
    public GameObject character;
    private GameObject jetpackclone;

    public bool hasJetpack;
    public float jetpackcost;
    private float charposx;
    private float charposy;
    private float clonex;

    public void ActivatePanel()
    {
        if (buyPanel != null)
        {
            buyPanel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (buyPanel != null)
        {
            buyPanel.SetActive(false);
        }
    }

    public void BuyJetpack()
    {
        if (gameObject.GetComponentInParent<CoinController>().coins > jetpackcost)
        {
            Debug.Log("You Bought the jetpack!");
            charposx = character.GetComponent<Transform>().position.x;
            charposx = (float)(charposx - 1.2);
            charposy = character.GetComponent<Transform>().position.y;
            jetpackclone = Instantiate(jetpack, new Vector3(charposx , charposy), transform.rotation);
            jetpackclone.transform.parent = character.transform;
            hasJetpack = true;
            character.GetComponent<StickmanScript>().jump = character.GetComponent<StickmanScript>().jump + 100;
        
        }
        else
        {
            Debug.Log("You can't buy the jetpack yet!");
            hasJetpack = false;
        }
    }
}
