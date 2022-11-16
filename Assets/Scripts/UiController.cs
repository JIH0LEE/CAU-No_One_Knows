using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{

    public GameObject globalCanvas;
    public GameObject globalController;

    public Button startButton;
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(startButtonListener);
        exitButton.onClick.AddListener(exitButtonListener);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startButtonListener()
    {
        GameObject intro = globalCanvas.transform.Find("Intro").gameObject;
        startButton.gameObject.SetActive(false);
        intro.SetActive(true);
        
    }

    public void exitButtonListener()
    {
        GameObject intro = globalCanvas.transform.Find("Intro").gameObject;
        intro.SetActive(false);
        globalController.GetComponent<GlobalController>().setStage(1);
    }
}
