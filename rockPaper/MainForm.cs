using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace rockPaper
{
    public partial class MainForm : Form
    {
        //컴퓨터 값 출력
        enum Translation { Scissors, Rock, Wrapper}
        //유저 선택값 
        bool[] gameValue = new bool[3];

        bool runGame = false;    //게임시작
        bool resetGame = false;  //게임리셋
        int count = 3;           //카운트다운
        bool twingkle = false;   //깜빢깜빢

        bool hasTrue = false;

        int winCnt = 0;
        int loseCnt = 0;
        int drawCnt = 0;

        float winPercent = 0.00f;

        string[] choices = { "가위", "바위", "보" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            scissorsBtn.BackColor =  gameValue[0]  ? scissorsBtn.BackColor = Color.Lime : scissorsBtn.BackColor = Color.Transparent;
            rockBtn.BackColor = gameValue[1] ? rockBtn.BackColor = Color.Lime : rockBtn.BackColor = Color.Transparent;
            wrapperBtn.BackColor = gameValue[2] ? wrapperBtn.BackColor = Color.Lime : wrapperBtn.BackColor = Color.Transparent;

            winCntLabel.Text = winCnt.ToString();
            loseCntLabel.Text = loseCnt.ToString();
            drawCntLabel.Text = drawCnt.ToString();

            twingkle = !twingkle;

            if (runGame)
            {
                countLabel.Text = count.ToString();

                if (twingkle)
                    resultLabel.Text = "두근두근";
                else
                    resultLabel.Text = "두근";
            }
            else
            {
                if (!resetGame)
                    return;

                resetGame = false;
                countLabel.Text = "Ready!!!";
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            //게임 정지상태면 return
            if (runGame == false)
                return;

            //카운트다운 3 2 1
            count--;

            //카운트가 0이 되면 아래 코드 실행
            if (count != 0)
                return;

            //게임 정지상태로 변경해서  아래 코드는 한번 실행되고 위에서 막힐거임
            runGame = false;

            //랜덤 값을 구하고 각 값에 따른 결과 도출
            switch (GetRandomTranslation())
            {
                case Translation.Scissors:
                    countLabel.Text = "가위!!";
                    checkResult("가위");
                    
                    break;
                case Translation.Rock:
                    countLabel.Text = "바위!!";
                    checkResult("바위");

                    break;
                case Translation.Wrapper:
                    countLabel.Text = "보!!";
                    checkResult("보");

                    break;
                default:
                    Console.WriteLine("알 수 없는 값입니다.");
                    break;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "두근두근";
            winCnt = 0;
            loseCnt = 0;
            drawCnt = 0;

            resetGame = true;
            allBtnEnableT();
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            gameValue[1] = false;
            gameValue[2] = false;

            gameValue[0] = true;
            allBtnEnableF();
            gameStart();
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            gameValue[0] = false;
            gameValue[2] = false;

            gameValue[1] = true;
            allBtnEnableF();
            gameStart();
        }

        private void wrapperBtn_Click(object sender, EventArgs e)
        {
            gameValue[0] = false;
            gameValue[1] = false;

            gameValue[2] = true;
            allBtnEnableF();
            gameStart();
        }

        //랜덤결과 배출
        static Translation GetRandomTranslation()
        {
            // Random 객체 생성
            Random random = new Random();

            // Enum.GetValues 메서드를 사용하여 enum의 모든 값 가져오기
            Translation[] translations = (Translation[])Enum.GetValues(typeof(Translation));

            // 배열에서 랜덤하게 하나의 값 선택
            Translation randomTranslation = translations[random.Next(translations.Length)];

            return randomTranslation;
        }

        //결과 확인
        void checkResult(string value)
        {
            
            int userIndex = 0;

            for (int i = 0; i < gameValue.Count(); i++)
            {
                if (gameValue[i])
                    userIndex = i;
            }

            string userValue = choices[userIndex];

            if (userValue == value)
            {
                resultLabel.Text = "무승부~";
                drawCnt++;
            }

            else if ((userIndex + 1) % 3 == Array.IndexOf(choices, value))
            {
                resultLabel.Text = "패배..ㅜ";
                loseCnt++;
            }
            else
            {
                resultLabel.Text = "승리!!";
                winCnt++;
            }
            //승률
            winPercent = winCnt / ((float)drawCnt + (float)loseCnt + (float)winCnt) * 100;
            percentLabel.Text = winPercent.ToString("0") + "%";

            allBtnEnableT();
        }

        //모든 버튼 비활성화
        void allBtnEnableF()
        {
            scissorsBtn.Enabled = false;
            rockBtn.Enabled = false;
            wrapperBtn.Enabled = false;
        }

        //모든 버튼 활성화
        void allBtnEnableT()
        {
            scissorsBtn.Enabled = true;
            rockBtn.Enabled = true;
            wrapperBtn.Enabled = true;
        }

        //게임 시작
        void gameStart()
        {
            for (int i = 0; i < gameValue.Count(); i++)
            {
                if (gameValue[i])
                {
                    hasTrue = true;
                    break;
                }
            }

            if (!hasTrue)
            {
                MessageBox.Show("모든 값이 false입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            count = 3;

            hasTrue = false;
            runGame = true;
        }
    }
}
