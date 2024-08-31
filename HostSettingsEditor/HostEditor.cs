using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostSettingsEditor
{
    public partial class HostEditor : Form
    {
        Memory.Mem memory = new Memory.Mem();

        public HostEditor()
        {
            InitializeComponent();
        }

        // ensuring the UI looks reasonably good // goto line 456 for actual code
        private void HostEditor_Load(object sender, EventArgs e)
        {
            //Set default settings
            KillCooldownValue.Text = "20";
            ImposterVisionValue.Text = "5";
            PlayerSpeedValue.Text = "1.25";
            CrewVisionValue.Text = "1.75";
            MeetingValue.Text = "1";
            EmerCooldownValue.Text = "20";
            DiscussionTimeValue.Text = "15";
            VotingTimeValue.Text = "120";
        }
        private void KillCooldownValue_TextChanged(object sender, EventArgs e)
        {
            
            KillCooldownValue.Size = new Size(69, 31);
            KillCooldownValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            KillCooldownValue.Location = new Point(335 - 8 * (KillCooldownValue.TextLength - 1), 119);

            switch (KillCooldownValue.TextLength)
            {
                case 0:
                    KillCooldownValue.Size = new Size(65, 31);
                    break;
                case 5:
                    KillCooldownValue.Location = new Point(313, 122);
                    KillCooldownValue.Size = new Size(69, 30);
                    KillCooldownValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    KillCooldownValue.Location = new Point(312, 123);
                    KillCooldownValue.Size = new Size(69, 28);
                    KillCooldownValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }


        }
        private void PlayerSpeedValue_TextChanged(object sender, EventArgs e)
        {
            
            PlayerSpeedValue.Size = new Size(75, 31);
            PlayerSpeedValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            PlayerSpeedValue.Location = new Point(849 - 8 * (PlayerSpeedValue.TextLength - 1), 119);

            switch (PlayerSpeedValue.TextLength)
            {
                case 0:
                    PlayerSpeedValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    PlayerSpeedValue.Size = new Size(69, 31);
                    break;
                case 5:
                    PlayerSpeedValue.Location = new Point(828, 122);
                    PlayerSpeedValue.Size = new Size(75, 30); 
                    PlayerSpeedValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    PlayerSpeedValue.Location = new Point(827, 123);
                    PlayerSpeedValue.Size = new Size(75, 28); 
                    PlayerSpeedValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void ImposterVisionValue_TextChanged(object sender, EventArgs e)
        {
           
            ImposterVisionValue.Size = new Size(75, 31);
            ImposterVisionValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            ImposterVisionValue.Location = new Point(335 - 8 * (ImposterVisionValue.TextLength - 1), 182);

            switch (ImposterVisionValue.TextLength)
            {
                case 0:
                    ImposterVisionValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    ImposterVisionValue.Size = new Size(69, 31); 
                    break;
                case 5:
                    ImposterVisionValue.Location = new Point(313, 185);
                    ImposterVisionValue.Size = new Size(75, 30); 
                    ImposterVisionValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    ImposterVisionValue.Location = new Point(312, 186);
                    ImposterVisionValue.Size = new Size(75, 28); 
                    ImposterVisionValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void CrewVisionValue_TextChanged(object sender, EventArgs e)
        {
            
            CrewVisionValue.Size = new Size(75, 31);
            CrewVisionValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            CrewVisionValue.Location = new Point(849 - 8 * (CrewVisionValue.TextLength - 1), 183);

            switch (CrewVisionValue.TextLength)
            {
                case 0:
                    CrewVisionValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    CrewVisionValue.Size = new Size(69, 31); 
                    break;
                case 5:
                    CrewVisionValue.Location = new Point(826, 185);
                    CrewVisionValue.Size = new Size(75, 30); 
                    CrewVisionValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    CrewVisionValue.Location = new Point(825, 186);
                    CrewVisionValue.Size = new Size(75, 28); 
                    CrewVisionValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void EmerCooldownValue_TextChanged(object sender, EventArgs e)
        {
            
            EmerCooldownValue.Size = new Size(75, 31);
            EmerCooldownValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            EmerCooldownValue.Location = new Point(372 - 8 * (EmerCooldownValue.TextLength - 1), 422);

            switch (EmerCooldownValue.TextLength)
            {
                case 0:
                    EmerCooldownValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    EmerCooldownValue.Size = new Size(63, 31); 
                    break;
                case 5:
                    EmerCooldownValue.Location = new Point(348, 424);
                    EmerCooldownValue.Size = new Size(75, 30); 
                    EmerCooldownValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    EmerCooldownValue.Location = new Point(347, 425);
                    EmerCooldownValue.Size = new Size(75, 28); 
                    EmerCooldownValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void MeetingValue_TextChanged(object sender, EventArgs e)
        {
            
            MeetingValue.Size = new Size(75, 31);
            MeetingValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            MeetingValue.Location = new Point(372 - 8 * (MeetingValue.TextLength - 1), 353);

            switch (MeetingValue.TextLength)
            {
                case 0:
                    MeetingValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    MeetingValue.Size = new Size(63, 31); 
                    break;
                case 5:
                    MeetingValue.Location = new Point(348, 355);
                    MeetingValue.Size = new Size(75, 30); 
                    MeetingValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    MeetingValue.Location = new Point(347, 356);
                    MeetingValue.Size = new Size(75, 28); 
                    MeetingValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void DiscussionTimeValue_TextChanged(object sender, EventArgs e)
        {
            
            DiscussionTimeValue.Size = new Size(75, 31);
            DiscussionTimeValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            DiscussionTimeValue.Location = new Point(849 - 8 * (DiscussionTimeValue.TextLength - 1), 359);

            switch (DiscussionTimeValue.TextLength)
            {
                case 0:
                    DiscussionTimeValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    DiscussionTimeValue.Size = new Size(63, 31); 
                    break;
                case 5:
                    DiscussionTimeValue.Location = new Point(825, 361);
                    DiscussionTimeValue.Size = new Size(75, 30); 
                    DiscussionTimeValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    DiscussionTimeValue.Location = new Point(824, 362);
                    DiscussionTimeValue.Size = new Size(75, 28); 
                    DiscussionTimeValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void VotingTimeValue_TextChanged(object sender, EventArgs e)
        {
            
            VotingTimeValue.Size = new Size(75, 31);
            VotingTimeValue.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold);
            VotingTimeValue.Location = new Point(849 - 8 * (VotingTimeValue.TextLength - 1), 422);

            switch (VotingTimeValue.TextLength)
            {
                case 0:
                    VotingTimeValue.Size = new Size(65, 31); 
                    break;
                case 1:
                    VotingTimeValue.Size = new Size(63, 31); 
                    break;
                case 5:
                    VotingTimeValue.Location = new Point(825, 424);
                    VotingTimeValue.Size = new Size(75, 30); 
                    VotingTimeValue.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold);
                    break;
                case 6:
                    VotingTimeValue.Location = new Point(824, 425);
                    VotingTimeValue.Size = new Size(75, 28);
                    VotingTimeValue.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
                    break;
            }
        }
        private void ChangeKill_MouseEnter(object sender, EventArgs e)
        {
            ChangeKill.Image = Properties.Resources.editbuttonblue;
            ChangeKill.Refresh();
            ChangeKill.Visible = true;
        }
        private void ChangeKill_MouseLeave(object sender, EventArgs e)
        {
            ChangeKill.Image = Properties.Resources.editbuttonwhite;
            ChangeKill.Refresh();
            ChangeKill.Visible = true;
        }
        private void ChangeKill_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeKill.Image = Properties.Resources.editbuttondownblue;
            ChangeKill.Refresh();
            ChangeKill.Visible = true;
        }
        private void ChangeKill_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeKill.Image = Properties.Resources.editbuttonblue;
            ChangeKill.Refresh();
            ChangeKill.Visible = true;
        }
        private void ChangeImpVision_MouseEnter(object sender, EventArgs e)
        {
            ChangeImpVision.Image = Properties.Resources.editbuttonblue;
            ChangeImpVision.Refresh();
            ChangeImpVision.Visible = true;
        }
        private void ChangeImpVision_MouseLeave(object sender, EventArgs e)
        {
            ChangeImpVision.Image = Properties.Resources.editbuttonwhite;
            ChangeImpVision.Refresh();
            ChangeImpVision.Visible = true;
        }
        private void ChangeImpVision_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeImpVision.Image = Properties.Resources.editbuttondownblue;
            ChangeImpVision.Refresh();
            ChangeImpVision.Visible = true;
        }
        private void ChangeImpVision_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeImpVision.Image = Properties.Resources.editbuttonblue;
            ChangeImpVision.Refresh();
            ChangeImpVision.Visible = true;
        }
        private void ChangePlayerSpeed_MouseEnter(object sender, EventArgs e)
        {
            ChangePlayerSpeed.Image = Properties.Resources.editbuttonblue;
            ChangePlayerSpeed.Refresh();
            ChangePlayerSpeed.Visible = true;
        }
        private void ChangePlayerSpeed_MouseLeave(object sender, EventArgs e)
        {
            ChangePlayerSpeed.Image = Properties.Resources.editbuttonwhite;
            ChangePlayerSpeed.Refresh();
            ChangePlayerSpeed.Visible = true;
        }
        private void ChangePlayerSpeed_MouseDown(object sender, MouseEventArgs e)
        {
            ChangePlayerSpeed.Image = Properties.Resources.editbuttondownblue;
            ChangePlayerSpeed.Refresh();
            ChangePlayerSpeed.Visible = true;
        }
        private void ChangePlayerSpeed_MouseUp(object sender, MouseEventArgs e)
        {
            ChangePlayerSpeed.Image = Properties.Resources.editbuttonblue;
            ChangePlayerSpeed.Refresh();
            ChangePlayerSpeed.Visible = true;
        }
        private void ChangeCrewVision_MouseEnter(object sender, EventArgs e)
        {
            ChangeCrewVision.Image = Properties.Resources.editbuttonblue;
            ChangeCrewVision.Refresh();
            ChangeCrewVision.Visible = true;
        }
        private void ChangeCrewVision_MouseLeave(object sender, EventArgs e)
        {
            ChangeCrewVision.Image = Properties.Resources.editbuttonwhite;
            ChangeCrewVision.Refresh();
            ChangeCrewVision.Visible = true;
        }
        private void ChangeCrewVision_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeCrewVision.Image = Properties.Resources.editbuttondownblue;
            ChangeCrewVision.Refresh();
            ChangeCrewVision.Visible = true;
        }
        private void ChangeCrewVision_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeCrewVision.Image = Properties.Resources.editbuttonblue;
            ChangeCrewVision.Refresh();
            ChangeCrewVision.Visible = true;
        }
        private void ChangeMeetings_MouseEnter(object sender, EventArgs e)
        {
            ChangeMeetings.Image = Properties.Resources.editbuttonblue;
            ChangeMeetings.Refresh();
            ChangeMeetings.Visible = true;
        }
        private void ChangeMeetings_MouseLeave(object sender, EventArgs e)
        {
            ChangeMeetings.Image = Properties.Resources.editbuttonwhite;
            ChangeMeetings.Refresh();
            ChangeMeetings.Visible = true;
        }
        private void ChangeMeetings_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeMeetings.Image = Properties.Resources.editbuttondownblue;
            ChangeMeetings.Refresh();
            ChangeMeetings.Visible = true;
        }
        private void ChangeMeetings_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeMeetings.Image = Properties.Resources.editbuttonblue;
            ChangeMeetings.Refresh();
            ChangeMeetings.Visible = true;
        }
        private void ChangeEmerCooldown_MouseEnter(object sender, EventArgs e)
        {
            ChangeEmerCooldown.Image = Properties.Resources.editbuttonblue;
            ChangeEmerCooldown.Refresh();
            ChangeEmerCooldown.Visible = true;
        }
        private void ChangeEmerCooldown_MouseLeave(object sender, EventArgs e)
        {
            ChangeEmerCooldown.Image = Properties.Resources.editbuttonwhite;
            ChangeEmerCooldown.Refresh();
            ChangeEmerCooldown.Visible = true;
        }
        private void ChangeEmerCooldown_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeEmerCooldown.Image = Properties.Resources.editbuttondownblue;
            ChangeEmerCooldown.Refresh();
            ChangeEmerCooldown.Visible = true;
        }
        private void ChangeEmerCooldown_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeEmerCooldown.Image = Properties.Resources.editbuttonblue;
            ChangeEmerCooldown.Refresh();
            ChangeEmerCooldown.Visible = true;
        }
        private void ChangeDiscussionTime_MouseEnter(object sender, EventArgs e)
        {
            ChangeDiscussionTime.Image = Properties.Resources.editbuttonblue;
            ChangeDiscussionTime.Refresh();
            ChangeDiscussionTime.Visible = true;
        }
        private void ChangeDiscussionTime_MouseLeave(object sender, EventArgs e)
        {
            ChangeDiscussionTime.Image = Properties.Resources.editbuttonwhite;
            ChangeDiscussionTime.Refresh();
            ChangeDiscussionTime.Visible = true;
        }
        private void ChangeDiscussionTime_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeDiscussionTime.Image = Properties.Resources.editbuttondownblue;
            ChangeDiscussionTime.Refresh();
            ChangeDiscussionTime.Visible = true;
        }
        private void ChangeDiscussionTime_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeDiscussionTime.Image = Properties.Resources.editbuttonblue;
            ChangeDiscussionTime.Refresh();
            ChangeDiscussionTime.Visible = true;
        }
        private void ChangeVotingTime_MouseEnter(object sender, EventArgs e)
        {
            ChangeVotingTime.Image = Properties.Resources.editbuttonblue;
            ChangeVotingTime.Refresh();
            ChangeVotingTime.Visible = true;
        }
        private void ChangeVotingTime_MouseLeave(object sender, EventArgs e)
        {
            ChangeVotingTime.Image = Properties.Resources.editbuttonwhite;
            ChangeVotingTime.Refresh();
            ChangeVotingTime.Visible = true;
        }
        private void ChangeVotingTime_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeVotingTime.Image = Properties.Resources.editbuttondownblue;
            ChangeVotingTime.Refresh();
            ChangeVotingTime.Visible = true;
        }
        private void ChangeVotingTime_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeVotingTime.Image = Properties.Resources.editbuttonblue;
            ChangeVotingTime.Refresh();
            ChangeVotingTime.Visible = true;
        }
        private async void ToggleVisibility()
        {
            for (int i = 0; i < 3; i++)
            {
                ChangedConfirm.Visible = true;
                await Task.Delay(100); // Wait for 0.5 seconds
                ChangedConfirm.Visible = false;
                await Task.Delay(100); // Optional: wait another 0.5 seconds before repeating
            }
        }

        // The Memory Editing Code

        private void ChangeKill_Click(object sender, EventArgs e)
        {
            // Kill Cooldown
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0229E52C,5C,0,14,24", "float", KillCooldownValue.Text);
                    float readValue = memory.ReadFloat("GameAssembly.dll+0229E52C,5C,0,14,24");

                    if (readValue == float.Parse(KillCooldownValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230BCDC,5C,10,14,24", "float", KillCooldownValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+0230BCDC,5C,10,14,24");

                        if (readValue == float.Parse(KillCooldownValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+022F918C,5C,10,14,24", "float", KillCooldownValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+022F918C,5C,10,14,24");

                        if (readValue == float.Parse(KillCooldownValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }


                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeImpVision_Click(object sender, EventArgs e)
        {
            //Imposter Vision
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0232BB30,5C,10,1C,20", "float", ImposterVisionValue.Text);
                    float readValue = memory.ReadFloat("GameAssembly.dll+0232BB30,5C,10,1C,20");


                    if (readValue == float.Parse(ImposterVisionValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0229E52C,5C,0,14,20", "float", ImposterVisionValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+0229E52C,5C,0,14,20");


                        if (readValue == float.Parse(ImposterVisionValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,28,20", "float", ImposterVisionValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+022F918C,5C,10,14,24");

                        if (readValue == float.Parse(ImposterVisionValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangePlayerSpeed_Click(object sender, EventArgs e)
        {
            //Player Speed
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0229E52C,5C,0,14,18", "float", PlayerSpeedValue.Text);
                    float readValue = memory.ReadFloat("GameAssembly.dll+0229E52C,5C,0,14,18");


                    if (readValue == float.Parse(PlayerSpeedValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0232BB30,5C,10,28,18", "float", PlayerSpeedValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+0232BB30,5C,10,28,18");


                        if (readValue == float.Parse(PlayerSpeedValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+02300690,5C,8,14,18", "float", PlayerSpeedValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+02300690,5C,8,14,18");

                        if (readValue == float.Parse(PlayerSpeedValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeCrewVision_Click(object sender, EventArgs e)
        {
            //Crew Vision
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,24,1C", "float", CrewVisionValue.Text);
                    float readValue = memory.ReadFloat("GameAssembly.dll+0230C724,5C,0,24,1C");

                    if (readValue == float.Parse(CrewVisionValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,24,1C", "float", CrewVisionValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+0230C724,5C,0,24,1C");


                        if (readValue == float.Parse(CrewVisionValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0232BB30,5C,10,24,1C", "float", CrewVisionValue.Text);
                        float readValue = memory.ReadFloat("GameAssembly.dll+0232BB30,5C,10,24,1C");

                        if (readValue == float.Parse(CrewVisionValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeMeetings_Click(object sender, EventArgs e)
        {
            //Meetings
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+022F918C,5C,10,14,34", "2bytes", MeetingValue.Text);
                    int readValue = memory.Read2Byte("GameAssembly.dll+022F918C,5C,10,14,34");

                    if (readValue == int.Parse(MeetingValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+02463D68,418,464,974,34", "2bytes", MeetingValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+02463D68,418,464,974,34");


                        if (readValue == int.Parse(MeetingValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,1C,34", "2bytes", MeetingValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+0230C724,5C,0,1C,34");

                        if (readValue == int.Parse(MeetingValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeEmerCooldown_Click(object sender, EventArgs e)
        {
            //Meeting Cooldown
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+02300690,5C,8,14,38", "2bytes", EmerCooldownValue.Text);
                    int readValue = memory.Read2Byte("GameAssembly.dll+02300690,5C,8,14,38");

                    if (readValue == int.Parse(EmerCooldownValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+022FA9D4,5C,0,8C,448", "2bytes", EmerCooldownValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+022FA9D4,5C,0,8C,448");


                        if (readValue == int.Parse(EmerCooldownValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+022F918C,5C,10,14,38", "2bytes", EmerCooldownValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+022F918C,5C,10,14,38");

                        if (readValue == int.Parse(EmerCooldownValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeDiscussionTime_Click(object sender, EventArgs e)
        {
            //Disscusion time
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,24,48", "2bytes", DiscussionTimeValue.Text);
                    int readValue = memory.Read2Byte("GameAssembly.dll+0230C724,5C,0,24,48");

                    if (readValue == int.Parse(DiscussionTimeValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,24,48", "2bytes", DiscussionTimeValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+0230C724,5C,0,24,48");


                        if (readValue == int.Parse(DiscussionTimeValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0229E52C,5C,0,14,48", "2bytes", DiscussionTimeValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+0229E52C,5C,0,14,48");

                        if (readValue == int.Parse(DiscussionTimeValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }
        private void ChangeVotingTime_Click(object sender, EventArgs e)
        {
            //Voting Time
            var amongUsProcess = Process.GetProcessesByName("Among Us").FirstOrDefault();
            if (amongUsProcess != null)
            {
                bool success = false;

                try
                {
                    memory.OpenProcess(amongUsProcess.Id);
                    memory.WriteMemory("GameAssembly.dll+0232BB30,5C,10,34,B4", "2bytes", VotingTimeValue.Text);
                    int readValue = memory.Read2Byte("GameAssembly.dll+0232BB30,5C,10,34,B4");

                    if (readValue == int.Parse(VotingTimeValue.Text))
                    {
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,1C,4C", "2bytes", VotingTimeValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+0230C724,5C,0,1C,4C");


                        if (readValue == int.Parse(VotingTimeValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception)
                    {
                        success = false;
                    }
                }

                if (!success)
                {
                    try
                    {
                        memory.OpenProcess(amongUsProcess.Id);
                        memory.WriteMemory("GameAssembly.dll+0230C724,5C,0,1C,4C", "2bytes", VotingTimeValue.Text);
                        int readValue = memory.Read2Byte("GameAssembly.dll+0230C724,5C,0,1C,4C");

                        if (readValue == int.Parse(VotingTimeValue.Text))
                        {
                            success = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to modify memory (Restart the game): " + ex.Message);
                    }
                }
                if (success)
                {
                    ToggleVisibility();
                }
            }
            else
            {
                MessageBox.Show("Among Us process not found.");
            }
        }

        
    }
}
