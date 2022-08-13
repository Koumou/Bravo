using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlEduhanceLearnMore : MonoBehaviour
{
    public GameObject modalEduhancePopUpTCS;
    public GameObject modalEduhancePopUpLM;
    public GameObject modalEduhancePopUpTR;

    public string urlReference; //Declare variable

    public void OpenAction()
    {
        Application.OpenURL(urlReference);

        modalEduhancePopUpTCS.SetActive(false);
        modalEduhancePopUpLM.SetActive(false);
        modalEduhancePopUpTR.SetActive(false);
    }
}
