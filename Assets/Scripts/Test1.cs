using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Test1 : MonoBehaviour // доступный всем скриптам базовый класс тест 1
{
    public Move_character PlayerScript;  
    public Transform Player;
    public Vector3 ClickPoint;
    public GameObject[] Food;
    public int Indexinput;
    public Image[] FoodBotoms;
    

    // Start is called before the first frame update
    void Start() // до первого фрейма
    {
        


    }

    // Update is called once per frame
    void Update() // каждый фрейм
    {

        Ray R; 
        if (Input.GetMouseButtonDown(0)) // if mouse left buttom activate 
        {
            
            RaycastHit hit; // ray to the point of hitting
            R = Camera.main.ScreenPointToRay(Input.mousePosition); // why we use camera  
            Physics.Raycast(R, out hit, 100); // 
            if(Physics.Raycast(R, out hit, 100))
            {
                GameObject result;
                Debug.Log(hit.point);
                ClickPoint = hit.point;
                result = Instantiate(Food[Indexinput], Player.transform.position, Quaternion.identity);
                result.transform.LookAt(new Vector3(ClickPoint.x, 0.5f, ClickPoint.z));
            }
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChangingColour();
            Indexinput = 0;
            FoodBotoms[0].color = new Color32 (128,0,128,64);

            
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChangingColour();
            Indexinput = 1;
            FoodBotoms[1].color = new Color32 (128,0,128,64);
        }
    }
    
    private void OnDrawGizmos()
    {

        //Gizmos.DrawLine(transform.position,new Vector3(5,4,3));
        //Gizmos.DrawRay(R.origin,R.direction *1000);
        Gizmos.DrawSphere(ClickPoint, (1));
        Gizmos.DrawLine(ClickPoint,PlayerScript.transform.position);

    }
    void ChangingColour()
    {
        foreach (Image i in FoodBotoms)
        {
            i.color = Color.white;
        }
    }
}   
