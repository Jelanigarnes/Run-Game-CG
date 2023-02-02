using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LutToggle : MonoBehaviour
{
    public List<Material> materials = new List<Material>();
   
    void Start()
    {
        
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[2];
        }
    }
}
