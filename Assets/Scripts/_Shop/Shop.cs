using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public bool IsMenuOpen = false;
    public GameObject ShopMenu;
    public void OpenShop()
    {
        IsMenuOpen = !IsMenuOpen;
        if (IsMenuOpen == true)
        {
            ShopMenu.SetActive(true);
        }
        else
        {
            ShopMenu.SetActive(false);
        }
    }
}
