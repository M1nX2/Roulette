namespace Roulette
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            label1 = new Label();
            textBoxNamePlayer = new TextBox();
            buttonLoad = new Button();
            buttonLeaderBoard = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(577, 288);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(132, 65);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Начать новую игру";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 88);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Ваше имя:";
            // 
            // textBoxNamePlayer
            // 
            textBoxNamePlayer.Location = new Point(178, 133);
            textBoxNamePlayer.Name = "textBoxNamePlayer";
            textBoxNamePlayer.Size = new Size(326, 27);
            textBoxNamePlayer.TabIndex = 2;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(577, 43);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(132, 65);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Загрузить игру";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonLeaderBoard
            // 
            buttonLeaderBoard.Location = new Point(43, 353);
            buttonLeaderBoard.Name = "buttonLeaderBoard";
            buttonLeaderBoard.Size = new Size(123, 48);
            buttonLeaderBoard.TabIndex = 4;
            buttonLeaderBoard.Text = "Таблица лидеров";
            buttonLeaderBoard.UseVisualStyleBackColor = true;
            buttonLeaderBoard.Click += buttonLeaderBoard_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLeaderBoard);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxNamePlayer);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Name = "FormRegister";
            Text = "Регистрация";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label label1;
        private TextBox textBoxNamePlayer;
        private Button buttonLoad;
        private Button buttonLeaderBoard;
    }
}