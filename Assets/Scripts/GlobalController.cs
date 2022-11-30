using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    Dictionary<string,bool> isDialogFinished;
    public int stage;
    public int step;
    // Start is called before the first frame update
    void Start()
    {
        stage=0;
        step=0;
        isDialogFinished = new Dictionary<string,bool>();
        isDialogFinished.Add("영희",false);
        isDialogFinished.Add("민희",false);
        isDialogFinished.Add("영한",false);
        isDialogFinished.Add("왕재수",false);
        isDialogFinished.Add("철수",false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private bool isDialogAllFinish(){
        bool ret = true;
        foreach(var pair in isDialogFinished){
            if(pair.Value==false){
                ret = false;
            }
        }
        return ret;
    }
    public void setStage(int num){
        stage=num;
    }

    public void dialogFinish(string name){
        isDialogFinished[name]=true;
      
        if(isDialogAllFinish()){
            setStage(2);
        }
    }
    
}
