using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{

    public Button uiButton;
    public Text npcName;
    public Text body;
    public GameObject globalController;
    Dictionary<string,string[]> dialogs;
    Dictionary<string,bool> isDialogFinished;
    string currentName;
    private int currentIndex;
    // Start is called before the first frame update
    void Start()
    {

        currentIndex = 0;
        dialogs = new Dictionary<string,string[]>();
        isDialogFinished = new Dictionary<string,bool>();
        dialogs.Add("영희",new string[]{"안녕하세요","감사합니다"});
        dialogs.Add("민희",new string[]{"안녕하세요","감사합니다"});
        dialogs.Add("영한",new string[]{"안녕하세요","감사합니다"});
        dialogs.Add("왕재수",new string[]{"안녕하세요","감사합니다"});
        dialogs.Add("철수",new string[]{"안녕하세요","감사합니다"});
        uiButton.onClick.AddListener(UiButtonListener);
   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startDialog(string name){
        currentName = name;
        Debug.Log(name);
        npcName.text = currentName;
        string [] bodys;
        if(dialogs.TryGetValue(currentName,out bodys)){
            body.text = bodys[currentIndex];
  
        }
        uiButton.gameObject.SetActive(true); 
    }

    public void UiButtonListener()
    {
        string [] bodys;
        if(dialogs.TryGetValue(currentName,out bodys)){
            currentIndex = currentIndex + 1;
            if(currentIndex>=bodys.Length){
                currentIndex = 0;
                uiButton.gameObject.SetActive(false); 
                globalController.GetComponent<GlobalController>().dialogFinish(currentName);
            } 
            else{
                body.text = bodys[currentIndex];
            }
        }
        
    }
}
