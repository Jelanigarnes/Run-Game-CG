using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEffects : MonoBehaviour
{
    public List<Material> materials = new List<Material>();

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
        }
           
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[1];
        }
           
    }

    
}
