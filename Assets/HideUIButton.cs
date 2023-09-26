using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelscript : MonoBehaviour
{

    public GameObject Shop;
    public GameObject EnterButton;
    public void hideShop()
    {
        Shop.gameObject.SetActive(false);
        EnterButton.gameObject.SetActive(false);
    }
}