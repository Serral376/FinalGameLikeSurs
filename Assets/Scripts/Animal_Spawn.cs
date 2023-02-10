using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Spawn : MonoBehaviour
{

    public GameObject[] Animal;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, 1.5f);


    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + transform.forward * Time.deltaTime;

    }
    private void Spawn()
    {
        int rnd = Random.Range(0, Animal.Length);

        
        Instantiate(Animal[rnd], new Vector3(Random.Range(-24f,24f),0,transform.position.z), Quaternion.Euler(0, 180, 0));



    }
}
