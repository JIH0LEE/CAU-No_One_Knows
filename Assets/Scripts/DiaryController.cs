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
            "친구한테 돈을 빌렸다\n드디어 내 사업을 시작할 충분한 자금이 모였어\n살짝 부족하긴 하지만 폐수 정화쪽에 돈 좀 빼면 괜찮겠지",
            "사업이 대박났다\n유명회사 구찌에서 나에게 협력사업을 제안했다. 완전 꿈같다\n현금이 좀 부족하지만 여기서 사업을 더 키우면 대박이 날거야\n사업에 성공할때까지 날 도와준 여자 친구한테도 좀 잘해줘야겠다.\n여자친구한테 구두를 선물해줬다",
            "회사를 키우기 위해 다른 회사에서 디자인팀장 배민희와 기획팀장 이영한이 들어왔다.\n배민희가 내 이상형이다.\n나이차이가 좀 있지만 조금 들이대봐야겠다",
            "친구가 와서 돈 회수를 요구한다\n자녀가 아프단다. 그 마음은 이해하지만 들어줄 수 없었다\n나도 사업규모를 키워놔서 현재 돈을 돌려줄 수 없는데 막무가내로 돌려달라니 말이 안된다.",
            "친구가 계속 와서 돈을 달라고 요구한다.\n물론 줘야하지만 돈이 없어서 줄 수 없다.\n경비원을 시켜서 그 친구가 우리 회사에 더 이상 들어오지 못하게 제지시켜야 하나",
            "마을 조합단체에서 사람이 왔다.\n우리가 배출한 폐수로 인해 마을 사람들의 농작물이 다 죽어서 손해가 이만저만이 아니라고 했다.\n참나 그거 좀 버렸다고 다 죽었다는게 말이 되나, 자기가 농사를 잘못 지어놓고는 우리에게 책임전가하는게 틀림없다.\n조금만 정화하고 그 물을 가져가서 우린 정화하고 버린다고 시청에 보여주면 그만이다.\n끝까지 잡아뗄거다",
            "친구가 나를 고소했다.\n돈이 없을 텐데했더니 유튜브에서 들어보지도 못한 변호사를 통해 고소했더라\n난 로펌에서 변호사 고용해서 승소할거다",
            "마을 단체에서 나를 고소했다.\n주변 사람들이 왜 이렇게 나한테 짜증나게 하는지 모르겠다.\n저번에 시청 사람들이 우리 잘못이 아니라고 확인도 해 줬을텐데 왜 그러는지 모르겠다.\n이런데서 돈이 나가면 안되는데 화가 난다.",
            "배민희가 남자친구가 있다고 한다.\n하지만 골키퍼가 있다고 골이 안들어가나\n계속 대쉬 하다보면 나한테 오겠지",
            "배민희한테 치근덕댄걸 나영희(여자친구)가 알아서 싸웠다.\n나영희랑은 너무 오래 만나서 질린다\n배민희가 더 예쁜걸 어떡하라는건지 모르겠다\n근데 누가 걔한테 말한거야",
            "이영한이 나한테 와서 배민희한테 그만 대쉬해달라고 말했다.\n직원주제에 나한테 명령을 해?\n짤라버릴까하다가 지금 협력사업때문에 감봉으로 마무리해야겠다\n그래도 나한테 대들면 어떻게 되는지 똑똑히 보여줘야겠어",
            "친구과의 소송에서 승소했다.\n친구한테는 미안하지만 돈을 지금 줘야할 의무는 없다\n이따 사업 커지면 그때 더 많이 줄게\n",
            "오늘 회사에서 늦게 퇴근하는데 누가 뒤에서 서성이는 것 같다.\n소리를 들어보면 워커인것 같은데\n대체 누가 이 밤중에 오는 건지 모르겠다",
            "여자친구랑 엄청나게 싸웠다.\n헤어지자고 했더니, 헤어질거면 날 죽여버리겠다고 했다.\n참나, 지가 날 어떻게 하겠다고",
            "회사 컨퍼런스에 가서 하얀색 펜을 받았다.\n신기한 펜이다\n일반 펜처럼 생겼는데 그냥 쓰면 안보이고, 빛을 가져다 대면 보인다.\n재밌다 이 펜",
            "오늘따라 회사 일도 많고 찾아온다는 사람도 많은것같다.\n여자친구랑 철수, 왕재수가 온다고 연락이 왔다.\n밤 11시 너무 늦은 시간에 퇴근한다.\n회사에는 배민희도 아직도 퇴근 못하고 있는 것 같다.\n나도 얼른 집에 가야겠다."
            
        };
        date = new string[] {
            "2022년 3월 9일",
            "2022년 6월 10일",
            "2022년 6월 22일",
            "2022년 7월 10일",
            "2022년 7월 23일",
            "2022년 8월 1일",
            "2022년 8월 20일",
            "2022년 8월 21일",
            "2022년 8월 23일",
            "2022년 8월 26일",
            "2022년 9월 10일",
            "2022년 10월 6일",
            "2022년 10월 31일",
            "2022년 11월 2일",
            "2022년 11월 8일",
            "2022년 11월 24일"
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
