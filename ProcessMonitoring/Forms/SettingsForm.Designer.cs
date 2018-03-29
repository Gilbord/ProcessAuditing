namespace ProcessMonitoring.Forms
{
    partial class SettingsForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plotColor = new System.Windows.Forms.PictureBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.pathToPlugins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPathToPlugins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plotColor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(197, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(155, 15);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(117, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Подпись оси абсцисс";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(155, 41);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(116, 13);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Подпись оси ординат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет графика";
            // 
            // plotColor
            // 
            this.plotColor.Location = new System.Drawing.Point(12, 71);
            this.plotColor.Name = "plotColor";
            this.plotColor.Size = new System.Drawing.Size(100, 20);
            this.plotColor.TabIndex = 5;
            this.plotColor.TabStop = false;
            this.plotColor.Click += new System.EventHandler(this.plotColor_Click);
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(12, 38);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 20);
            this.textY.TabIndex = 6;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(12, 12);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 20);
            this.textX.TabIndex = 7;
            // 
            // pathToPlugins
            // 
            this.pathToPlugins.Location = new System.Drawing.Point(12, 147);
            this.pathToPlugins.Name = "pathToPlugins";
            this.pathToPlugins.Size = new System.Drawing.Size(221, 20);
            this.pathToPlugins.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Путь к плагинам(.dll)";
            // 
            // buttonPathToPlugins
            // 
            this.buttonPathToPlugins.Location = new System.Drawing.Point(243, 145);
            this.buttonPathToPlugins.Name = "buttonPathToPlugins";
            this.buttonPathToPlugins.Size = new System.Drawing.Size(28, 23);
            this.buttonPathToPlugins.TabIndex = 10;
            this.buttonPathToPlugins.Text = "...";
            this.buttonPathToPlugins.UseVisualStyleBackColor = true;
            this.buttonPathToPlugins.Click += new System.EventHandler(this.buttonPathToPlugins_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonPathToPlugins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathToPlugins);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.plotColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.plotColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox plotColor;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox pathToPlugins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPathToPlugins;
    }
}