namespace CatchButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Running_button = new Button();
            Reset_button = new Button();
            SuspendLayout();
            // 
            // Running_button
            // 
            Running_button.BackColor = SystemColors.ActiveCaption;
            Running_button.Font = new Font("서울남산 장체 M", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Running_button.ForeColor = Color.LightYellow;
            Running_button.Location = new Point(190, 165);
            Running_button.Name = "Running_button";
            Running_button.Size = new Size(384, 120);
            Running_button.TabIndex = 0;
            Running_button.Text = "나를 잡아봐";
            Running_button.UseVisualStyleBackColor = false;
            Running_button.Click += Running_button_Click;
            Running_button.MouseEnter += Running_button_MouseEnter;
            // 
            // Reset_button
            // 
            Reset_button.FlatStyle = FlatStyle.Flat;
            Reset_button.Font = new Font("서울남산 장체 M", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Reset_button.Location = new Point(86, 183);
            Reset_button.Name = "Reset_button";
            Reset_button.Size = new Size(621, 93);
            Reset_button.TabIndex = 1;
            Reset_button.Text = "재도전 (점수 초기화됨)";
            Reset_button.UseVisualStyleBackColor = true;
            Reset_button.Visible = false;
            Reset_button.Click += Resetbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset_button);
            Controls.Add(Running_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Running_button;
        private Button Reset_button;
    }
}
