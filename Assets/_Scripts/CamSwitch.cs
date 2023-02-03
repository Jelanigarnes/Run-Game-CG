using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            MainCamera.SetActive(true);
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MainCamera.SetActive(false);
            camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MainCamera.SetActive(false);
            camera1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MainCamera.SetActive(false);
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
    }
}
