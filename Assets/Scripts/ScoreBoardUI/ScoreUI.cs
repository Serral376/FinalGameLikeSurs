using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public rowUI rowUi;
    public ScoreManager scoreManager;

    void Start()
    {
        var scores = scoreManager.GetHighScore().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            if(i >= 12)
            {
                break;
            }
            var row = Instantiate(rowUi, transform).GetComponent<rowUI>();
            row.Rank.text = (i + 1).ToString();
            row.Name.text = scores[i].Name;
            row.Score.text = scores[i].score.ToString();
        }
    }
}

