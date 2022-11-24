using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    //빛 괘적을 그릴 라인 렌더러
    private LineRenderer LightLineRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        LightLineRenderer = GetComponent<LineRenderer>();
        LightLineRenderer.enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnOn()
    {
        LightLineRenderer.enabled=true;
    }
}
