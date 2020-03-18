﻿namespace ShineController
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.updateStationsTimer = new System.Windows.Forms.Timer(this.components);
            this.lbxStations = new System.Windows.Forms.ListBox();
            this.btnRequestRegistration = new System.Windows.Forms.Button();
            this.btnSendColor = new System.Windows.Forms.Button();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.tbrIntensity = new System.Windows.Forms.TrackBar();
            this.btnRestartStationController = new System.Windows.Forms.Button();
            this.tbxLocalPort = new System.Windows.Forms.TextBox();
            this.tbxRemotePort = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLaunchMusicAnalyzer = new System.Windows.Forms.Button();
            this.lbxAudioDevices = new System.Windows.Forms.ListBox();
            this.btnEnableMusic = new System.Windows.Forms.Button();
            this.btnDisableMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // updateStationsTimer
            // 
            this.updateStationsTimer.Enabled = true;
            this.updateStationsTimer.Tick += new System.EventHandler(this.updateStationsTimer_Tick);
            // 
            // lbxStations
            // 
            this.lbxStations.FormattingEnabled = true;
            this.lbxStations.ItemHeight = 16;
            this.lbxStations.Location = new System.Drawing.Point(224, 12);
            this.lbxStations.Name = "lbxStations";
            this.lbxStations.Size = new System.Drawing.Size(189, 212);
            this.lbxStations.TabIndex = 0;
            // 
            // btnRequestRegistration
            // 
            this.btnRequestRegistration.Location = new System.Drawing.Point(224, 231);
            this.btnRequestRegistration.Name = "btnRequestRegistration";
            this.btnRequestRegistration.Size = new System.Drawing.Size(189, 52);
            this.btnRequestRegistration.TabIndex = 1;
            this.btnRequestRegistration.Text = "request registration";
            this.btnRequestRegistration.UseVisualStyleBackColor = true;
            this.btnRequestRegistration.Click += new System.EventHandler(this.btnRequestRegistration_Click);
            // 
            // btnSendColor
            // 
            this.btnSendColor.Location = new System.Drawing.Point(420, 231);
            this.btnSendColor.Name = "btnSendColor";
            this.btnSendColor.Size = new System.Drawing.Size(153, 52);
            this.btnSendColor.TabIndex = 2;
            this.btnSendColor.Text = "send";
            this.btnSendColor.UseVisualStyleBackColor = true;
            this.btnSendColor.Click += new System.EventHandler(this.btnSendColor_Click);
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(420, 129);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(153, 24);
            this.cbxColor.TabIndex = 3;
            // 
            // tbrIntensity
            // 
            this.tbrIntensity.LargeChange = 8;
            this.tbrIntensity.Location = new System.Drawing.Point(420, 168);
            this.tbrIntensity.Maximum = 255;
            this.tbrIntensity.Name = "tbrIntensity";
            this.tbrIntensity.Size = new System.Drawing.Size(153, 56);
            this.tbrIntensity.TabIndex = 4;
            // 
            // btnRestartStationController
            // 
            this.btnRestartStationController.Location = new System.Drawing.Point(12, 234);
            this.btnRestartStationController.Name = "btnRestartStationController";
            this.btnRestartStationController.Size = new System.Drawing.Size(206, 49);
            this.btnRestartStationController.TabIndex = 5;
            this.btnRestartStationController.Text = "Restart StationController";
            this.btnRestartStationController.UseVisualStyleBackColor = true;
            this.btnRestartStationController.Click += new System.EventHandler(this.btnRestartStationController_Click);
            // 
            // tbxLocalPort
            // 
            this.tbxLocalPort.Location = new System.Drawing.Point(12, 205);
            this.tbxLocalPort.Name = "tbxLocalPort";
            this.tbxLocalPort.Size = new System.Drawing.Size(100, 22);
            this.tbxLocalPort.TabIndex = 6;
            this.tbxLocalPort.Text = "5000";
            // 
            // tbxRemotePort
            // 
            this.tbxRemotePort.Location = new System.Drawing.Point(118, 205);
            this.tbxRemotePort.Name = "tbxRemotePort";
            this.tbxRemotePort.Size = new System.Drawing.Size(100, 22);
            this.tbxRemotePort.TabIndex = 7;
            this.tbxRemotePort.Text = "5000";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(12, 156);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(206, 22);
            this.tbxIP.TabIndex = 8;
            this.tbxIP.Text = "192.168.4.255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Broadcast ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "local port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "remote port";
            // 
            // btnLaunchMusicAnalyzer
            // 
            this.btnLaunchMusicAnalyzer.Location = new System.Drawing.Point(579, 231);
            this.btnLaunchMusicAnalyzer.Name = "btnLaunchMusicAnalyzer";
            this.btnLaunchMusicAnalyzer.Size = new System.Drawing.Size(153, 52);
            this.btnLaunchMusicAnalyzer.TabIndex = 12;
            this.btnLaunchMusicAnalyzer.Text = "Launch MusicAnalyzer";
            this.btnLaunchMusicAnalyzer.UseVisualStyleBackColor = true;
            this.btnLaunchMusicAnalyzer.Click += new System.EventHandler(this.btnLaunchMusicAnalyzer_Click);
            // 
            // lbxAudioDevices
            // 
            this.lbxAudioDevices.FormattingEnabled = true;
            this.lbxAudioDevices.ItemHeight = 16;
            this.lbxAudioDevices.Location = new System.Drawing.Point(579, 12);
            this.lbxAudioDevices.Name = "lbxAudioDevices";
            this.lbxAudioDevices.Size = new System.Drawing.Size(153, 116);
            this.lbxAudioDevices.TabIndex = 13;
            // 
            // btnEnableMusic
            // 
            this.btnEnableMusic.Location = new System.Drawing.Point(580, 136);
            this.btnEnableMusic.Name = "btnEnableMusic";
            this.btnEnableMusic.Size = new System.Drawing.Size(152, 42);
            this.btnEnableMusic.TabIndex = 14;
            this.btnEnableMusic.Text = "Enable";
            this.btnEnableMusic.UseVisualStyleBackColor = true;
            this.btnEnableMusic.Click += new System.EventHandler(this.btnEnableMusic_Click);
            // 
            // btnDisableMusic
            // 
            this.btnDisableMusic.Location = new System.Drawing.Point(579, 183);
            this.btnDisableMusic.Name = "btnDisableMusic";
            this.btnDisableMusic.Size = new System.Drawing.Size(152, 42);
            this.btnDisableMusic.TabIndex = 15;
            this.btnDisableMusic.Text = "Disable";
            this.btnDisableMusic.UseVisualStyleBackColor = true;
            this.btnDisableMusic.Click += new System.EventHandler(this.btnDisableMusic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 311);
            this.Controls.Add(this.btnDisableMusic);
            this.Controls.Add(this.btnEnableMusic);
            this.Controls.Add(this.lbxAudioDevices);
            this.Controls.Add(this.btnLaunchMusicAnalyzer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.tbxRemotePort);
            this.Controls.Add(this.tbxLocalPort);
            this.Controls.Add(this.btnRestartStationController);
            this.Controls.Add(this.tbrIntensity);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.btnSendColor);
            this.Controls.Add(this.btnRequestRegistration);
            this.Controls.Add(this.lbxStations);
            this.Name = "MainForm";
            this.Text = "Shine!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateStationsTimer;
        private System.Windows.Forms.ListBox lbxStations;
        private System.Windows.Forms.Button btnRequestRegistration;
        private System.Windows.Forms.Button btnSendColor;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.TrackBar tbrIntensity;
        private System.Windows.Forms.Button btnRestartStationController;
        private System.Windows.Forms.TextBox tbxLocalPort;
        private System.Windows.Forms.TextBox tbxRemotePort;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLaunchMusicAnalyzer;
        private System.Windows.Forms.ListBox lbxAudioDevices;
        private System.Windows.Forms.Button btnEnableMusic;
        private System.Windows.Forms.Button btnDisableMusic;
    }
}

