using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class script_buttom : MonoBehaviour
{
    public GameObject NameHold;
    public TMP_InputField InputField;
    public void Start_game()
    {
        DontDestroyOnLoad(NameHold);
        NameHolder.name = InputField.text != ""? InputField.text: "Name";
        SceneManager.LoadScene(1);
        

        
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(1);
    }
    public void Exit_game()
    {
        Application.Quit();

    }
    public void Exit_to_Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void EnterScoreboard()
    {
        SceneManager.LoadScene(2);
    }
    public void BeforeTheGameEnding()
    {
        SceneManager.LoadScene(3);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
