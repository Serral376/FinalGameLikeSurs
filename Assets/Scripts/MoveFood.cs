using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFood : MonoBehaviour
{
    public bool IsForBarashek;
    public int SpeedFood;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + transform.forward*Time.deltaTime*SpeedFood;



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hunter") && !IsForBarashek) 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("player").GetComponent<Move_character>().AddScore();

        }
        if (other.CompareTag("Barashek") && IsForBarashek)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("player").GetComponent<Move_character>().AddScore();

        }



    }


}
