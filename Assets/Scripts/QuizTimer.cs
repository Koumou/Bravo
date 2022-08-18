using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizTimer : MonoBehaviour
{
    [SerializeField] private Image timerFront;
    [SerializeField] private TextMeshProUGUI timerText;
    public GameObject submitScoreObj;
    public GameObject timerObj;
    string tagName = "Question";

    public int startTime;

    private int timeRemaining;

    private void Start()
    {
        Being(startTime);
    }

    private void Being(int second)
    {
        timeRemaining = second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(timeRemaining >= 0)
        {
            timerText.text = $"{timeRemaining / 60:00} : {timeRemaining % 60:00}";
            timerFront.fillAmount = Mathf.InverseLerp(0, startTime, timeRemaining);
            timeRemaining--;
            yield return new WaitForSeconds(1f);
        }
        OnEnd();
    }

    private void OnEnd()
    {
        print("end");
        submitScoreObj.SetActive(true);
        timerObj.SetActive(false);

        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tagName);
        foreach (GameObject tagged in taggedObjects)
        {
            tagged.SetActive(false);
        }

    }
}
