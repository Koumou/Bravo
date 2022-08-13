using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewQuestionS : MonoBehaviour
{
    public GameObject GameObjectQuestionOne;
    public GameObject GameObjectQuestionTwo;
    public GameObject GameObjectQuestionThree;
    public GameObject GameObjectQuestionFour;
    public GameObject GameObjectQuestionFive;

   
    public void ManageQuestions()
    {
        GameObjectQuestionOne.SetActive(true);
        GameObjectQuestionTwo.SetActive(false);
        GameObjectQuestionThree.SetActive(false);
        GameObjectQuestionFour.SetActive(false);
        GameObjectQuestionFive.SetActive(false);

    }

}
