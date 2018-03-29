using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcessMonitoring
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usersSetingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showTipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showVideoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.instrumentsMenu,
            this.tipMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.saveMenu,
            this.saveAsMenu,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(162, 22);
            this.openMenu.Text = "Открыть";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(162, 22);
            this.saveMenu.Text = "Сохранить";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(162, 22);
            this.saveAsMenu.Text = "Сохранить как...";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(162, 22);
            this.exitMenu.Text = "Выход";
            // 
            // instrumentsMenu
            // 
            this.instrumentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsMenu,
            this.settingsMenu,
            this.changeUserMenu,
            this.usersSetingsMenu});
            this.instrumentsMenu.Name = "instrumentsMenu";
            this.instrumentsMenu.Size = new System.Drawing.Size(95, 20);
            this.instrumentsMenu.Text = "Инструменты";
            // 
            // pluginsMenu
            // 
            this.pluginsMenu.Name = "pluginsMenu";
            this.pluginsMenu.Size = new System.Drawing.Size(219, 22);
            this.pluginsMenu.Text = "Плагины";
            // 
            // settingsMenu
            // 
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(219, 22);
            this.settingsMenu.Text = "Настройки";
            this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
            // 
            // changeUserMenu
            // 
            this.changeUserMenu.Name = "changeUserMenu";
            this.changeUserMenu.Size = new System.Drawing.Size(219, 22);
            this.changeUserMenu.Text = "Сменить пользователя";
            this.changeUserMenu.Click += new System.EventHandler(this.changeUserMenu_Click);
            // 
            // usersSetingsMenu
            // 
            this.usersSetingsMenu.Name = "usersSetingsMenu";
            this.usersSetingsMenu.Size = new System.Drawing.Size(219, 22);
            this.usersSetingsMenu.Text = "Настройки пользователей";
            this.usersSetingsMenu.Click += new System.EventHandler(this.usersSetingsMenu_Click);
            // 
            // tipMenu
            // 
            this.tipMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTipMenu,
            this.showVideoMenu,
            this.aboutProgramMenu});
            this.tipMenu.Name = "tipMenu";
            this.tipMenu.Size = new System.Drawing.Size(65, 20);
            this.tipMenu.Text = "Справка";
            // 
            // showTipMenu
            // 
            this.showTipMenu.Name = "showTipMenu";
            this.showTipMenu.Size = new System.Drawing.Size(231, 22);
            this.showTipMenu.Text = "Посмотреть справку";
            // 
            // showVideoMenu
            // 
            this.showVideoMenu.Name = "showVideoMenu";
            this.showVideoMenu.Size = new System.Drawing.Size(231, 22);
            this.showVideoMenu.Text = "Посмотреть видео процесса";
            // 
            // aboutProgramMenu
            // 
            this.aboutProgramMenu.Name = "aboutProgramMenu";
            this.aboutProgramMenu.Size = new System.Drawing.Size(231, 22);
            this.aboutProgramMenu.Text = "О программе";
            // 
            // plot
            // 
            this.plot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plot.Legends.Add(legend1);
            this.plot.Location = new System.Drawing.Point(0, 27);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(1104, 521);
            this.plot.TabIndex = 1;
            this.plot.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 545);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Process Monitoring";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem instrumentsMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart plot;
        private ToolStripMenuItem saveMenu;
        private ToolStripMenuItem saveAsMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem pluginsMenu;
        private ToolStripMenuItem settingsMenu;
        private ToolStripMenuItem changeUserMenu;
        private ToolStripMenuItem usersSetingsMenu;
        private ToolStripMenuItem tipMenu;
        private ToolStripMenuItem showTipMenu;
        private ToolStripMenuItem showVideoMenu;
        private ToolStripMenuItem aboutProgramMenu;
    }
}

