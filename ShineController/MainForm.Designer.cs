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
            this.btnRestartStationController = new System.Windows.Forms.Button();
            this.tbxLocalPort = new System.Windows.Forms.TextBox();
            this.tbxRemotePort = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxAudioDevices = new System.Windows.Forms.ListBox();
            this.btnEnableMusic = new System.Windows.Forms.Button();
            this.btnDisableMusic = new System.Windows.Forms.Button();
            this.tbrRed = new System.Windows.Forms.TrackBar();
            this.tbrGreen = new System.Windows.Forms.TrackBar();
            this.tbrBlue = new System.Windows.Forms.TrackBar();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.lbxAnalyzers = new System.Windows.Forms.ListBox();
            this.btnRemoveAnalyzer = new System.Windows.Forms.Button();
            this.btnAddAnalyzer = new System.Windows.Forms.Button();
            this.lbxAnalyzerStations = new System.Windows.Forms.ListBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.btnRemoveStation = new System.Windows.Forms.Button();
            this.nudMusicProcessorInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSpectrumWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSpectrumdataHistoryLength = new System.Windows.Forms.NumericUpDown();
            this.tbrMinInterstFreq = new System.Windows.Forms.TrackBar();
            this.tbrMaxInterestFreq = new System.Windows.Forms.TrackBar();
            this.btnSetInterestZone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMusicProcessorInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumdataHistoryLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMinInterstFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMaxInterestFreq)).BeginInit();
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
            this.lbxStations.Location = new System.Drawing.Point(227, 12);
            this.lbxStations.Name = "lbxStations";
            this.lbxStations.Size = new System.Drawing.Size(223, 148);
            this.lbxStations.TabIndex = 0;
            // 
            // btnRequestRegistration
            // 
            this.btnRequestRegistration.Location = new System.Drawing.Point(227, 175);
            this.btnRequestRegistration.Name = "btnRequestRegistration";
            this.btnRequestRegistration.Size = new System.Drawing.Size(223, 52);
            this.btnRequestRegistration.TabIndex = 1;
            this.btnRequestRegistration.Text = "request registration";
            this.btnRequestRegistration.UseVisualStyleBackColor = true;
            this.btnRequestRegistration.Click += new System.EventHandler(this.btnRequestRegistration_Click);
            // 
            // btnRestartStationController
            // 
            this.btnRestartStationController.Location = new System.Drawing.Point(15, 233);
            this.btnRestartStationController.Name = "btnRestartStationController";
            this.btnRestartStationController.Size = new System.Drawing.Size(206, 52);
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
            // lbxAudioDevices
            // 
            this.lbxAudioDevices.FormattingEnabled = true;
            this.lbxAudioDevices.ItemHeight = 16;
            this.lbxAudioDevices.Location = new System.Drawing.Point(456, 12);
            this.lbxAudioDevices.Name = "lbxAudioDevices";
            this.lbxAudioDevices.Size = new System.Drawing.Size(194, 148);
            this.lbxAudioDevices.TabIndex = 13;
            // 
            // btnEnableMusic
            // 
            this.btnEnableMusic.Location = new System.Drawing.Point(456, 173);
            this.btnEnableMusic.Name = "btnEnableMusic";
            this.btnEnableMusic.Size = new System.Drawing.Size(194, 52);
            this.btnEnableMusic.TabIndex = 14;
            this.btnEnableMusic.Text = "Enable";
            this.btnEnableMusic.UseVisualStyleBackColor = true;
            this.btnEnableMusic.Click += new System.EventHandler(this.btnEnableMusic_Click);
            // 
            // btnDisableMusic
            // 
            this.btnDisableMusic.Location = new System.Drawing.Point(456, 233);
            this.btnDisableMusic.Name = "btnDisableMusic";
            this.btnDisableMusic.Size = new System.Drawing.Size(194, 52);
            this.btnDisableMusic.TabIndex = 15;
            this.btnDisableMusic.Text = "Disable";
            this.btnDisableMusic.UseVisualStyleBackColor = true;
            this.btnDisableMusic.Click += new System.EventHandler(this.btnDisableMusic_Click);
            // 
            // tbrRed
            // 
            this.tbrRed.LargeChange = 8;
            this.tbrRed.Location = new System.Drawing.Point(657, 345);
            this.tbrRed.Maximum = 255;
            this.tbrRed.Name = "tbrRed";
            this.tbrRed.Size = new System.Drawing.Size(153, 56);
            this.tbrRed.TabIndex = 16;
            this.tbrRed.Value = 254;
            // 
            // tbrGreen
            // 
            this.tbrGreen.LargeChange = 8;
            this.tbrGreen.Location = new System.Drawing.Point(657, 407);
            this.tbrGreen.Maximum = 255;
            this.tbrGreen.Name = "tbrGreen";
            this.tbrGreen.Size = new System.Drawing.Size(153, 56);
            this.tbrGreen.TabIndex = 17;
            this.tbrGreen.Value = 255;
            // 
            // tbrBlue
            // 
            this.tbrBlue.LargeChange = 8;
            this.tbrBlue.Location = new System.Drawing.Point(657, 469);
            this.tbrBlue.Maximum = 255;
            this.tbrBlue.Name = "tbrBlue";
            this.tbrBlue.Size = new System.Drawing.Size(153, 56);
            this.tbrBlue.TabIndex = 18;
            this.tbrBlue.Value = 5;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(657, 531);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(153, 52);
            this.btnSetColor.TabIndex = 19;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // lbxAnalyzers
            // 
            this.lbxAnalyzers.FormattingEnabled = true;
            this.lbxAnalyzers.ItemHeight = 16;
            this.lbxAnalyzers.Location = new System.Drawing.Point(15, 313);
            this.lbxAnalyzers.Name = "lbxAnalyzers";
            this.lbxAnalyzers.Size = new System.Drawing.Size(435, 148);
            this.lbxAnalyzers.TabIndex = 20;
            this.lbxAnalyzers.SelectedIndexChanged += new System.EventHandler(this.lbxAnalyzers_SelectedIndexChanged);
            // 
            // btnRemoveAnalyzer
            // 
            this.btnRemoveAnalyzer.Location = new System.Drawing.Point(15, 532);
            this.btnRemoveAnalyzer.Name = "btnRemoveAnalyzer";
            this.btnRemoveAnalyzer.Size = new System.Drawing.Size(435, 52);
            this.btnRemoveAnalyzer.TabIndex = 21;
            this.btnRemoveAnalyzer.Text = "remove";
            this.btnRemoveAnalyzer.UseVisualStyleBackColor = true;
            this.btnRemoveAnalyzer.Click += new System.EventHandler(this.btnRemoveAnalyzer_Click);
            // 
            // btnAddAnalyzer
            // 
            this.btnAddAnalyzer.Location = new System.Drawing.Point(15, 473);
            this.btnAddAnalyzer.Name = "btnAddAnalyzer";
            this.btnAddAnalyzer.Size = new System.Drawing.Size(435, 52);
            this.btnAddAnalyzer.TabIndex = 23;
            this.btnAddAnalyzer.Text = "Add Analyzer";
            this.btnAddAnalyzer.UseVisualStyleBackColor = true;
            this.btnAddAnalyzer.Click += new System.EventHandler(this.btnAddAnalyzer_Click);
            // 
            // lbxAnalyzerStations
            // 
            this.lbxAnalyzerStations.FormattingEnabled = true;
            this.lbxAnalyzerStations.ItemHeight = 16;
            this.lbxAnalyzerStations.Location = new System.Drawing.Point(456, 313);
            this.lbxAnalyzerStations.Name = "lbxAnalyzerStations";
            this.lbxAnalyzerStations.Size = new System.Drawing.Size(194, 212);
            this.lbxAnalyzerStations.TabIndex = 24;
            this.lbxAnalyzerStations.SelectedIndexChanged += new System.EventHandler(this.lbxAnalyzerStations_SelectedIndexChanged);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(227, 233);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(223, 52);
            this.btnAddStation.TabIndex = 26;
            this.btnAddStation.Text = "add to analyzer";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnRemoveStation
            // 
            this.btnRemoveStation.Location = new System.Drawing.Point(456, 531);
            this.btnRemoveStation.Name = "btnRemoveStation";
            this.btnRemoveStation.Size = new System.Drawing.Size(194, 52);
            this.btnRemoveStation.TabIndex = 27;
            this.btnRemoveStation.Text = "remove";
            this.btnRemoveStation.UseVisualStyleBackColor = true;
            this.btnRemoveStation.Click += new System.EventHandler(this.btnRemoveStation_Click);
            // 
            // nudMusicProcessorInterval
            // 
            this.nudMusicProcessorInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMusicProcessorInterval.Location = new System.Drawing.Point(659, 32);
            this.nudMusicProcessorInterval.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMusicProcessorInterval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMusicProcessorInterval.Name = "nudMusicProcessorInterval";
            this.nudMusicProcessorInterval.Size = new System.Drawing.Size(152, 22);
            this.nudMusicProcessorInterval.TabIndex = 28;
            this.nudMusicProcessorInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMusicProcessorInterval.ValueChanged += new System.EventHandler(this.nudMusicProcessorInterval_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Refresh rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Spectrum width";
            // 
            // nudSpectrumWidth
            // 
            this.nudSpectrumWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpectrumWidth.Location = new System.Drawing.Point(659, 77);
            this.nudSpectrumWidth.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudSpectrumWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSpectrumWidth.Name = "nudSpectrumWidth";
            this.nudSpectrumWidth.Size = new System.Drawing.Size(152, 22);
            this.nudSpectrumWidth.TabIndex = 30;
            this.nudSpectrumWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudSpectrumWidth.ValueChanged += new System.EventHandler(this.nudSpectrumWidth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "SD history length";
            // 
            // nudSpectrumdataHistoryLength
            // 
            this.nudSpectrumdataHistoryLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpectrumdataHistoryLength.Location = new System.Drawing.Point(659, 122);
            this.nudSpectrumdataHistoryLength.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.nudSpectrumdataHistoryLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpectrumdataHistoryLength.Name = "nudSpectrumdataHistoryLength";
            this.nudSpectrumdataHistoryLength.Size = new System.Drawing.Size(152, 22);
            this.nudSpectrumdataHistoryLength.TabIndex = 32;
            this.nudSpectrumdataHistoryLength.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.nudSpectrumdataHistoryLength.ValueChanged += new System.EventHandler(this.nudSpectrumdataHistoryLength_ValueChanged);
            // 
            // tbrMinInterstFreq
            // 
            this.tbrMinInterstFreq.Location = new System.Drawing.Point(816, 407);
            this.tbrMinInterstFreq.Maximum = 64;
            this.tbrMinInterstFreq.Name = "tbrMinInterstFreq";
            this.tbrMinInterstFreq.Size = new System.Drawing.Size(333, 56);
            this.tbrMinInterstFreq.TabIndex = 34;
            // 
            // tbrMaxInterestFreq
            // 
            this.tbrMaxInterestFreq.Location = new System.Drawing.Point(816, 469);
            this.tbrMaxInterestFreq.Maximum = 64;
            this.tbrMaxInterestFreq.Name = "tbrMaxInterestFreq";
            this.tbrMaxInterestFreq.Size = new System.Drawing.Size(333, 56);
            this.tbrMaxInterestFreq.TabIndex = 35;
            this.tbrMaxInterestFreq.Value = 32;
            // 
            // btnSetInterestZone
            // 
            this.btnSetInterestZone.Location = new System.Drawing.Point(816, 529);
            this.btnSetInterestZone.Name = "btnSetInterestZone";
            this.btnSetInterestZone.Size = new System.Drawing.Size(347, 52);
            this.btnSetInterestZone.TabIndex = 36;
            this.btnSetInterestZone.Text = "Set interest values";
            this.btnSetInterestZone.UseVisualStyleBackColor = true;
            this.btnSetInterestZone.Click += new System.EventHandler(this.btnSetInterestZone_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 605);
            this.Controls.Add(this.btnSetInterestZone);
            this.Controls.Add(this.tbrMaxInterestFreq);
            this.Controls.Add(this.tbrMinInterstFreq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudSpectrumdataHistoryLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudSpectrumWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMusicProcessorInterval);
            this.Controls.Add(this.btnRemoveStation);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.lbxAnalyzerStations);
            this.Controls.Add(this.btnAddAnalyzer);
            this.Controls.Add(this.btnRemoveAnalyzer);
            this.Controls.Add(this.lbxAnalyzers);
            this.Controls.Add(this.btnSetColor);
            this.Controls.Add(this.tbrBlue);
            this.Controls.Add(this.tbrGreen);
            this.Controls.Add(this.tbrRed);
            this.Controls.Add(this.btnDisableMusic);
            this.Controls.Add(this.btnEnableMusic);
            this.Controls.Add(this.lbxAudioDevices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.tbxRemotePort);
            this.Controls.Add(this.tbxLocalPort);
            this.Controls.Add(this.btnRestartStationController);
            this.Controls.Add(this.btnRequestRegistration);
            this.Controls.Add(this.lbxStations);
            this.Name = "MainForm";
            this.Text = "Shine!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMusicProcessorInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumdataHistoryLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMinInterstFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMaxInterestFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateStationsTimer;
        private System.Windows.Forms.ListBox lbxStations;
        private System.Windows.Forms.Button btnRequestRegistration;
        private System.Windows.Forms.Button btnRestartStationController;
        private System.Windows.Forms.TextBox tbxLocalPort;
        private System.Windows.Forms.TextBox tbxRemotePort;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxAudioDevices;
        private System.Windows.Forms.Button btnEnableMusic;
        private System.Windows.Forms.Button btnDisableMusic;
        private System.Windows.Forms.TrackBar tbrRed;
        private System.Windows.Forms.TrackBar tbrGreen;
        private System.Windows.Forms.TrackBar tbrBlue;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.ListBox lbxAnalyzers;
        private System.Windows.Forms.Button btnRemoveAnalyzer;
        private System.Windows.Forms.Button btnAddAnalyzer;
        private System.Windows.Forms.ListBox lbxAnalyzerStations;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnRemoveStation;
        private System.Windows.Forms.NumericUpDown nudMusicProcessorInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSpectrumWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSpectrumdataHistoryLength;
        private System.Windows.Forms.TrackBar tbrMinInterstFreq;
        private System.Windows.Forms.TrackBar tbrMaxInterestFreq;
        private System.Windows.Forms.Button btnSetInterestZone;
    }
}

