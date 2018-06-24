namespace Задача_11_в_формах
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.OpenMatrix = new System.Windows.Forms.Button();
            this.OpenString = new System.Windows.Forms.Button();
            this.OutEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutDecrypt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FAQ = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Crypt = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenMatrix
            // 
            this.OpenMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenMatrix.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenMatrix.Location = new System.Drawing.Point(13, 27);
            this.OpenMatrix.Name = "OpenMatrix";
            this.OpenMatrix.Size = new System.Drawing.Size(471, 39);
            this.OpenMatrix.TabIndex = 0;
            this.OpenMatrix.Text = "Загрузить матрицу-ключ";
            this.OpenMatrix.UseVisualStyleBackColor = true;
            this.OpenMatrix.Click += new System.EventHandler(this.OpenMatrix_Click);
            // 
            // OpenString
            // 
            this.OpenString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenString.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenString.Location = new System.Drawing.Point(13, 72);
            this.OpenString.Name = "OpenString";
            this.OpenString.Size = new System.Drawing.Size(471, 39);
            this.OpenString.TabIndex = 1;
            this.OpenString.Text = "Загрузить строку для шифрования";
            this.OpenString.UseVisualStyleBackColor = true;
            this.OpenString.Click += new System.EventHandler(this.OpenString_Click);
            // 
            // OutEncrypt
            // 
            this.OutEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutEncrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutEncrypt.Location = new System.Drawing.Point(13, 179);
            this.OutEncrypt.Name = "OutEncrypt";
            this.OutEncrypt.ReadOnly = true;
            this.OutEncrypt.Size = new System.Drawing.Size(471, 20);
            this.OutEncrypt.TabIndex = 2;
            this.OutEncrypt.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Зашифрованная последовательность:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расшифрованная последовательность:";
            // 
            // OutDecrypt
            // 
            this.OutDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutDecrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutDecrypt.Location = new System.Drawing.Point(13, 222);
            this.OutDecrypt.Name = "OutDecrypt";
            this.OutDecrypt.ReadOnly = true;
            this.OutDecrypt.Size = new System.Drawing.Size(471, 20);
            this.OutDecrypt.TabIndex = 3;
            this.OutDecrypt.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FAQ,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FAQ
            // 
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(65, 20);
            this.FAQ.Text = "Справка";
            this.FAQ.ToolTipText = "0";
            this.FAQ.Click += new System.EventHandler(this.FAQ_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 20);
            this.Exit.Text = "Выход";
            this.Exit.ToolTipText = "1";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Crypt
            // 
            this.Crypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Crypt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Crypt.Location = new System.Drawing.Point(13, 117);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(471, 39);
            this.Crypt.TabIndex = 3;
            this.Crypt.Text = "Зашифровать/расшифровать строку";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(13, 248);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(471, 39);
            this.Save.TabIndex = 4;
            this.Save.Text = "Сохранить результат";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 297);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.OutDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutEncrypt);
            this.Controls.Add(this.OpenString);
            this.Controls.Add(this.OpenMatrix);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Решётка Кардано";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenMatrix;
        private System.Windows.Forms.Button OpenString;
        private System.Windows.Forms.TextBox OutEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FAQ;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button Save;
    }
}

