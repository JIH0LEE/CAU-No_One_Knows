using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    //빛 괘적을 그릴 라인 렌더러
    //private LineRenderer LightLineRenderer;
    RaycastHit hit;
    public Transform rayTransform;
    public float rayDistance;
    bool triggerValue = false;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerValue == true)
        {
            TurnOn();
        }
        else
        {
            TurnOff();
        }
        
    }

    public void TurnOn()
    {
        GameObject.Find("Switch").transform.GetChild(0).gameObject.SetActive(true);

        if (Physics.Raycast(rayTransform.position, rayTransform.forward, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("dyingMessageTrigger"))
            {
                GameObject.Find("Trigger").transform.GetChild(0).gameObject.SetActive(true);
            }
            else{
                GameObject.Find("Trigger").transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }

    public void TurnOff()
    {
        GameObject.Find("Switch").transform.GetChild(0).gameObject.SetActive(false);
        GameObject.Find("Trigger").transform.GetChild(0).gameObject.SetActive(false);
    }
    public void Set()
    {
        if (triggerValue == false)
        {
            triggerValue = true;
        }
        else
        {
            triggerValue = false;
        }
    }
}
