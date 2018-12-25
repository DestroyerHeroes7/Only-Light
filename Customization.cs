using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customization : MonoBehaviour {

    public Canvas MainMenu;
    public Canvas CustomizationMenu;


    public void ChangeCustomization()
    {
        MainMenu.gameObject.SetActive(false);
        CustomizationMenu.gameObject.SetActive(true);
    }

    public void BackMainMenu()
    {
        CustomizationMenu.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(true);
    }
}
