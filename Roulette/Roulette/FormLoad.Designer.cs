namespace Roulette
{
    partial class FormLoad
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
            comboBoxSaves = new ComboBox();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // comboBoxSaves
            // 
            comboBoxSaves.FormattingEnabled = true;
            comboBoxSaves.Location = new Point(130, 158);
            comboBoxSaves.Name = "comboBoxSaves";
            comboBoxSaves.Size = new Size(326, 28);
            comboBoxSaves.TabIndex = 0;
            comboBoxSaves.SelectedIndexChanged += comboBoxSaves_SelectedIndexChanged;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(585, 158);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 39);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // FormLoad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 322);
            Controls.Add(buttonLoad);
            Controls.Add(comboBoxSaves);
            Name = "FormLoad";
            Text = "Загрузить";
            Load += FormLoad_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxSaves;
        private Button buttonLoad;
    }
}