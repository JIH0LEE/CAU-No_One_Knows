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
        GameObject title = globalCanvas.transform.Find("Title").gameObject;
        intro.SetActive(true);
        startButton.gameObject.SetActive(false);
        title.SetActive(false);
        
    }

    public void exitButtonListener()
    {
        GameObject intro = globalCanvas.transform.Find("Intro").gameObject;
        intro.SetActive(false);
        globalController.GetComponent<GlobalController>().changeStageOne();
    }
}
