using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManageScenes : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("Home");
    }
    public void LearnMore()
    {
        SceneManager.LoadScene("LearnMore");
    }

    public void Score()
    {
        SceneManager.LoadScene("Score");
    }
    public void Quiz()
    {
        SceneManager.LoadScene("ReviewQuestion");
    }
}
