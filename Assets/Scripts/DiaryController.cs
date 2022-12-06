using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaryController : MonoBehaviour
{
    public int idx;
    string [] body;
    string [] date;
    public Text leftDate;
    public Text leftBody;
    public Text rightDate;
    public Text rightBody;


    // Start is called before the first frame update
    void Start()
    {
        idx = 0;
        body = new string[] {
            "안녕하세요.\n오늘 날씨가 춥네요",
            "안녕하세요.\n오늘 날씨가 춥네요2",
            "안녕하세요.\n오늘 날씨가 춥네요3",
            "안녕하세요.\n오늘 날씨가 춥네요4"
        };
        date = new string[] {
            "12월 1일",
            "12월 2일",
            "12월 3일",
            "12월 4일"
        };
        leftDate.text = date[idx];
        leftBody.text = body[idx];
        rightDate.text = date[idx+1];
        rightBody.text = body[idx+1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextPage(){
        idx = idx + 2;
        if(idx >= body.Length){
            idx = idx -2;
        }
        leftDate.text = date[idx];
        leftBody.text = body[idx];
        rightDate.text = date[idx+1];
        rightBody.text = body[idx+1];
    }

    public void previousPage(){
        idx = idx - 2;
        if(idx <= 0){
            idx = 0;
        }
        leftDate.text = date[idx];
        leftBody.text = body[idx];
        rightDate.text = date[idx+1];
        rightBody.text = body[idx+1];
    }
}
