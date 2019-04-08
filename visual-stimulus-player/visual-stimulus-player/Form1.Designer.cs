namespace visual_stimulus_player
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbSetVedioFile = new System.Windows.Forms.GroupBox();
            this.lblShowVideoTime_1 = new System.Windows.Forms.Label();
            this.btnSetSequenceSave_1 = new System.Windows.Forms.Button();
            this.btnSetSDelete_1 = new System.Windows.Forms.Button();
            this.lbExpSequence_1 = new System.Windows.Forms.ListBox();
            this.btnSetSAdd_1 = new System.Windows.Forms.Button();
            this.lblLastTime_1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPlaySetting = new System.Windows.Forms.GroupBox();
            this.btnSwitchSAndM = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.gbWindowSetting = new System.Windows.Forms.GroupBox();
            this.lblLocationBack = new System.Windows.Forms.Label();
            this.lblLocationFront = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.tbFrontX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBackX = new System.Windows.Forms.TextBox();
            this.tbFrontY = new System.Windows.Forms.TextBox();
            this.tbBackY = new System.Windows.Forms.TextBox();
            this.btnSetLocation = new System.Windows.Forms.Button();
            this.tbSizeBY = new System.Windows.Forms.TextBox();
            this.tbSizeFY = new System.Windows.Forms.TextBox();
            this.tbSizeBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSizeFX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.gbSetVedioFile.SuspendLayout();
            this.gbPlaySetting.SuspendLayout();
            this.gbWindowSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetVedioFile
            // 
            this.gbSetVedioFile.Controls.Add(this.lblShowVideoTime_1);
            this.gbSetVedioFile.Controls.Add(this.btnSetSequenceSave_1);
            this.gbSetVedioFile.Controls.Add(this.btnSetSDelete_1);
            this.gbSetVedioFile.Controls.Add(this.lbExpSequence_1);
            this.gbSetVedioFile.Controls.Add(this.btnSetSAdd_1);
            this.gbSetVedioFile.Controls.Add(this.lblLastTime_1);
            this.gbSetVedioFile.Location = new System.Drawing.Point(28, 26);
            this.gbSetVedioFile.Name = "gbSetVedioFile";
            this.gbSetVedioFile.Size = new System.Drawing.Size(365, 336);
            this.gbSetVedioFile.TabIndex = 23;
            this.gbSetVedioFile.TabStop = false;
            this.gbSetVedioFile.Text = "VideoLoading";
            // 
            // lblShowVideoTime_1
            // 
            this.lblShowVideoTime_1.AutoSize = true;
            this.lblShowVideoTime_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowVideoTime_1.Location = new System.Drawing.Point(274, 101);
            this.lblShowVideoTime_1.Name = "lblShowVideoTime_1";
            this.lblShowVideoTime_1.Size = new System.Drawing.Size(49, 20);
            this.lblShowVideoTime_1.TabIndex = 12;
            this.lblShowVideoTime_1.Text = "NULL";
            // 
            // btnSetSequenceSave_1
            // 
            this.btnSetSequenceSave_1.Location = new System.Drawing.Point(252, 228);
            this.btnSetSequenceSave_1.Name = "btnSetSequenceSave_1";
            this.btnSetSequenceSave_1.Size = new System.Drawing.Size(92, 23);
            this.btnSetSequenceSave_1.TabIndex = 10;
            this.btnSetSequenceSave_1.Text = "Save";
            this.btnSetSequenceSave_1.UseVisualStyleBackColor = true;
            this.btnSetSequenceSave_1.Click += new System.EventHandler(this.btnSetSequenceSave_1_Click);
            // 
            // btnSetSDelete_1
            // 
            this.btnSetSDelete_1.Location = new System.Drawing.Point(253, 183);
            this.btnSetSDelete_1.Name = "btnSetSDelete_1";
            this.btnSetSDelete_1.Size = new System.Drawing.Size(92, 23);
            this.btnSetSDelete_1.TabIndex = 8;
            this.btnSetSDelete_1.Text = "Detele";
            this.btnSetSDelete_1.UseVisualStyleBackColor = true;
            this.btnSetSDelete_1.Click += new System.EventHandler(this.btnSetSDelete_1_Click);
            // 
            // lbExpSequence_1
            // 
            this.lbExpSequence_1.FormattingEnabled = true;
            this.lbExpSequence_1.ItemHeight = 15;
            this.lbExpSequence_1.Location = new System.Drawing.Point(13, 55);
            this.lbExpSequence_1.Name = "lbExpSequence_1";
            this.lbExpSequence_1.Size = new System.Drawing.Size(223, 244);
            this.lbExpSequence_1.TabIndex = 0;
            this.lbExpSequence_1.SelectedValueChanged += new System.EventHandler(this.lbExpSequence_1_SelectedValueChanged);
            // 
            // btnSetSAdd_1
            // 
            this.btnSetSAdd_1.Location = new System.Drawing.Point(253, 140);
            this.btnSetSAdd_1.Name = "btnSetSAdd_1";
            this.btnSetSAdd_1.Size = new System.Drawing.Size(92, 23);
            this.btnSetSAdd_1.TabIndex = 7;
            this.btnSetSAdd_1.Text = "Add";
            this.btnSetSAdd_1.UseVisualStyleBackColor = true;
            this.btnSetSAdd_1.Click += new System.EventHandler(this.btnSetSAdd_1_Click);
            // 
            // lblLastTime_1
            // 
            this.lblLastTime_1.AutoSize = true;
            this.lblLastTime_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastTime_1.Location = new System.Drawing.Point(255, 62);
            this.lblLastTime_1.Name = "lblLastTime_1";
            this.lblLastTime_1.Size = new System.Drawing.Size(89, 20);
            this.lblLastTime_1.TabIndex = 4;
            this.lblLastTime_1.Text = "Duration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPlaySetting
            // 
            this.gbPlaySetting.Controls.Add(this.btnStop);
            this.gbPlaySetting.Controls.Add(this.btnSwitchSAndM);
            this.gbPlaySetting.Controls.Add(this.tbTime);
            this.gbPlaySetting.Controls.Add(this.button1);
            this.gbPlaySetting.Controls.Add(this.lblTime);
            this.gbPlaySetting.Location = new System.Drawing.Point(28, 378);
            this.gbPlaySetting.Name = "gbPlaySetting";
            this.gbPlaySetting.Size = new System.Drawing.Size(365, 176);
            this.gbPlaySetting.TabIndex = 25;
            this.gbPlaySetting.TabStop = false;
            this.gbPlaySetting.Text = "Setting";
            // 
            // btnSwitchSAndM
            // 
            this.btnSwitchSAndM.Location = new System.Drawing.Point(253, 44);
            this.btnSwitchSAndM.Name = "btnSwitchSAndM";
            this.btnSwitchSAndM.Size = new System.Drawing.Size(43, 23);
            this.btnSwitchSAndM.TabIndex = 27;
            this.btnSwitchSAndM.Text = "S";
            this.btnSwitchSAndM.UseVisualStyleBackColor = true;
            this.btnSwitchSAndM.Click += new System.EventHandler(this.btnSwitchSAndM_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(122, 43);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(115, 25);
            this.tbTime.TabIndex = 26;
            this.tbTime.Text = "180";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(61, 48);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 15);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time: ";
            // 
            // gbWindowSetting
            // 
            this.gbWindowSetting.Controls.Add(this.btnSetSize);
            this.gbWindowSetting.Controls.Add(this.tbSizeBY);
            this.gbWindowSetting.Controls.Add(this.tbSizeFY);
            this.gbWindowSetting.Controls.Add(this.tbSizeBX);
            this.gbWindowSetting.Controls.Add(this.label5);
            this.gbWindowSetting.Controls.Add(this.label6);
            this.gbWindowSetting.Controls.Add(this.label7);
            this.gbWindowSetting.Controls.Add(this.label8);
            this.gbWindowSetting.Controls.Add(this.tbSizeFX);
            this.gbWindowSetting.Controls.Add(this.label9);
            this.gbWindowSetting.Controls.Add(this.lblSize);
            this.gbWindowSetting.Controls.Add(this.btnSetLocation);
            this.gbWindowSetting.Controls.Add(this.tbBackY);
            this.gbWindowSetting.Controls.Add(this.tbFrontY);
            this.gbWindowSetting.Controls.Add(this.tbBackX);
            this.gbWindowSetting.Controls.Add(this.label4);
            this.gbWindowSetting.Controls.Add(this.label3);
            this.gbWindowSetting.Controls.Add(this.label2);
            this.gbWindowSetting.Controls.Add(this.label1);
            this.gbWindowSetting.Controls.Add(this.tbFrontX);
            this.gbWindowSetting.Controls.Add(this.lblLocationBack);
            this.gbWindowSetting.Controls.Add(this.lblLocationFront);
            this.gbWindowSetting.Location = new System.Drawing.Point(413, 26);
            this.gbWindowSetting.Name = "gbWindowSetting";
            this.gbWindowSetting.Size = new System.Drawing.Size(358, 531);
            this.gbWindowSetting.TabIndex = 26;
            this.gbWindowSetting.TabStop = false;
            this.gbWindowSetting.Text = "Window-Setting";
            // 
            // lblLocationBack
            // 
            this.lblLocationBack.AutoSize = true;
            this.lblLocationBack.Location = new System.Drawing.Point(46, 119);
            this.lblLocationBack.Name = "lblLocationBack";
            this.lblLocationBack.Size = new System.Drawing.Size(119, 15);
            this.lblLocationBack.TabIndex = 2;
            this.lblLocationBack.Text = "LocationBack: ";
            // 
            // lblLocationFront
            // 
            this.lblLocationFront.AutoSize = true;
            this.lblLocationFront.Location = new System.Drawing.Point(34, 35);
            this.lblLocationFront.Name = "lblLocationFront";
            this.lblLocationFront.Size = new System.Drawing.Size(127, 15);
            this.lblLocationFront.TabIndex = 1;
            this.lblLocationFront.Text = "LocationFront: ";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(64, 93);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 45);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbFrontX
            // 
            this.tbFrontX.Location = new System.Drawing.Point(63, 74);
            this.tbFrontX.Name = "tbFrontX";
            this.tbFrontX.Size = new System.Drawing.Size(100, 25);
            this.tbFrontX.TabIndex = 3;
            this.tbFrontX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // tbBackX
            // 
            this.tbBackX.Location = new System.Drawing.Point(63, 153);
            this.tbBackX.Name = "tbBackX";
            this.tbBackX.Size = new System.Drawing.Size(100, 25);
            this.tbBackX.TabIndex = 8;
            this.tbBackX.Text = "0";
            // 
            // tbFrontY
            // 
            this.tbFrontY.Location = new System.Drawing.Point(200, 74);
            this.tbFrontY.Name = "tbFrontY";
            this.tbFrontY.Size = new System.Drawing.Size(100, 25);
            this.tbFrontY.TabIndex = 9;
            this.tbFrontY.Text = "0";
            // 
            // tbBackY
            // 
            this.tbBackY.Location = new System.Drawing.Point(200, 153);
            this.tbBackY.Name = "tbBackY";
            this.tbBackY.Size = new System.Drawing.Size(100, 25);
            this.tbBackY.TabIndex = 10;
            this.tbBackY.Text = "0";
            // 
            // btnSetLocation
            // 
            this.btnSetLocation.Location = new System.Drawing.Point(143, 204);
            this.btnSetLocation.Name = "btnSetLocation";
            this.btnSetLocation.Size = new System.Drawing.Size(155, 31);
            this.btnSetLocation.TabIndex = 29;
            this.btnSetLocation.Text = "Set";
            this.btnSetLocation.UseVisualStyleBackColor = true;
            this.btnSetLocation.Click += new System.EventHandler(this.btnSetLocation_Click);
            // 
            // tbSizeBY
            // 
            this.tbSizeBY.Location = new System.Drawing.Point(200, 387);
            this.tbSizeBY.Name = "tbSizeBY";
            this.tbSizeBY.Size = new System.Drawing.Size(100, 25);
            this.tbSizeBY.TabIndex = 39;
            this.tbSizeBY.Text = "0";
            // 
            // tbSizeFY
            // 
            this.tbSizeFY.Location = new System.Drawing.Point(200, 308);
            this.tbSizeFY.Name = "tbSizeFY";
            this.tbSizeFY.Size = new System.Drawing.Size(100, 25);
            this.tbSizeFY.TabIndex = 38;
            this.tbSizeFY.Text = "0";
            // 
            // tbSizeBX
            // 
            this.tbSizeBX.Location = new System.Drawing.Point(65, 387);
            this.tbSizeBX.Name = "tbSizeBX";
            this.tbSizeBX.Size = new System.Drawing.Size(100, 25);
            this.tbSizeBX.TabIndex = 37;
            this.tbSizeBX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "X:";
            // 
            // tbSizeFX
            // 
            this.tbSizeFX.Location = new System.Drawing.Point(65, 308);
            this.tbSizeFX.Name = "tbSizeFX";
            this.tbSizeFX.Size = new System.Drawing.Size(100, 25);
            this.tbSizeFX.TabIndex = 32;
            this.tbSizeFX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "LocationBack: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(36, 271);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(47, 15);
            this.lblSize.TabIndex = 30;
            this.lblSize.Text = "Size:";
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(145, 448);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(155, 31);
            this.btnSetSize.TabIndex = 40;
            this.btnSetSize.Text = "Set";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.gbWindowSetting);
            this.Controls.Add(this.gbPlaySetting);
            this.Controls.Add(this.gbSetVedioFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSetVedioFile.ResumeLayout(false);
            this.gbSetVedioFile.PerformLayout();
            this.gbPlaySetting.ResumeLayout(false);
            this.gbPlaySetting.PerformLayout();
            this.gbWindowSetting.ResumeLayout(false);
            this.gbWindowSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetVedioFile;
        private System.Windows.Forms.Label lblShowVideoTime_1;
        private System.Windows.Forms.Button btnSetSequenceSave_1;
        private System.Windows.Forms.Button btnSetSDelete_1;
        private System.Windows.Forms.ListBox lbExpSequence_1;
        private System.Windows.Forms.Button btnSetSAdd_1;
        private System.Windows.Forms.Label lblLastTime_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbPlaySetting;
        private System.Windows.Forms.Button btnSwitchSAndM;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gbWindowSetting;
        private System.Windows.Forms.Label lblLocationBack;
        private System.Windows.Forms.Label lblLocationFront;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.TextBox tbSizeBY;
        private System.Windows.Forms.TextBox tbSizeFY;
        private System.Windows.Forms.TextBox tbSizeBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSizeFX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnSetLocation;
        private System.Windows.Forms.TextBox tbBackY;
        private System.Windows.Forms.TextBox tbFrontY;
        private System.Windows.Forms.TextBox tbBackX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrontX;
    }
}

