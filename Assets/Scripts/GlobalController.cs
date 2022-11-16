using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{

    public int stage;
    public int step;
    // Start is called before the first frame update
    void Start()
    {
        stage=0;
        step=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setStage(int num){
        stage=num;
    }
}
