using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlEduhance : MonoBehaviour
{
    public GameObject modalEduhancePopUp;
 

    public string urlReference; //Declare variable

    public void OpenAction()
    {
        modalEduhancePopUp.SetActive(false);

        Application.OpenURL(urlReference); 
    }
}
