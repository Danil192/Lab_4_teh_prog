namespace MediaVendingMachine
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
            btnLoad = new Button();
            btnGetMedia = new Button();
            txtInfo = new RichTextBox();
            txtQueue = new RichTextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbFilm = new Label();
            lbSerial = new Label();
            lbTV = new Label();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 184);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(368, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Загрузить фильмы, сериалы и телепередачи";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // btnGetMedia
            // 
            btnGetMedia.Location = new Point(402, 184);
            btnGetMedia.Name = "btnGetMedia";
            btnGetMedia.Size = new Size(247, 29);
            btnGetMedia.TabIndex = 1;
            btnGetMedia.Text = "Получить";
            btnGetMedia.UseVisualStyleBackColor = true;
            btnGetMedia.Click += btnGetMedia_Click_1;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(12, 219);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(637, 73);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // txtQueue
            // 
            txtQueue.Location = new Point(12, 298);
            txtQueue.Name = "txtQueue";
            txtQueue.Size = new Size(637, 299);
            txtQueue.TabIndex = 3;
            txtQueue.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 41);
            label1.TabIndex = 4;
            label1.Text = "ЛАБОРАТОРНАЯ РАБОТА №4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 66);
            label4.Name = "label4";
            label4.Size = new Size(122, 38);
            label4.TabIndex = 6;
            label4.Text = "Фильмы";
            //label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 66);
            label2.Name = "label2";
            label2.Size = new Size(130, 38);
            label2.TabIndex = 7;
            label2.Text = "Сериалы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(393, 66);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 8;
            label3.Text = "Телепередачи";
            // 
            // lbFilm
            // 
            lbFilm.AutoSize = true;
            lbFilm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbFilm.Location = new Point(130, 124);
            lbFilm.Name = "lbFilm";
            lbFilm.Size = new Size(26, 31);
            lbFilm.TabIndex = 9;
            lbFilm.Text = "0";
            // 
            // lbSerial
            // 
            lbSerial.AutoSize = true;
            lbSerial.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbSerial.Location = new Point(293, 124);
            lbSerial.Name = "lbSerial";
            lbSerial.Size = new Size(26, 31);
            lbSerial.TabIndex = 10;
            lbSerial.Text = "0";
            // 
            // lbTV
            // 
            lbTV.AutoSize = true;
            lbTV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbTV.Location = new Point(480, 124);
            lbTV.Name = "lbTV";
            lbTV.Size = new Size(26, 31);
            lbTV.TabIndex = 11;
            lbTV.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 609);
            Controls.Add(lbTV);
            Controls.Add(lbSerial);
            Controls.Add(lbFilm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtQueue);
            Controls.Add(txtInfo);
            Controls.Add(btnGetMedia);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Принципы наследования";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnGetMedia;
        private RichTextBox txtInfo;
        private RichTextBox txtQueue;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label lbFilm;
        private Label lbSerial;
        private Label lbTV;
    }
}