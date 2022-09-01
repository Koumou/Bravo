using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI headerText;
    public TextMeshProUGUI resultCommentText;
    public GameObject timerObj;

    int result = 0;

    private void Start()
    {
        scoreText.text = result.ToString() + "/" + "3";
        headerText.text = "Result";
        resultCommentText.text = "Comment";
    }

    public void CorrectAnswer()
    {
        result += 1;
    }

    public void IncorrectAnswer()
    {

    }

    public void StopTimer()
    {
        timerObj.SetActive(false);
    }
}
