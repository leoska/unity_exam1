using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public float speed = 2f; // Per Second
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hoz = System.Convert.ToInt32(Input.GetKey(KeyCode.D)) - System.Convert.ToInt32(Input.GetKey(KeyCode.A));
        var ver = System.Convert.ToInt32(Input.GetKey(KeyCode.W)) - System.Convert.ToInt32(Input.GetKey(KeyCode.S));

        var pos = transform.position;
        
        transform.position = new Vector3(pos.x + (hoz * speed * Time.deltaTime), pos.y + (ver  * speed * Time.deltaTime), pos.z);
    }
}
