using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Move_character : MonoBehaviour
{
    public TMP_Text text_hp;
    public TMP_Text text_score;
    public ScoreManager ScoreManager;
    public int HP;
    public int Score;
    public float Speed = 6 ;
    public GameObject GameOver;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1;
    }
    void Start()
    {
        text_score.text = "Score " + Score;
        text_hp.text = "HP " + HP;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1, 0, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 1) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -1) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 1, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.position = transform.position + new Vector3(0, -1, 0) * Speed * Time.deltaTime;

        }

       
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
        Gizmos.DrawLine(transform.position, transform.position + transform.right);
        Gizmos.DrawLine(transform.position, transform.position + transform.forward + transform.right);
        //Gizmos.DrawLine(transform.position, transform.position +ClicPoint);
    }
    
    public void AddScore()
    {
        Score++;
        text_score.text = "Score " + Score;
    }

    public void Damage()
    {
        HP--;
        text_hp.text = "HP " + HP;

        if (HP <= 0)
        {
            Time.timeScale = 0;
            ScoreManager.AtScore(new Score(NameHolder.name, Score));
            ScoreManager.SaveScore();
            GameOver.SetActive(true);

        }
    }










}
