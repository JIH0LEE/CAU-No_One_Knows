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
        dialogs.Add("영희",new string[]{"그 놈이 바람피려고 하는 건 알고 있어. 난 그날 걔한테 헤어지자고 통보하러 만나러 갔던거야", "그런데 회사 미팅이 있다고 만나지도 못하고 돌아왔어" });
        dialogs.Add("민희",new string[]{ "서류 상 결제할 일이 있어서 사장님을 뵈러 갔지만, 아무도 없길래 서류만 놓고 가려고 들어가니 사장님이 머리에 피를 흘린 채 누워있었어", "그 시간동안은 아무도 만나지 않아서 누가 범인인지 잘 모르겠어", "근데 나는 진짜 아니야" });
        dialogs.Add("영한",new string[]{ "나는 그날 먼저 퇴근하고 회사 앞 카페에서 배민희를 기다리는 중이었어. 배민희가 끝나고 나서 데이트하기로 했거든", "내가 회사 퇴근할때까지는 사장이 먼저 퇴근하냐고 핀잔을 줬다고" });
        dialogs.Add("왕재수",new string[]{ "그날 손해배상 청구를 위해 회사를 찾아간건 사실이야. 끝까지 발뺌하던 그 놈이 죽은건 안타깝지만, 내가 죽이진 않았어", "무엇보다 난 들어가다 배민희와 만나서 사장이 죽었다는 소식을 들어 만나지 못했다고" });
        dialogs.Add("철수",new string[]{ "물론 웬수같은 놈이지만, 난 사람 안죽여. 그날도 민사소송을 다른 방법으로 다시 걸어서 받아낼 거라고 말하려고 했는데 그 놈이 여자친구를 만나고 있어서 만나지 못하고 다시 돌아왔어" });
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
