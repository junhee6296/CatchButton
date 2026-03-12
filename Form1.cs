using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {

        // 버튼 위치 난수 생성기
        private Random random_position = new Random();

        // 3단계 부터 추가되는 변수 정의
        private int score = 0;           // 현재 점수
        private double escapeChance = 0.2; // 도망 확률 설정
        private int missCount = 0;       // 놓친 횟수

        public Form1()
        {
            InitializeComponent();
        }

        private void Running_button_MouseEnter(object sender, EventArgs e)
        {
            //오클릭 20번 이상 = 게임오버
            if (missCount >= 20)
            {
                GameOver();
                return;
            }

            // 도망 확률 계산
            if (random_position.NextDouble() > escapeChance) return;

            //일단 먼저 버튼이 폼 안에서만 움직이도록 최대값을 구해보기
            int maxX = Math.Max(0, ClientSize.Width - Running_button.Width);
            int maxY = Math.Max(0, ClientSize.Height - Running_button.Height);
            //math.max로 창 크기를 줄였을 때 오류가 발생하는 것 예방하기

            //랜덤위치를 정의하기
            int nextX = random_position.Next(0, maxX);
            int nextY = random_position.Next(0, maxY);

            // 버튼을 새로운 랜덤 위치로 이동하기
            Running_button.Location = new Point(nextX, nextY);

            // 점수 계산 (도망쳐서 감점되는 부분)
            score -= 10;
            missCount++;

            // 도망 소리
            SoundPlayer run = new SoundPlayer(@"C:\Windows\Media\Windows Notify Messaging.wav");
            run.Play();

            //폼 제목 버튼 위치로 정의하기
            Text = $"점수: {score} | 버튼 위치: ({nextX}, {nextY})";
        }

        private void Running_button_Click(object sender, EventArgs e)
        {
            // 잡았을 때 점수
            score += 100;

            // 성공 후 난이도 상승!
            escapeChance = Math.Min(1.0, escapeChance + 0.05); // 도망 확률 5% 상승

            // 버튼의 크기 10%씩 감소
            Running_button.Width = (int)(Running_button.Width * 0.9);
            Running_button.Height = (int)(Running_button.Height * 0.9);

            //폰트 크기도 작아지게 해서 글자 잘림 방지
            float newFontSize = Running_button.Font.Size * 0.9f;
            if (newFontSize < 2.0f) newFontSize = 2.0f;
            Running_button.Font = new Font(Running_button.Font.FontFamily, newFontSize);

            // 클리어 효과음
            SoundPlayer clear = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
            clear.Play();

            // 성공 메시지 박스 및 제목 수정
            Text = $"점수: {score} | 성공! 난이도 상승!";
            MessageBox.Show($"축하합니다~! (현재 점수: {score})");

        }
        private void Resetbutton(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            Running_button.Enabled = false; // 도망가는 버튼 비활성화
            Running_button.Visible = false; // 비주얼적 수정으로 인한 비활성화

            // 리셋 버튼을 화면에 다시 나타나게 함
            Reset_button.Visible = true;

            MessageBox.Show($"Game Over\n 20번 놓쳐서 게임오버 되셨습니다. \n재도전하시려면 '재도전'버튼을 누르세요! \n 최종 점수는 {score} 점입니다. ");
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //버튼 재활성화
            Running_button.Enabled = true;
            Running_button.Visible = true;

            // 게임 초기화
            score = 0;
            missCount = 0;
            escapeChance = 0.2;

            //버튼 크기 및 폰트 복구
            Running_button.Size = new Size(384, 120);
            float defaultFontSize = 26.25f;
            Running_button.Font = new Font("서울남산 장체 M", defaultFontSize);

            //"현재 창 크기 기준" 가운데로 첫 버튼이 발현되도록 함
            int centerX = (ClientSize.Width - Running_button.Width) / 2;
            int centerY = (ClientSize.Height - Running_button.Height) / 2;
            Running_button.Location = new Point(centerX, centerY);

            //재도전 제목
            Text = "다시 시작! 버튼을 잡아보세요.";

            //재도전 버튼 비활성화
            Reset_button.Visible = false;
        }
    }
}
