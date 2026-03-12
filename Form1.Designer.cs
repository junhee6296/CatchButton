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
            SuspendLayout();
            // 
            // Running_button
            // 
            Running_button.BackColor = SystemColors.ActiveCaption;
            Running_button.Font = new Font("서울남산 장체 M", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Running_button.ForeColor = Color.LightYellow;
            Running_button.Location = new Point(284, 186);
            Running_button.Name = "Running_button";
            Running_button.Size = new Size(197, 60);
            Running_button.TabIndex = 0;
            Running_button.Text = "나를 잡아봐";
            Running_button.UseVisualStyleBackColor = false;
            Running_button.Click += Running_button_Click;
            Running_button.MouseEnter += Running_button_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Running_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Running_button;
    }
}
