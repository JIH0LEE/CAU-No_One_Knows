using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceController : MonoBehaviour
{

    public GameObject panel;
    public GameObject configPanel;
    public GameObject exitButton;
    public GameObject exitContainer;
    public GameObject explainContainer;
    public GameObject endingPanel;
    public Text endingText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void onExitButtonClicked(){
        exitContainer.SetActive(true);
        exitButton.SetActive(false);
    }

    public void OkButtonClicked(){
        Application.Quit();
    }

    public void CancelButtonClicked(){

        exitContainer.SetActive(false);
        exitButton.SetActive(true);
    }

    public void isCriminal(){
        endingText.text="범인 검거 성공!";

        panel.SetActive(false);
        endingPanel.SetActive(true);

    }

    public void isNotCriminal(){
        endingText.text="범인 검거 실패!";

        panel.SetActive(false);
        endingPanel.SetActive(true);
    }

    public void OnExplainationClicked(){
        explainContainer.SetActive(true);
    }

    public void OnExplainationCanceled(){
        explainContainer.SetActive(false);
    } 
    public void showPanel(){
        panel.SetActive(true);
    }

    public void exitPanel(){
        panel.SetActive(false);
        configPanel.SetActive(true);
        exitButton.SetActive(true);
    }

    public void select(){
        Debug.Log("select");
    }

    public void unSelect(){
        Debug.Log("unselect");
    }
}
