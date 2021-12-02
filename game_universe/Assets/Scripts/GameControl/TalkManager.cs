
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        
        GenerateData();
    }

    //  대화 저장
    void GenerateData()
    {


        //=========================================house 1=======================================
        // 방
        talkData.Add(100, new string[] { "방음이 잘 안되는 것 같아" }); //  벽
        talkData.Add(101, new string[] { "옷장이 없어서 옷을 많이 보관하기는 어렵겠다" }); // 옷장
        talkData.Add(102, new string[] { "평범한 냉장고다", "평소 배달음식을 많이 시켜먹나 보네" }); // 냉장고
        // 화장실
        talkData.Add(110, new string[] { "화장실은 깨끗하고 변기 물도 잘 내려간다." }); // 화장실
        // 건물 외부
        talkData.Add(120, new string[] { "벌레 걱정은 없겠군" }); // 세스코
        talkData.Add(121, new string[] { "무서운 동네다" }); // 대부업체

        //=========================================house 2=======================================
        talkData.Add(201, new string[] { "방음이 괜찮네. 시끄럽게 말해도 되겠어." });
        talkData.Add(202, new string[] { "에어컨도 기본 옵션이네. 여름에 행복 예약" });
        talkData.Add(203, new string[] { "아;; 담배 냄새!" });
        talkData.Add(204, new string[] { "신축이라 부엌 인테리어도 깔끔하군" });
        talkData.Add(205, new string[] { "수납 공간이 넉넉해서 짐이 많은 사람한테 좋겠다." });
        talkData.Add(206, new string[] { "복층으로 되어 있어서 공간을 분리해서 살 수 있겠어" });

        //=========================================house 3=======================================

        talkData.Add(310, new string[] { "반지하 방이라 그런지 어둡고 습한 기운이 감돈다" });
        talkData.Add(320, new string[] { "반지하 방에 어울리지 않는 거대한 최신형 냉장고다" });
        talkData.Add(330, new string[] { "벽지에 약간의 곰팡이가 있다" });
        talkData.Add(340, new string[] { "변기 수압이 아주 강력하다. 휴지 한 통이 전부 내려가겠는걸" });
        talkData.Add(350, new string[] { "전자레인지가 좋아보인다" });
        talkData.Add(360, new string[] { "침대는 나쁘지 않아 보인다" }); ;

        //=========================================house 4=======================================

        talkData.Add(400, new string[] { "한국의 얼이 느껴지는 꽃무늬 벽지다" });
        talkData.Add(410, new string[] { "냉장고가 크고, 에너지 효율이 1등급이다." });
        talkData.Add(420, new string[] { "방음은 잘 되는 것 같다" });
        talkData.Add(430, new string[] { "그런데 전자레인지와 세탁기가 없네..?" });
        talkData.Add(440, new string[] { "벌레 한 마리가 지나간다." });
        talkData.Add(450, new string[] { "화장실과 세탁실이 합쳐져 있다. 매우 불편해보인다" });

        //=========================================house 5=======================================

        talkData.Add(501, new string[] { "신축이라서 에어컨은 깨끗해보인다." });
        talkData.Add(502, new string[] { "창문이 넓어서 햇빛이 잘 들어오네." });
        talkData.Add(503, new string[] { "집 구조가 마음에 든다." });
        talkData.Add(504, new string[] { "화장실도 곰팡이나 벌레 걱정은 없겠군." });
        talkData.Add(505, new string[] { "냉장고도 크고 수납공간이 많다." });
        talkData.Add(506, new string[] { "싱크대랑 가스레인지가 연결되어 있는 부분이 꽤 넓네" });
        talkData.Add(507, new string[] { "부엌에는 창문이 없어서 꼭 환풍기를 켜야겠어. 작동은 잘 되네." });
        talkData.Add(508, new string[] { "방에도 콘센트가 하나 있다." });
        talkData.Add(509, new string[] { "침대가 옵션으로 없어서 아쉽군." });

        //=========================================house 6=======================================

        // 방
        talkData.Add(600, new string[] { "창이 커서 햇빛이 잘 들어온다" }); // 창문
        talkData.Add(601, new string[] { "옵션 가구가 깨끗해보인다" }); // 옵션 가구
        talkData.Add(602, new string[] { "벽지가 깨끗해보인다. 도배를 새로 했나?" }); // 벽지
        talkData.Add(603, new string[] { "옷장은 따로 없는 것 같다" }); // 옷장

        // 부엌
        talkData.Add(610, new string[] { "조리 공간이 좁은 것 같아" }); // 조리공간
        talkData.Add(611, new string[] { "부엌이 분리되어 있네" }); // 부엌 문 클릭
        // 화장실
        talkData.Add(620, new string[] { "화장실은 정말 깨끗하다","샤워기도 적당한 위치에 있어" }); // 창문

        //=========================================house 7=======================================
        //  bed
        talkData.Add(710, new string[] { "화려한 벽지군" }); //  wall
        talkData.Add(711, new string[] { "전자레인지에 식기세척기까지 옵션에 포함이라니", "상당히 호화로운 구성이다." }); //  dish washer
        talkData.Add(712, new string[] { "옷장도 있으니 수납 걱정은 없겠어." }); //  closet
        talkData.Add(713, new string[] { "푹신해 보이는 침대다." }); //  bed
        talkData.Add(714, new string[] { "평범한 냉장고와 세탁기다.", "그런데 냉장고가 생각보다 작은 것 같네.." }); //  Appliance
        talkData.Add(715, new string[] { "방음이 잘 안되는 것 같아" }); //  wall

        //  bathroom
        talkData.Add(720, new string[] { "낡아 보이는 화장실이다.", "물은 잘 내려가려나.." }); //  toilet
        talkData.Add(721, new string[] { "원룸에서는 보기 힘든 욕조네.", "운동하고 와서 몸 풀기 좋겠는걸" }); //  tub
        talkData.Add(722, new string[] { "거울이 기묘한 위치에 있군" }); //  mirror

        //=========================================house 8=======================================
        // bed
        talkData.Add(800, new string[] { "방음은 기대하면 안될 것 같다." }); //  Wall
        talkData.Add(810, new string[] { "뭐지 저 애매한 위치에 있는 애매한 그림은...", "한 번 치워볼까?" }); //  Paintings
        talkData.Add(811, new string[] { "에어컨으로 벗겨진 벽을 가렸군", "뭐 싸니까 이 정도는 감수해야 하려나.." }); //  Air Condirional
        talkData.Add(812, new string[] { "특별할 것 없는 책상이다.", "근데 대체 이게 무슨 냄새야?" }); //  Desk
        talkData.Add(813, new string[] { "옷장까지 있고 갖출 건 다 갖춘 듯 하다." }); //  Closet
        talkData.Add(814, new string[] { "평범한 침대다.", "이쪽에서 냄새가 심하게 나는 것 같다.", "이 정도면 비염 환자도 힘들것 같은데.." }); //  Bed

        // kitchen
        talkData.Add(820, new string[] { "수납공간은 넉넉하군" }); //  Cabinet
        talkData.Add(821, new string[] { "껴있는 음식물 찌꺼기 하나 없이 깨끗하다.", "그럼 대체 이 냄새는 어디서 나는 거지?" }); //  Sink
        talkData.Add(822, new string[] { "전자레인지까지 옵션에 포함되는군. 상당히 괜찮은 조건이다." }); //  Microwave
        talkData.Add(823, new string[] { "성에 없이 깨끗한 냉장고다.", "이 방에 오랫동안 사람이 안 들어온 듯 하네.", "입지도 괜찮고 월세도 싼데..왜지?" }); //  Frige
        talkData.Add(824, new string[] { "오래된 건물이라 그런지 군데군데 벽지가 벗겨져 있다." }); //  Stain

        //  bathroom
        talkData.Add(830, new string[] { "변기 수압은 문제 없어 보인다." }); //  Toilet
        talkData.Add(831, new string[] { "따뜻한 물도 잘 나온다." }); //  Sink
        talkData.Add(832, new string[] { "샤워 한 번 하면 화장실이 물바다가 되겠군." }); //  Shower

        // 6번 위임장
        talkData.Add(61, new string[] { "신분증과 동일한 주소다." }); 
        talkData.Add(62, new string[] { "위임범위는 계약 체결까지군" });
        talkData.Add(63, new string[] { "위임장에 찍힌 도장은 집주인의 도장이 확실하네." });
        talkData.Add(64, new string[] { "주소는 문제없다" });
        talkData.Add(65, new string[] { "금액에는 문제가 없다" });
        talkData.Add(66, new string[] { "특별할 것 없는 특약사항이다. 문제 없다" });
        talkData.Add(67, new string[] { "임대인 정보 모두 등기부등본과 동일하다. 문제 없다." });
        //1번 계약서
        talkData.Add(11, new string[] { "주소는 내가 갔다 온 데가 맞군" });
        talkData.Add(12, new string[] { "수수료가 몇 프로지?" });
        talkData.Add(13, new string[] { "특약사항을 잘 봐야 나갈 때 안물어주겠네" });
        talkData.Add(14, new string[] { "대리인은 없으니 집주인이 맞는지만 확인하면 되겠어." });
        //5번 계약서
        talkData.Add(51, new string[] { "주소는 내가 보고 온 곳과 동일하군" }); //주소
        talkData.Add(52, new string[] { "아까 근저당 봤나 ? 얼마였더라.. 근저당이랑 보증금 합쳐서 시세 80% 넘나?" }); //보증금
        talkData.Add(53, new string[] { "중개수수료는 적당하네" }); //중개수수료
        talkData.Add(54, new string[] { "당연히 원상복구 해야지. 특약사항 잘 봐두자" }); //특약
        talkData.Add(55, new string[] { "임대인 정보 등기부등본과 동일하네. 문제없어" }); // 임대인 정보
        talkData.Add(56, new string[] { "공인중개사도 저기 걸려있는 정보랑 일치하니까 사기는 아닌 것 같네" }); // 공인중개사 정보
        // 5번 등기부등본
        talkData.Add(551, new string[] { "내가 본 곳이랑 등기부등본 주소 동일하네. 문제없다" }); //주소
        talkData.Add(552, new string[] { "소유주 이따 계약서 볼 때 같은지 확인해야지" }); //소유주
        talkData.Add(553, new string[] { "소유권 이전되었네. 임대인이 새로 샀나보네." }); //소유권 이전
        talkData.Add(554, new string[] { "근저당이 있네. 근저당이랑 보증금 합쳐서 시세 80% 넘으면 위험한데...." }); //근저당
        talkData.Add(555, new string[] { "말소사항 포함이니까 모든 등기사항을 보여주는 서류네" }); //말소사항


    }

    //  대화 불러오기
    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public int GetLength(int id)
    {
        return talkData[id].Length;
    }
}