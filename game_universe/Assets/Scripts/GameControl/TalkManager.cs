
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

    //  ��ȭ ����
    void GenerateData()
    {


        //=========================================house 1=======================================
        // ��
        talkData.Add(100, new string[] { "������ �� �ȵǴ� �� ����" }); //  ��
        talkData.Add(101, new string[] { "������ ��� ���� ���� �����ϱ�� ��ưڴ�" }); // ����
        talkData.Add(102, new string[] { "����� ������", "��� ��������� ���� ���ѸԳ� ����" }); // �����
        // ȭ���
        talkData.Add(110, new string[] { "ȭ����� �����ϰ� ���� ���� �� ��������." }); // ȭ���
        // �ǹ� �ܺ�
        talkData.Add(120, new string[] { "���� ������ ���ڱ�" }); // ������
        talkData.Add(121, new string[] { "������ ���״�" }); // ��ξ�ü

        //=========================================house 2=======================================
        talkData.Add(201, new string[] { "������ ������. �ò����� ���ص� �ǰھ�." });
        talkData.Add(202, new string[] { "�������� �⺻ �ɼ��̳�. ������ �ູ ����" });
        talkData.Add(203, new string[] { "��;; ��� ����!" });
        talkData.Add(204, new string[] { "�����̶� �ξ� ���׸�� ����ϱ�" });
        talkData.Add(205, new string[] { "���� ������ �˳��ؼ� ���� ���� ������� ���ڴ�." });
        talkData.Add(206, new string[] { "�������� �Ǿ� �־ ������ �и��ؼ� �� �� �ְھ�" });

        //=========================================house 3=======================================

        talkData.Add(310, new string[] { "������ ���̶� �׷��� ��Ӱ� ���� ����� ������" });
        talkData.Add(320, new string[] { "������ �濡 ��︮�� �ʴ� �Ŵ��� �ֽ��� ������" });
        talkData.Add(330, new string[] { "������ �ణ�� �����̰� �ִ�" });
        talkData.Add(340, new string[] { "���� ������ ���� �����ϴ�. ���� �� ���� ���� �������ڴ°�" });
        talkData.Add(350, new string[] { "���ڷ������� ���ƺ��δ�" });
        talkData.Add(360, new string[] { "ħ��� ������ �ʾ� ���δ�" }); ;

        //=========================================house 4=======================================

        talkData.Add(400, new string[] { "�ѱ��� ���� �������� �ɹ��� ������" });
        talkData.Add(410, new string[] { "����� ũ��, ������ ȿ���� 1����̴�." });
        talkData.Add(420, new string[] { "������ �� �Ǵ� �� ����" });
        talkData.Add(430, new string[] { "�׷��� ���ڷ������� ��Ź�Ⱑ ����..?" });
        talkData.Add(440, new string[] { "���� �� ������ ��������." });
        talkData.Add(450, new string[] { "ȭ��ǰ� ��Ź���� ������ �ִ�. �ſ� �����غ��δ�" });

        //=========================================house 5=======================================

        talkData.Add(501, new string[] { "�����̶� �������� �����غ��δ�." });
        talkData.Add(502, new string[] { "â���� �о �޺��� �� ������." });
        talkData.Add(503, new string[] { "�� ������ ������ ���." });
        talkData.Add(504, new string[] { "ȭ��ǵ� �����̳� ���� ������ ���ڱ�." });
        talkData.Add(505, new string[] { "����� ũ�� ���������� ����." });
        talkData.Add(506, new string[] { "��ũ��� ������������ ����Ǿ� �ִ� �κ��� �� �г�" });
        talkData.Add(507, new string[] { "�ξ����� â���� ��� �� ȯǳ�⸦ �Ѿ߰ھ�. �۵��� �� �ǳ�." });
        talkData.Add(508, new string[] { "�濡�� �ܼ�Ʈ�� �ϳ� �ִ�." });
        talkData.Add(509, new string[] { "ħ�밡 �ɼ����� ��� �ƽ���." });

        //=========================================house 6=======================================

        // ��
        talkData.Add(600, new string[] { "â�� Ŀ�� �޺��� �� ���´�" }); // â��
        talkData.Add(601, new string[] { "�ɼ� ������ �����غ��δ�" }); // �ɼ� ����
        talkData.Add(602, new string[] { "������ �����غ��δ�. ���踦 ���� �߳�?" }); // ����
        talkData.Add(603, new string[] { "������ ���� ���� �� ����" }); // ����

        // �ξ�
        talkData.Add(610, new string[] { "���� ������ ���� �� ����" }); // ��������
        talkData.Add(611, new string[] { "�ξ��� �и��Ǿ� �ֳ�" }); // �ξ� �� Ŭ��
        // ȭ���
        talkData.Add(620, new string[] { "ȭ����� ���� �����ϴ�","�����⵵ ������ ��ġ�� �־�" }); // â��

        //=========================================house 7=======================================
        //  bed
        talkData.Add(710, new string[] { "ȭ���� ������" }); //  wall
        talkData.Add(711, new string[] { "���ڷ������� �ı⼼ô����� �ɼǿ� �����̶��", "����� ȣȭ�ο� �����̴�." }); //  dish washer
        talkData.Add(712, new string[] { "���嵵 ������ ���� ������ ���ھ�." }); //  closet
        talkData.Add(713, new string[] { "ǫ���� ���̴� ħ���." }); //  bed
        talkData.Add(714, new string[] { "����� ������ ��Ź���.", "�׷��� ����� �������� ���� �� ����.." }); //  Appliance
        talkData.Add(715, new string[] { "������ �� �ȵǴ� �� ����" }); //  wall

        //  bathroom
        talkData.Add(720, new string[] { "���� ���̴� ȭ����̴�.", "���� �� ����������.." }); //  toilet
        talkData.Add(721, new string[] { "���뿡���� ���� ���� ������.", "��ϰ� �ͼ� �� Ǯ�� ���ڴ°�" }); //  tub
        talkData.Add(722, new string[] { "�ſ��� �⹦�� ��ġ�� �ֱ�" }); //  mirror

        //=========================================house 8=======================================
        // bed
        talkData.Add(800, new string[] { "������ ����ϸ� �ȵ� �� ����." }); //  Wall
        talkData.Add(810, new string[] { "���� �� �ָ��� ��ġ�� �ִ� �ָ��� �׸���...", "�� �� ġ������?" }); //  Paintings
        talkData.Add(811, new string[] { "���������� ������ ���� ���ȱ�", "�� �δϱ� �� ������ �����ؾ� �Ϸ���.." }); //  Air Condirional
        talkData.Add(812, new string[] { "Ư���� �� ���� å���̴�.", "�ٵ� ��ü �̰� ���� ������?" }); //  Desk
        talkData.Add(813, new string[] { "������� �ְ� ���� �� �� ���� �� �ϴ�." }); //  Closet
        talkData.Add(814, new string[] { "����� ħ���.", "���ʿ��� ������ ���ϰ� ���� �� ����.", "�� ������ �� ȯ�ڵ� ����� ������.." }); //  Bed

        // kitchen
        talkData.Add(820, new string[] { "���������� �˳��ϱ�" }); //  Cabinet
        talkData.Add(821, new string[] { "���ִ� ���Ĺ� ��� �ϳ� ���� �����ϴ�.", "�׷� ��ü �� ������ ��� ���� ����?" }); //  Sink
        talkData.Add(822, new string[] { "���ڷ��������� �ɼǿ� ���ԵǴ±�. ����� ������ �����̴�." }); //  Microwave
        talkData.Add(823, new string[] { "���� ���� ������ ������.", "�� �濡 �������� ����� �� ���� �� �ϳ�.", "������ ������ ������ �ѵ�..����?" }); //  Frige
        talkData.Add(824, new string[] { "������ �ǹ��̶� �׷��� �������� ������ ������ �ִ�." }); //  Stain

        //  bathroom
        talkData.Add(830, new string[] { "���� ������ ���� ���� ���δ�." }); //  Toilet
        talkData.Add(831, new string[] { "������ ���� �� ���´�." }); //  Sink
        talkData.Add(832, new string[] { "���� �� �� �ϸ� ȭ����� ���ٴٰ� �ǰڱ�." }); //  Shower

        // 6�� ������
        talkData.Add(61, new string[] { "�ź����� ������ �ּҴ�." }); 
        talkData.Add(62, new string[] { "���ӹ����� ��� ü�������" });
        talkData.Add(63, new string[] { "�����忡 ���� ������ �������� ������ Ȯ���ϳ�." });
        talkData.Add(64, new string[] { "�ּҴ� ��������" });
        talkData.Add(65, new string[] { "�ݾ׿��� ������ ����" });
        talkData.Add(66, new string[] { "Ư���� �� ���� Ư������̴�. ���� ����" });
        talkData.Add(67, new string[] { "�Ӵ��� ���� ��� ���ε�� �����ϴ�. ���� ����." });
        //1�� ��༭
        talkData.Add(11, new string[] { "�ּҴ� ���� ���� �� ���� �±�" });
        talkData.Add(12, new string[] { "�����ᰡ �� ������?" });
        talkData.Add(13, new string[] { "Ư������� �� ���� ���� �� �ȹ����ְڳ�" });
        talkData.Add(14, new string[] { "�븮���� ������ �������� �´����� Ȯ���ϸ� �ǰھ�." });
        //5�� ��༭
        talkData.Add(51, new string[] { "�ּҴ� ���� ���� �� ���� �����ϱ�" }); //�ּ�
        talkData.Add(52, new string[] { "�Ʊ� ������ �ó� ? �󸶿�����.. �������̶� ������ ���ļ� �ü� 80% �ѳ�?" }); //������
        talkData.Add(53, new string[] { "�߰�������� �����ϳ�" }); //�߰�������
        talkData.Add(54, new string[] { "�翬�� ���󺹱� �ؾ���. Ư����� �� ������" }); //Ư��
        talkData.Add(55, new string[] { "�Ӵ��� ���� ���ε�� �����ϳ�. ��������" }); // �Ӵ��� ����
        talkData.Add(56, new string[] { "�����߰��絵 ���� �ɷ��ִ� ������ ��ġ�ϴϱ� ���� �ƴ� �� ����" }); // �����߰��� ����
        // 5�� ���ε
        talkData.Add(551, new string[] { "���� �� ���̶� ���ε �ּ� �����ϳ�. ��������" }); //�ּ�
        talkData.Add(552, new string[] { "������ �̵� ��༭ �� �� ������ Ȯ���ؾ���" }); //������
        talkData.Add(553, new string[] { "������ �����Ǿ���. �Ӵ����� ���� �򳪺���." }); //������ ����
        talkData.Add(554, new string[] { "�������� �ֳ�. �������̶� ������ ���ļ� �ü� 80% ������ �����ѵ�...." }); //������
        talkData.Add(555, new string[] { "���һ��� �����̴ϱ� ��� �������� �����ִ� ������" }); //���һ���


    }

    //  ��ȭ �ҷ�����
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