namespace HostSettingsEditor
{
    partial class HostEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostEditor));
            imposterlabel = new PictureBox();
            ImposterLabels = new PictureBox();
            KillcooldownBox = new PictureBox();
            KillCooldownValue = new RichTextBox();
            ChangeKill = new PictureBox();
            ImposterVisionValue = new RichTextBox();
            ImposterVisionBox = new PictureBox();
            ChangeImpVision = new PictureBox();
            CrewLabel = new PictureBox();
            CrewLabels = new PictureBox();
            PlayerSpeedValue = new RichTextBox();
            PlayerSpeedBox = new PictureBox();
            ChangePlayerSpeed = new PictureBox();
            ChangeCrewVision = new PictureBox();
            CrewVisionValue = new RichTextBox();
            CrewVisionBox = new PictureBox();
            MeetingLabel = new PictureBox();
            MeetingsLabels = new PictureBox();
            ChangeMeetings = new PictureBox();
            MeetingValue = new RichTextBox();
            pictureBox2 = new PictureBox();
            MeetingsLabels2 = new PictureBox();
            ChangeEmerCooldown = new PictureBox();
            EmerCooldownValue = new RichTextBox();
            EmerCooldownBox = new PictureBox();
            ChangeDiscussionTime = new PictureBox();
            DiscussionTimeValue = new RichTextBox();
            DiscussionTimeBox = new PictureBox();
            ChangeVotingTime = new PictureBox();
            VotingTimeValue = new RichTextBox();
            VotingTimeBox = new PictureBox();
            ChangedConfirm = new Label();
            ((System.ComponentModel.ISupportInitialize)imposterlabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImposterLabels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KillcooldownBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeKill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImposterVisionBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeImpVision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrewLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrewLabels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerSpeedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangePlayerSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeCrewVision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CrewVisionBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MeetingLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MeetingsLabels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeMeetings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MeetingsLabels2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeEmerCooldown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmerCooldownBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeDiscussionTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiscussionTimeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChangeVotingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VotingTimeBox).BeginInit();
            SuspendLayout();
            // 
            // imposterlabel
            // 
            imposterlabel.Image = Properties.Resources.imposterlabel;
            imposterlabel.Location = new Point(12, 12);
            imposterlabel.Name = "imposterlabel";
            imposterlabel.Size = new Size(505, 80);
            imposterlabel.TabIndex = 0;
            imposterlabel.TabStop = false;
            // 
            // ImposterLabels
            // 
            ImposterLabels.Image = Properties.Resources.imposterlabels;
            ImposterLabels.Location = new Point(12, 98);
            ImposterLabels.Name = "ImposterLabels";
            ImposterLabels.Size = new Size(249, 144);
            ImposterLabels.TabIndex = 1;
            ImposterLabels.TabStop = false;
            // 
            // KillcooldownBox
            // 
            KillcooldownBox.Image = Properties.Resources.killcooldownbox1;
            KillcooldownBox.Location = new Point(276, 109);
            KillcooldownBox.Name = "KillcooldownBox";
            KillcooldownBox.Size = new Size(139, 57);
            KillcooldownBox.TabIndex = 2;
            KillcooldownBox.TabStop = false;
            // 
            // KillCooldownValue
            // 
            KillCooldownValue.BackColor = Color.FromArgb(16, 16, 16);
            KillCooldownValue.BorderStyle = BorderStyle.None;
            KillCooldownValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KillCooldownValue.ForeColor = Color.White;
            KillCooldownValue.Location = new Point(327, 119);
            KillCooldownValue.MaxLength = 6;
            KillCooldownValue.Name = "KillCooldownValue";
            KillCooldownValue.ScrollBars = RichTextBoxScrollBars.None;
            KillCooldownValue.Size = new Size(69, 31);
            KillCooldownValue.TabIndex = 3;
            KillCooldownValue.Text = "20";
            KillCooldownValue.TextChanged += KillCooldownValue_TextChanged;
            // 
            // ChangeKill
            // 
            ChangeKill.Cursor = Cursors.Hand;
            ChangeKill.Image = Properties.Resources.editbuttonwhite;
            ChangeKill.Location = new Point(421, 104);
            ChangeKill.Name = "ChangeKill";
            ChangeKill.Size = new Size(59, 66);
            ChangeKill.TabIndex = 4;
            ChangeKill.TabStop = false;
            ChangeKill.Click += ChangeKill_Click;
            ChangeKill.MouseDown += ChangeKill_MouseDown;
            ChangeKill.MouseEnter += ChangeKill_MouseEnter;
            ChangeKill.MouseLeave += ChangeKill_MouseLeave;
            ChangeKill.MouseUp += ChangeKill_MouseUp;
            // 
            // ImposterVisionValue
            // 
            ImposterVisionValue.BackColor = Color.FromArgb(16, 16, 16);
            ImposterVisionValue.BorderStyle = BorderStyle.None;
            ImposterVisionValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ImposterVisionValue.ForeColor = Color.White;
            ImposterVisionValue.Location = new Point(335, 182);
            ImposterVisionValue.MaxLength = 6;
            ImposterVisionValue.Name = "ImposterVisionValue";
            ImposterVisionValue.ScrollBars = RichTextBoxScrollBars.None;
            ImposterVisionValue.Size = new Size(63, 31);
            ImposterVisionValue.TabIndex = 6;
            ImposterVisionValue.Text = "5";
            ImposterVisionValue.TextChanged += ImposterVisionValue_TextChanged;
            // 
            // ImposterVisionBox
            // 
            ImposterVisionBox.Image = Properties.Resources.killcooldownbox1;
            ImposterVisionBox.Location = new Point(276, 172);
            ImposterVisionBox.Name = "ImposterVisionBox";
            ImposterVisionBox.Size = new Size(139, 57);
            ImposterVisionBox.TabIndex = 5;
            ImposterVisionBox.TabStop = false;
            // 
            // ChangeImpVision
            // 
            ChangeImpVision.Cursor = Cursors.Hand;
            ChangeImpVision.Image = Properties.Resources.editbuttonwhite;
            ChangeImpVision.Location = new Point(421, 167);
            ChangeImpVision.Name = "ChangeImpVision";
            ChangeImpVision.Size = new Size(59, 66);
            ChangeImpVision.TabIndex = 7;
            ChangeImpVision.TabStop = false;
            ChangeImpVision.Click += ChangeImpVision_Click;
            ChangeImpVision.MouseDown += ChangeImpVision_MouseDown;
            ChangeImpVision.MouseEnter += ChangeImpVision_MouseEnter;
            ChangeImpVision.MouseLeave += ChangeImpVision_MouseLeave;
            ChangeImpVision.MouseUp += ChangeImpVision_MouseUp;
            // 
            // CrewLabel
            // 
            CrewLabel.Image = Properties.Resources.CrewLabel;
            CrewLabel.Location = new Point(523, 12);
            CrewLabel.Name = "CrewLabel";
            CrewLabel.Size = new Size(500, 80);
            CrewLabel.TabIndex = 8;
            CrewLabel.TabStop = false;
            // 
            // CrewLabels
            // 
            CrewLabels.Image = Properties.Resources.CrewLabels;
            CrewLabels.Location = new Point(523, 98);
            CrewLabels.Name = "CrewLabels";
            CrewLabels.Size = new Size(249, 144);
            CrewLabels.TabIndex = 9;
            CrewLabels.TabStop = false;
            // 
            // PlayerSpeedValue
            // 
            PlayerSpeedValue.BackColor = Color.FromArgb(16, 16, 16);
            PlayerSpeedValue.BorderStyle = BorderStyle.None;
            PlayerSpeedValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerSpeedValue.ForeColor = Color.White;
            PlayerSpeedValue.Location = new Point(833, 119);
            PlayerSpeedValue.MaxLength = 6;
            PlayerSpeedValue.Name = "PlayerSpeedValue";
            PlayerSpeedValue.ScrollBars = RichTextBoxScrollBars.None;
            PlayerSpeedValue.Size = new Size(75, 31);
            PlayerSpeedValue.TabIndex = 11;
            PlayerSpeedValue.Text = "1.25";
            PlayerSpeedValue.TextChanged += PlayerSpeedValue_TextChanged;
            // 
            // PlayerSpeedBox
            // 
            PlayerSpeedBox.Image = Properties.Resources.killcooldownbox1;
            PlayerSpeedBox.Location = new Point(790, 109);
            PlayerSpeedBox.Name = "PlayerSpeedBox";
            PlayerSpeedBox.Size = new Size(139, 57);
            PlayerSpeedBox.TabIndex = 10;
            PlayerSpeedBox.TabStop = false;
            // 
            // ChangePlayerSpeed
            // 
            ChangePlayerSpeed.Cursor = Cursors.Hand;
            ChangePlayerSpeed.Image = Properties.Resources.editbuttonwhite;
            ChangePlayerSpeed.Location = new Point(935, 105);
            ChangePlayerSpeed.Name = "ChangePlayerSpeed";
            ChangePlayerSpeed.Size = new Size(59, 66);
            ChangePlayerSpeed.TabIndex = 12;
            ChangePlayerSpeed.TabStop = false;
            ChangePlayerSpeed.Click += ChangePlayerSpeed_Click;
            ChangePlayerSpeed.MouseDown += ChangePlayerSpeed_MouseDown;
            ChangePlayerSpeed.MouseEnter += ChangePlayerSpeed_MouseEnter;
            ChangePlayerSpeed.MouseLeave += ChangePlayerSpeed_MouseLeave;
            ChangePlayerSpeed.MouseUp += ChangePlayerSpeed_MouseUp;
            // 
            // ChangeCrewVision
            // 
            ChangeCrewVision.Cursor = Cursors.Hand;
            ChangeCrewVision.Image = Properties.Resources.editbuttonwhite;
            ChangeCrewVision.Location = new Point(935, 169);
            ChangeCrewVision.Name = "ChangeCrewVision";
            ChangeCrewVision.Size = new Size(59, 66);
            ChangeCrewVision.TabIndex = 15;
            ChangeCrewVision.TabStop = false;
            ChangeCrewVision.Click += ChangeCrewVision_Click;
            ChangeCrewVision.MouseDown += ChangeCrewVision_MouseDown;
            ChangeCrewVision.MouseEnter += ChangeCrewVision_MouseEnter;
            ChangeCrewVision.MouseLeave += ChangeCrewVision_MouseLeave;
            ChangeCrewVision.MouseUp += ChangeCrewVision_MouseUp;
            // 
            // CrewVisionValue
            // 
            CrewVisionValue.BackColor = Color.FromArgb(16, 16, 16);
            CrewVisionValue.BorderStyle = BorderStyle.None;
            CrewVisionValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrewVisionValue.ForeColor = Color.White;
            CrewVisionValue.Location = new Point(833, 183);
            CrewVisionValue.MaxLength = 6;
            CrewVisionValue.Name = "CrewVisionValue";
            CrewVisionValue.ScrollBars = RichTextBoxScrollBars.None;
            CrewVisionValue.Size = new Size(75, 31);
            CrewVisionValue.TabIndex = 14;
            CrewVisionValue.Text = "1.75";
            CrewVisionValue.TextChanged += CrewVisionValue_TextChanged;
            // 
            // CrewVisionBox
            // 
            CrewVisionBox.Image = Properties.Resources.killcooldownbox1;
            CrewVisionBox.Location = new Point(790, 173);
            CrewVisionBox.Name = "CrewVisionBox";
            CrewVisionBox.Size = new Size(139, 57);
            CrewVisionBox.TabIndex = 13;
            CrewVisionBox.TabStop = false;
            // 
            // MeetingLabel
            // 
            MeetingLabel.Image = Properties.Resources.MeetingsLabel1;
            MeetingLabel.Location = new Point(12, 248);
            MeetingLabel.Name = "MeetingLabel";
            MeetingLabel.Size = new Size(1011, 80);
            MeetingLabel.TabIndex = 16;
            MeetingLabel.TabStop = false;
            // 
            // MeetingsLabels
            // 
            MeetingsLabels.Image = Properties.Resources.MeetingsLabels;
            MeetingsLabels.Location = new Point(12, 334);
            MeetingsLabels.Name = "MeetingsLabels";
            MeetingsLabels.Size = new Size(300, 144);
            MeetingsLabels.TabIndex = 17;
            MeetingsLabels.TabStop = false;
            // 
            // ChangeMeetings
            // 
            ChangeMeetings.Cursor = Cursors.Hand;
            ChangeMeetings.Image = Properties.Resources.editbuttonwhite;
            ChangeMeetings.Location = new Point(458, 338);
            ChangeMeetings.Name = "ChangeMeetings";
            ChangeMeetings.Size = new Size(59, 66);
            ChangeMeetings.TabIndex = 20;
            ChangeMeetings.TabStop = false;
            ChangeMeetings.Click += ChangeMeetings_Click;
            ChangeMeetings.MouseDown += ChangeMeetings_MouseDown;
            ChangeMeetings.MouseEnter += ChangeMeetings_MouseEnter;
            ChangeMeetings.MouseLeave += ChangeMeetings_MouseLeave;
            ChangeMeetings.MouseUp += ChangeMeetings_MouseUp;
            // 
            // MeetingValue
            // 
            MeetingValue.BackColor = Color.FromArgb(16, 16, 16);
            MeetingValue.BorderStyle = BorderStyle.None;
            MeetingValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MeetingValue.ForeColor = Color.White;
            MeetingValue.Location = new Point(372, 353);
            MeetingValue.MaxLength = 6;
            MeetingValue.Name = "MeetingValue";
            MeetingValue.ScrollBars = RichTextBoxScrollBars.None;
            MeetingValue.Size = new Size(63, 31);
            MeetingValue.TabIndex = 19;
            MeetingValue.Text = "1";
            MeetingValue.TextChanged += MeetingValue_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.killcooldownbox1;
            pictureBox2.Location = new Point(313, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 57);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // MeetingsLabels2
            // 
            MeetingsLabels2.Image = Properties.Resources.MeetingsLabel2;
            MeetingsLabels2.Location = new Point(523, 338);
            MeetingsLabels2.Name = "MeetingsLabels2";
            MeetingsLabels2.Size = new Size(249, 144);
            MeetingsLabels2.TabIndex = 21;
            MeetingsLabels2.TabStop = false;
            // 
            // ChangeEmerCooldown
            // 
            ChangeEmerCooldown.Cursor = Cursors.Hand;
            ChangeEmerCooldown.Image = Properties.Resources.editbuttonwhite;
            ChangeEmerCooldown.Location = new Point(458, 407);
            ChangeEmerCooldown.Name = "ChangeEmerCooldown";
            ChangeEmerCooldown.Size = new Size(59, 66);
            ChangeEmerCooldown.TabIndex = 24;
            ChangeEmerCooldown.TabStop = false;
            ChangeEmerCooldown.Click += ChangeEmerCooldown_Click;
            ChangeEmerCooldown.MouseDown += ChangeEmerCooldown_MouseDown;
            ChangeEmerCooldown.MouseEnter += ChangeEmerCooldown_MouseEnter;
            ChangeEmerCooldown.MouseLeave += ChangeEmerCooldown_MouseLeave;
            ChangeEmerCooldown.MouseUp += ChangeEmerCooldown_MouseUp;
            // 
            // EmerCooldownValue
            // 
            EmerCooldownValue.BackColor = Color.FromArgb(16, 16, 16);
            EmerCooldownValue.BorderStyle = BorderStyle.None;
            EmerCooldownValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmerCooldownValue.ForeColor = Color.White;
            EmerCooldownValue.Location = new Point(364, 422);
            EmerCooldownValue.MaxLength = 6;
            EmerCooldownValue.Name = "EmerCooldownValue";
            EmerCooldownValue.ScrollBars = RichTextBoxScrollBars.None;
            EmerCooldownValue.Size = new Size(75, 31);
            EmerCooldownValue.TabIndex = 23;
            EmerCooldownValue.Text = "20";
            EmerCooldownValue.TextChanged += EmerCooldownValue_TextChanged;
            // 
            // EmerCooldownBox
            // 
            EmerCooldownBox.Image = Properties.Resources.killcooldownbox1;
            EmerCooldownBox.Location = new Point(313, 412);
            EmerCooldownBox.Name = "EmerCooldownBox";
            EmerCooldownBox.Size = new Size(139, 57);
            EmerCooldownBox.TabIndex = 22;
            EmerCooldownBox.TabStop = false;
            // 
            // ChangeDiscussionTime
            // 
            ChangeDiscussionTime.Cursor = Cursors.Hand;
            ChangeDiscussionTime.Image = Properties.Resources.editbuttonwhite;
            ChangeDiscussionTime.Location = new Point(935, 344);
            ChangeDiscussionTime.Name = "ChangeDiscussionTime";
            ChangeDiscussionTime.Size = new Size(59, 66);
            ChangeDiscussionTime.TabIndex = 27;
            ChangeDiscussionTime.TabStop = false;
            ChangeDiscussionTime.Click += ChangeDiscussionTime_Click;
            ChangeDiscussionTime.MouseDown += ChangeDiscussionTime_MouseDown;
            ChangeDiscussionTime.MouseEnter += ChangeDiscussionTime_MouseEnter;
            ChangeDiscussionTime.MouseLeave += ChangeDiscussionTime_MouseLeave;
            ChangeDiscussionTime.MouseUp += ChangeDiscussionTime_MouseUp;
            // 
            // DiscussionTimeValue
            // 
            DiscussionTimeValue.BackColor = Color.FromArgb(16, 16, 16);
            DiscussionTimeValue.BorderStyle = BorderStyle.None;
            DiscussionTimeValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscussionTimeValue.ForeColor = Color.White;
            DiscussionTimeValue.Location = new Point(841, 359);
            DiscussionTimeValue.MaxLength = 6;
            DiscussionTimeValue.Name = "DiscussionTimeValue";
            DiscussionTimeValue.ScrollBars = RichTextBoxScrollBars.None;
            DiscussionTimeValue.Size = new Size(75, 31);
            DiscussionTimeValue.TabIndex = 26;
            DiscussionTimeValue.Text = "15";
            DiscussionTimeValue.TextChanged += DiscussionTimeValue_TextChanged;
            // 
            // DiscussionTimeBox
            // 
            DiscussionTimeBox.Image = Properties.Resources.killcooldownbox1;
            DiscussionTimeBox.Location = new Point(790, 349);
            DiscussionTimeBox.Name = "DiscussionTimeBox";
            DiscussionTimeBox.Size = new Size(139, 57);
            DiscussionTimeBox.TabIndex = 25;
            DiscussionTimeBox.TabStop = false;
            // 
            // ChangeVotingTime
            // 
            ChangeVotingTime.Cursor = Cursors.Hand;
            ChangeVotingTime.Image = Properties.Resources.editbuttonwhite;
            ChangeVotingTime.Location = new Point(935, 407);
            ChangeVotingTime.Name = "ChangeVotingTime";
            ChangeVotingTime.Size = new Size(59, 66);
            ChangeVotingTime.TabIndex = 30;
            ChangeVotingTime.TabStop = false;
            ChangeVotingTime.Click += ChangeVotingTime_Click;
            ChangeVotingTime.MouseDown += ChangeVotingTime_MouseDown;
            ChangeVotingTime.MouseEnter += ChangeVotingTime_MouseEnter;
            ChangeVotingTime.MouseLeave += ChangeVotingTime_MouseLeave;
            ChangeVotingTime.MouseUp += ChangeVotingTime_MouseUp;
            // 
            // VotingTimeValue
            // 
            VotingTimeValue.BackColor = Color.FromArgb(16, 16, 16);
            VotingTimeValue.BorderStyle = BorderStyle.None;
            VotingTimeValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VotingTimeValue.ForeColor = Color.White;
            VotingTimeValue.Location = new Point(833, 422);
            VotingTimeValue.MaxLength = 6;
            VotingTimeValue.Name = "VotingTimeValue";
            VotingTimeValue.ScrollBars = RichTextBoxScrollBars.None;
            VotingTimeValue.Size = new Size(75, 31);
            VotingTimeValue.TabIndex = 29;
            VotingTimeValue.Text = "120";
            VotingTimeValue.TextChanged += VotingTimeValue_TextChanged;
            // 
            // VotingTimeBox
            // 
            VotingTimeBox.Image = Properties.Resources.killcooldownbox1;
            VotingTimeBox.Location = new Point(790, 412);
            VotingTimeBox.Name = "VotingTimeBox";
            VotingTimeBox.Size = new Size(139, 57);
            VotingTimeBox.TabIndex = 28;
            VotingTimeBox.TabStop = false;
            // 
            // ChangedConfirm
            // 
            ChangedConfirm.AutoSize = true;
            ChangedConfirm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangedConfirm.ForeColor = Color.White;
            ChangedConfirm.Location = new Point(327, 497);
            ChangedConfirm.Name = "ChangedConfirm";
            ChangedConfirm.Size = new Size(418, 30);
            ChangedConfirm.TabIndex = 31;
            ChangedConfirm.Text = "The Value has Been Changed Successfully";
            ChangedConfirm.Visible = false;
            // 
            // HostEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 16, 16);
            ClientSize = new Size(1035, 536);
            Controls.Add(ChangedConfirm);
            Controls.Add(ChangeVotingTime);
            Controls.Add(VotingTimeValue);
            Controls.Add(VotingTimeBox);
            Controls.Add(ChangeDiscussionTime);
            Controls.Add(DiscussionTimeValue);
            Controls.Add(DiscussionTimeBox);
            Controls.Add(ChangeEmerCooldown);
            Controls.Add(EmerCooldownValue);
            Controls.Add(EmerCooldownBox);
            Controls.Add(MeetingsLabels2);
            Controls.Add(ChangeMeetings);
            Controls.Add(MeetingValue);
            Controls.Add(pictureBox2);
            Controls.Add(MeetingsLabels);
            Controls.Add(MeetingLabel);
            Controls.Add(ChangeCrewVision);
            Controls.Add(CrewVisionValue);
            Controls.Add(CrewVisionBox);
            Controls.Add(ChangePlayerSpeed);
            Controls.Add(PlayerSpeedValue);
            Controls.Add(PlayerSpeedBox);
            Controls.Add(CrewLabels);
            Controls.Add(CrewLabel);
            Controls.Add(ChangeImpVision);
            Controls.Add(ImposterVisionValue);
            Controls.Add(ImposterVisionBox);
            Controls.Add(ChangeKill);
            Controls.Add(KillCooldownValue);
            Controls.Add(KillcooldownBox);
            Controls.Add(ImposterLabels);
            Controls.Add(imposterlabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HostEditor";
            RightToLeft = RightToLeft.No;
            Text = "HostEditor";
            Load += HostEditor_Load;
            ((System.ComponentModel.ISupportInitialize)imposterlabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImposterLabels).EndInit();
            ((System.ComponentModel.ISupportInitialize)KillcooldownBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeKill).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImposterVisionBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeImpVision).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrewLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrewLabels).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerSpeedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangePlayerSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeCrewVision).EndInit();
            ((System.ComponentModel.ISupportInitialize)CrewVisionBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MeetingLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)MeetingsLabels).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeMeetings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MeetingsLabels2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeEmerCooldown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmerCooldownBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeDiscussionTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiscussionTimeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChangeVotingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)VotingTimeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imposterlabel;
        private PictureBox ImposterLabels;
        private PictureBox KillcooldownBox;
        private RichTextBox KillCooldownValue;
        private PictureBox ChangeKill;
        private RichTextBox ImposterVisionValue;
        private PictureBox ImposterVisionBox;
        private PictureBox ChangeImpVision;
        private PictureBox CrewLabel;
        private PictureBox CrewLabels;
        private RichTextBox PlayerSpeedValue;
        private PictureBox PlayerSpeedBox;
        private PictureBox ChangePlayerSpeed;
        private PictureBox ChangeCrewVision;
        private RichTextBox CrewVisionValue;
        private PictureBox CrewVisionBox;
        private PictureBox MeetingLabel;
        private PictureBox MeetingsLabels;
        private PictureBox ChangeMeetings;
        private RichTextBox MeetingValue;
        private PictureBox pictureBox2;
        private PictureBox MeetingsLabels2;
        private PictureBox ChangeEmerCooldown;
        private RichTextBox EmerCooldownValue;
        private PictureBox EmerCooldownBox;
        private PictureBox ChangeDiscussionTime;
        private RichTextBox DiscussionTimeValue;
        private PictureBox DiscussionTimeBox;
        private PictureBox ChangeVotingTime;
        private RichTextBox VotingTimeValue;
        private PictureBox VotingTimeBox;
        private Label ChangedConfirm;
    }
}