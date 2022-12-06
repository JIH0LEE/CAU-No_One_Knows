using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VisionRay : MonoBehaviour
{
    public GameObject camera;
    public XRController XRDeviceSimulator;
    public GameObject dialogController;
    public GameObject globalController;
    float speed;
    // private InputDevice targetDevice;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = camera.transform.position;
        transform.rotation=camera.transform.rotation;
        speed =0.0001f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = camera.transform.position;
        transform.rotation=camera.transform.rotation;
        // transform.Translate(Vector3.forward*speed);
   
    }
    
    void OnTriggerEnter(Collider collision)
    {
        if(globalController.GetComponent<GlobalController>().stage==1 && collision.gameObject.tag=="NPC" && globalController.GetComponent<GlobalController>().isTalking == false){
            globalController.GetComponent<GlobalController>().isTalking = true;            
            dialogController.GetComponent<DialogController>().startDialog(collision.gameObject.transform.parent.name);
        }
        
        
    }

    // void OnTriggerStay(Collider collision)
    // {
    //     if(globalController.GetComponent<GlobalController>().stage==1 && collision.gameObject.tag=="NPC" && globalController.GetComponent<GlobalController>().isTalking == false){
    //         globalController.GetComponent<GlobalController>().isTalking = true;            
    //         dialogController.GetComponent<DialogController>().startDialog(collision.gameObject.transform.parent.name);
    //     }
        
        
    // }
    
}
