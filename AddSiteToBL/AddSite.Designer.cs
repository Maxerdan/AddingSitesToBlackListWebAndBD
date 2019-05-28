namespace AddSiteToBL
{
    partial class AddSite
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
            this.adressBox = new System.Windows.Forms.TextBox();
            this.adressPublBox = new System.Windows.Forms.TextBox();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.violationBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PublishMightDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addScreenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adressBox
            // 
            this.adressBox.Location = new System.Drawing.Point(118, 6);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(268, 20);
            this.adressBox.TabIndex = 0;
            // 
            // adressPublBox
            // 
            this.adressPublBox.Location = new System.Drawing.Point(118, 32);
            this.adressPublBox.Name = "adressPublBox";
            this.adressPublBox.Size = new System.Drawing.Size(268, 20);
            this.adressPublBox.TabIndex = 1;
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(118, 138);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(268, 107);
            this.reasonBox.TabIndex = 2;
            // 
            // violationBox
            // 
            this.violationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.violationBox.FormattingEnabled = true;
            this.violationBox.Items.AddRange(new object[] {
            "Экстремизм",
            "Угрозы к свержению власти",
            "Нарушение авторских прав",
            "Нарушение тайны частной жизни",
            "Раскрытие гостайны"});
            this.violationBox.Location = new System.Drawing.Point(118, 58);
            this.violationBox.Name = "violationBox";
            this.violationBox.Size = new System.Drawing.Size(268, 21);
            this.violationBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес сайта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес публикации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Причина";
            // 
            // PublishMightDateBox
            // 
            this.PublishMightDateBox.Location = new System.Drawing.Point(232, 85);
            this.PublishMightDateBox.Name = "PublishMightDateBox";
            this.PublishMightDateBox.Size = new System.Drawing.Size(154, 20);
            this.PublishMightDateBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Комментарий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Возможная дата публикации";
            // 
            // sendButton
            // 
            this.sendButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sendButton.Location = new System.Drawing.Point(297, 413);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(89, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // addScreenButton
            // 
            this.addScreenButton.Location = new System.Drawing.Point(12, 251);
            this.addScreenButton.Name = "addScreenButton";
            this.addScreenButton.Size = new System.Drawing.Size(100, 43);
            this.addScreenButton.TabIndex = 14;
            this.addScreenButton.Text = "Добавить скриншот";
            this.addScreenButton.UseVisualStyleBackColor = true;
            this.addScreenButton.Click += new System.EventHandler(this.addScreenButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус сайта";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Работает",
            "Заблокирован",
            "Не отвечает"});
            this.comboBox1.Location = new System.Drawing.Point(118, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // AddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 449);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addScreenButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PublishMightDateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.violationBox);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.adressPublBox);
            this.Controls.Add(this.adressBox);
            this.Name = "AddSite";
            this.Text = "AddSite";
            this.Load += new System.EventHandler(this.AddSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.TextBox adressPublBox;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.ComboBox violationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PublishMightDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addScreenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}