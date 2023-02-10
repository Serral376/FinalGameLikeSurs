using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Vector3 dir1;
    public Vector3 dir2;
    public float dist1;
    public float dist2;
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 45 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, -45 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * Speed;
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;   
        // Gizmos.DrawCube(transform.position(0, 0, 0), new Vector3(1, 1, 1));
        Gizmos.DrawLine(new Vector3(0, 0, 0),dir1* dist1);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector3(0, 0, 0),dir2* dist2);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector3(0,0,0), dir2 * dist2+ dir1 * dist1);
        
    }
    
}