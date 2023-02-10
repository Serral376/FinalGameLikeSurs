using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    private  ScoreData sd;
    private void Awake()
    {
        string json = PlayerPrefs.GetString("scores","{}");
        sd = JsonUtility.FromJson<ScoreData>(json);
    }

    // Update is called once per frame
    public  IEnumerable<Score> GetHighScore()
    {
        return sd.scores.OrderByDescending(x => x.score);
    }
    public  void AtScore(Score scr)
    {
        sd.scores.Add(scr);
    }
    private  void OnDestroy()
    {
        SaveScore();
    }
    public void SaveScore()
    {
        string json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("scores",json);
    }
}
