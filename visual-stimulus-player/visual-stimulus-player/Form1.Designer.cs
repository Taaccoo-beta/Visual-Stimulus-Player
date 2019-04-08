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
            this.lblTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btnSwitchSAndM = new System.Windows.Forms.Button();
            this.gbWindowSetting = new System.Windows.Forms.GroupBox();
            this.lblLocationFront = new System.Windows.Forms.Label();
            this.lblLocationBack = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.button1.Location = new System.Drawing.Point(61, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPlaySetting
            // 
            this.gbPlaySetting.Controls.Add(this.btnSwitchSAndM);
            this.gbPlaySetting.Controls.Add(this.tbTime);
            this.gbPlaySetting.Controls.Add(this.button1);
            this.gbPlaySetting.Controls.Add(this.lblTime);
            this.gbPlaySetting.Location = new System.Drawing.Point(28, 381);
            this.gbPlaySetting.Name = "gbPlaySetting";
            this.gbPlaySetting.Size = new System.Drawing.Size(365, 176);
            this.gbPlaySetting.TabIndex = 25;
            this.gbPlaySetting.TabStop = false;
            this.gbPlaySetting.Text = "Setting";
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
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(122, 43);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(115, 25);
            this.tbTime.TabIndex = 26;
            this.tbTime.Text = "180";
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
            // gbWindowSetting
            // 
            this.gbWindowSetting.Controls.Add(this.lblLocationBack);
            this.gbWindowSetting.Controls.Add(this.lblLocationFront);
            this.gbWindowSetting.Location = new System.Drawing.Point(413, 26);
            this.gbWindowSetting.Name = "gbWindowSetting";
            this.gbWindowSetting.Size = new System.Drawing.Size(358, 531);
            this.gbWindowSetting.TabIndex = 26;
            this.gbWindowSetting.TabStop = false;
            this.gbWindowSetting.Text = "Window-Setting";
            // 
            // lblLocationFront
            // 
            this.lblLocationFront.AutoSize = true;
            this.lblLocationFront.Location = new System.Drawing.Point(34, 46);
            this.lblLocationFront.Name = "lblLocationFront";
            this.lblLocationFront.Size = new System.Drawing.Size(127, 15);
            this.lblLocationFront.TabIndex = 1;
            this.lblLocationFront.Text = "LocationFront: ";
            // 
            // lblLocationBack
            // 
            this.lblLocationBack.AutoSize = true;
            this.lblLocationBack.Location = new System.Drawing.Point(42, 80);
            this.lblLocationBack.Name = "lblLocationBack";
            this.lblLocationBack.Size = new System.Drawing.Size(119, 15);
            this.lblLocationBack.TabIndex = 2;
            this.lblLocationBack.Text = "LocationBack: ";
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
    }
}

