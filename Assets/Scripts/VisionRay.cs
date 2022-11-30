using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VisionRay : MonoBehaviour
{
    public GameObject camera;
    public GameObject XRDeviceSimulator;
    // private InputDevice targetDevice;
    // Start is called before the first frame update
    void Start()
    {
        // List<InputDevice> devices = new List<InputDevice>();
        // InputDeviceCharacteristics rightControllerCharacteristics =
        //     InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        // InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        // Debug.Log(devices.Count);
        // if (devices.Count > 0)
        // 	targetDevice = devices[0];
        transform.position = camera.transform.position;
        transform.rotation=camera.transform.rotation;
        Debug.Log(XRDeviceSimulator);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position;
        transform.rotation=camera.transform.rotation;
       
    }
      void OnCollisionEnter(Collision collision)
    {
    // 원하는 코드 작성
    }
    void OnCollisionStay(Collision collision)
    {
        
        // targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        // if (primaryButtonValue)
        // 	Debug.Log("test");
       
        
    // 원하는 코드 작성
    }
}
