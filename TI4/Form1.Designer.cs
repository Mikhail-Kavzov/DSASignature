
namespace TI4
{
    partial class DSAForm
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
            this.qTB = new System.Windows.Forms.TextBox();
            this.pTB = new System.Windows.Forms.TextBox();
            this.hTB = new System.Windows.Forms.TextBox();
            this.xTB = new System.Windows.Forms.TextBox();
            this.kTB = new System.Windows.Forms.TextBox();
            this.QLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            this.HashTB = new System.Windows.Forms.TextBox();
            this.HashLabel = new System.Windows.Forms.Label();
            this.DigestLabel = new System.Windows.Forms.Label();
            this.DigestTB = new System.Windows.Forms.TextBox();
            this.BtnFile = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.BtnSignSignature = new System.Windows.Forms.Button();
            this.BtnCheckSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qTB
            // 
            this.qTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.qTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qTB.Location = new System.Drawing.Point(12, 53);
            this.qTB.Name = "qTB";
            this.qTB.Size = new System.Drawing.Size(208, 38);
            this.qTB.TabIndex = 0;
            // 
            // pTB
            // 
            this.pTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTB.Location = new System.Drawing.Point(12, 142);
            this.pTB.Name = "pTB";
            this.pTB.Size = new System.Drawing.Size(208, 38);
            this.pTB.TabIndex = 1;
            // 
            // hTB
            // 
            this.hTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTB.Location = new System.Drawing.Point(12, 237);
            this.hTB.Name = "hTB";
            this.hTB.Size = new System.Drawing.Size(208, 38);
            this.hTB.TabIndex = 2;
            // 
            // xTB
            // 
            this.xTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.xTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xTB.Location = new System.Drawing.Point(12, 339);
            this.xTB.Name = "xTB";
            this.xTB.Size = new System.Drawing.Size(208, 38);
            this.xTB.TabIndex = 3;
            // 
            // kTB
            // 
            this.kTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTB.Location = new System.Drawing.Point(12, 415);
            this.kTB.Name = "kTB";
            this.kTB.Size = new System.Drawing.Size(208, 38);
            this.kTB.TabIndex = 4;
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QLabel.Location = new System.Drawing.Point(12, 18);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(45, 32);
            this.QLabel.TabIndex = 5;
            this.QLabel.Text = "Q:";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLabel.Location = new System.Drawing.Point(12, 107);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(42, 32);
            this.PLabel.TabIndex = 6;
            this.PLabel.Text = "P:";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HLabel.Location = new System.Drawing.Point(12, 194);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(39, 32);
            this.HLabel.TabIndex = 7;
            this.HLabel.Text = "h:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XLabel.Location = new System.Drawing.Point(9, 291);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(42, 32);
            this.XLabel.TabIndex = 8;
            this.XLabel.Text = "X:";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KLabel.Location = new System.Drawing.Point(9, 380);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(42, 32);
            this.KLabel.TabIndex = 9;
            this.KLabel.Text = "K:";
            // 
            // HashTB
            // 
            this.HashTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HashTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashTB.Location = new System.Drawing.Point(644, 88);
            this.HashTB.Name = "HashTB";
            this.HashTB.Size = new System.Drawing.Size(235, 38);
            this.HashTB.TabIndex = 10;
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashLabel.Location = new System.Drawing.Point(638, 41);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(235, 32);
            this.HashLabel.TabIndex = 11;
            this.HashLabel.Text = "Хеш сообщения:";
            // 
            // DigestLabel
            // 
            this.DigestLabel.AutoSize = true;
            this.DigestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DigestLabel.Location = new System.Drawing.Point(991, 41);
            this.DigestLabel.Name = "DigestLabel";
            this.DigestLabel.Size = new System.Drawing.Size(84, 32);
            this.DigestLabel.TabIndex = 12;
            this.DigestLabel.Text = "ЭЦП:";
            // 
            // DigestTB
            // 
            this.DigestTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DigestTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DigestTB.Location = new System.Drawing.Point(997, 88);
            this.DigestTB.Name = "DigestTB";
            this.DigestTB.Size = new System.Drawing.Size(245, 38);
            this.DigestTB.TabIndex = 13;
            // 
            // BtnFile
            // 
            this.BtnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFile.Location = new System.Drawing.Point(997, 161);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(245, 65);
            this.BtnFile.TabIndex = 14;
            this.BtnFile.Text = "Выбрать файл";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "All files(*.*)|*.*";
            // 
            // BtnSignSignature
            // 
            this.BtnSignSignature.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSignSignature.Enabled = false;
            this.BtnSignSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSignSignature.Location = new System.Drawing.Point(997, 258);
            this.BtnSignSignature.Name = "BtnSignSignature";
            this.BtnSignSignature.Size = new System.Drawing.Size(245, 65);
            this.BtnSignSignature.TabIndex = 15;
            this.BtnSignSignature.Text = "Подписать файл";
            this.BtnSignSignature.UseVisualStyleBackColor = false;
            this.BtnSignSignature.Click += new System.EventHandler(this.BtnSignSignature_Click);
            // 
            // BtnCheckSignature
            // 
            this.BtnCheckSignature.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckSignature.Enabled = false;
            this.BtnCheckSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCheckSignature.Location = new System.Drawing.Point(997, 363);
            this.BtnCheckSignature.Name = "BtnCheckSignature";
            this.BtnCheckSignature.Size = new System.Drawing.Size(245, 65);
            this.BtnCheckSignature.TabIndex = 16;
            this.BtnCheckSignature.Text = "Проверить подпись";
            this.BtnCheckSignature.UseVisualStyleBackColor = false;
            this.BtnCheckSignature.Click += new System.EventHandler(this.BtnCheckSignature_Click);
            // 
            // DSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 492);
            this.Controls.Add(this.BtnCheckSignature);
            this.Controls.Add(this.BtnSignSignature);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.DigestTB);
            this.Controls.Add(this.DigestLabel);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.HashTB);
            this.Controls.Add(this.KLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.kTB);
            this.Controls.Add(this.xTB);
            this.Controls.Add(this.hTB);
            this.Controls.Add(this.pTB);
            this.Controls.Add(this.qTB);
            this.Name = "DSAForm";
            this.Text = "DSA ЦП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qTB;
        private System.Windows.Forms.TextBox pTB;
        private System.Windows.Forms.TextBox hTB;
        private System.Windows.Forms.TextBox xTB;
        private System.Windows.Forms.TextBox kTB;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.TextBox HashTB;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.Label DigestLabel;
        private System.Windows.Forms.TextBox DigestTB;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button BtnSignSignature;
        private System.Windows.Forms.Button BtnCheckSignature;
    }
}

