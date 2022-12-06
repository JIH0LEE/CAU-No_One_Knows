using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceController : MonoBehaviour
{

    public GameObject panel;
    public GameObject configPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isCriminal(){
        Debug.Log("Good");
    }

    public void isNotCriminal(){
        Debug.Log("bad");
    }

    public void showPanel(){
        panel.SetActive(true);
        configPanel.SetActive(false);
    }

    public void exitPanel(){
        panel.SetActive(false);
        configPanel.SetActive(true);
    }

    public void select(){
        Debug.Log("select");
    }

    public void unSelect(){
        Debug.Log("unselect");
    }
}
