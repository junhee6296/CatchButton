namespace CatchButton
{
    public partial class Form1 : Form
    {

        // 버튼 위치 난수 생성기
        private Random random_position = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Running_button_MouseEnter(object sender, EventArgs e)
        {
            //일단 먼저 버튼이 폼 안에서만 움직이도록 최대값을 구해보기
            int maxX = Math.Max(0, ClientSize.Width - Running_button.Width);
            int maxY = Math.Max(0, ClientSize.Height - Running_button.Height);
            //math.max로 창 크기를 줄였을 때 오류가 발생하는 것 예방하기

            //랜덤위치를 정의하기
            int nextX = random_position.Next(0, maxX);
            int nextY = random_position.Next(0, maxY);

            // 버튼을 새로운 랜덤 위치로 이동하기
            Running_button.Location = new Point(nextX, nextY);

            //폼 제목 버튼 위치로 정의하기
            Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
