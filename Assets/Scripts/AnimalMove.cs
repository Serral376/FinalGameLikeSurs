using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * 5;//скрипт на движение
        if (transform.position.z <-16)
        {
            GameObject.Find("player").GetComponent<Move_character>().Damage();
            Destroy(gameObject);

            

        }
        

    }
    
}
