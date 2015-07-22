namespace Word_Counter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnalysis.Enabled = false;
            this.btnAnalysis.Location = new System.Drawing.Point(14, 67);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(121, 23);
            this.btnAnalysis.TabIndex = 0;
            this.btnAnalysis.Text = "Analisar arquivo";
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(227, 39);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(426, 20);
            this.textFile.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(659, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe o arquivo a ser pesquisado:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(14, 127);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(718, 208);
            this.txtResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ocorrência das palavras no arquivo";
            // 
            // btnClipboard
            // 
            this.btnClipboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClipboard.Enabled = false;
            this.btnClipboard.Location = new System.Drawing.Point(15, 355);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(231, 23);
            this.btnClipboard.TabIndex = 7;
            this.btnClipboard.Text = "Copiar análise para área de transferência";
            this.btnClipboard.UseVisualStyleBackColor = false;
            this.btnClipboard.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 390);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.btnAnalysis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClipboard;
    }
}

