namespace TrackerUI
{
  partial class CreateTeamForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
      this.teamNameValue = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.headerLabel = new System.Windows.Forms.Label();
      this.addMemberButton = new System.Windows.Forms.Button();
      this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.addNewMemeberGroupBox = new System.Windows.Forms.GroupBox();
      this.createMemberButton = new System.Windows.Forms.Button();
      this.cellphoneValue = new System.Windows.Forms.TextBox();
      this.cellphoneLabel = new System.Windows.Forms.Label();
      this.emailValue = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.lastNameValue = new System.Windows.Forms.TextBox();
      this.LastNameLabel = new System.Windows.Forms.Label();
      this.firstNameValue = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.teamMembersListBox = new System.Windows.Forms.ListBox();
      this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
      this.createTeamButton = new System.Windows.Forms.Button();
      this.addNewMemeberGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameValue
      // 
      this.teamNameValue.Location = new System.Drawing.Point(71, 160);
      this.teamNameValue.Name = "teamNameValue";
      this.teamNameValue.Size = new System.Drawing.Size(395, 35);
      this.teamNameValue.TabIndex = 13;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.teamNameLabel.Location = new System.Drawing.Point(66, 127);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(124, 30);
      this.teamNameLabel.TabIndex = 12;
      this.teamNameLabel.Text = "Team Name";
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.headerLabel.Location = new System.Drawing.Point(73, 63);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(196, 45);
      this.headerLabel.TabIndex = 11;
      this.headerLabel.Text = "Create Team";
      // 
      // addMemberButton
      // 
      this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.addMemberButton.Location = new System.Drawing.Point(167, 304);
      this.addMemberButton.Name = "addMemberButton";
      this.addMemberButton.Size = new System.Drawing.Size(201, 49);
      this.addMemberButton.TabIndex = 20;
      this.addMemberButton.Text = "Add Member";
      this.addMemberButton.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemberDropDown
      // 
      this.selectTeamMemberDropDown.FormattingEnabled = true;
      this.selectTeamMemberDropDown.Location = new System.Drawing.Point(71, 250);
      this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
      this.selectTeamMemberDropDown.Size = new System.Drawing.Size(395, 38);
      this.selectTeamMemberDropDown.TabIndex = 19;
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(66, 217);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
      this.selectTeamMemberLabel.TabIndex = 18;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addNewMemeberGroupBox
      // 
      this.addNewMemeberGroupBox.Controls.Add(this.createMemberButton);
      this.addNewMemeberGroupBox.Controls.Add(this.cellphoneValue);
      this.addNewMemeberGroupBox.Controls.Add(this.cellphoneLabel);
      this.addNewMemeberGroupBox.Controls.Add(this.emailValue);
      this.addNewMemeberGroupBox.Controls.Add(this.emailLabel);
      this.addNewMemeberGroupBox.Controls.Add(this.lastNameValue);
      this.addNewMemeberGroupBox.Controls.Add(this.LastNameLabel);
      this.addNewMemeberGroupBox.Controls.Add(this.firstNameValue);
      this.addNewMemeberGroupBox.Controls.Add(this.firstNameLabel);
      this.addNewMemeberGroupBox.Location = new System.Drawing.Point(71, 381);
      this.addNewMemeberGroupBox.Name = "addNewMemeberGroupBox";
      this.addNewMemeberGroupBox.Size = new System.Drawing.Size(395, 322);
      this.addNewMemeberGroupBox.TabIndex = 21;
      this.addNewMemeberGroupBox.TabStop = false;
      this.addNewMemeberGroupBox.Text = "Add New Member";
      // 
      // createMemberButton
      // 
      this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.createMemberButton.Location = new System.Drawing.Point(96, 257);
      this.createMemberButton.Name = "createMemberButton";
      this.createMemberButton.Size = new System.Drawing.Size(201, 49);
      this.createMemberButton.TabIndex = 22;
      this.createMemberButton.Text = "Create Member";
      this.createMemberButton.UseVisualStyleBackColor = true;
      // 
      // cellphoneValue
      // 
      this.cellphoneValue.Location = new System.Drawing.Point(147, 207);
      this.cellphoneValue.Name = "cellphoneValue";
      this.cellphoneValue.Size = new System.Drawing.Size(231, 35);
      this.cellphoneValue.TabIndex = 29;
      // 
      // cellphoneLabel
      // 
      this.cellphoneLabel.AutoSize = true;
      this.cellphoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.cellphoneLabel.Location = new System.Drawing.Point(12, 212);
      this.cellphoneLabel.Name = "cellphoneLabel";
      this.cellphoneLabel.Size = new System.Drawing.Size(106, 30);
      this.cellphoneLabel.TabIndex = 28;
      this.cellphoneLabel.Text = "Cellphone";
      // 
      // emailValue
      // 
      this.emailValue.Location = new System.Drawing.Point(149, 158);
      this.emailValue.Name = "emailValue";
      this.emailValue.Size = new System.Drawing.Size(231, 35);
      this.emailValue.TabIndex = 27;
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.emailLabel.Location = new System.Drawing.Point(14, 163);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(63, 30);
      this.emailLabel.TabIndex = 26;
      this.emailLabel.Text = "Email";
      // 
      // lastNameValue
      // 
      this.lastNameValue.Location = new System.Drawing.Point(149, 104);
      this.lastNameValue.Name = "lastNameValue";
      this.lastNameValue.Size = new System.Drawing.Size(231, 35);
      this.lastNameValue.TabIndex = 25;
      // 
      // LastNameLabel
      // 
      this.LastNameLabel.AutoSize = true;
      this.LastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.LastNameLabel.Location = new System.Drawing.Point(14, 109);
      this.LastNameLabel.Name = "LastNameLabel";
      this.LastNameLabel.Size = new System.Drawing.Size(112, 30);
      this.LastNameLabel.TabIndex = 24;
      this.LastNameLabel.Text = "Last Name";
      // 
      // firstNameValue
      // 
      this.firstNameValue.Location = new System.Drawing.Point(147, 45);
      this.firstNameValue.Name = "firstNameValue";
      this.firstNameValue.Size = new System.Drawing.Size(231, 35);
      this.firstNameValue.TabIndex = 23;
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.firstNameLabel.Location = new System.Drawing.Point(12, 50);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
      this.firstNameLabel.TabIndex = 22;
      this.firstNameLabel.Text = "First Name";
      // 
      // teamMembersListBox
      // 
      this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teamMembersListBox.FormattingEnabled = true;
      this.teamMembersListBox.ItemHeight = 30;
      this.teamMembersListBox.Location = new System.Drawing.Point(560, 160);
      this.teamMembersListBox.Name = "teamMembersListBox";
      this.teamMembersListBox.Size = new System.Drawing.Size(357, 542);
      this.teamMembersListBox.TabIndex = 22;
      // 
      // deleteSelectedMemberButton
      // 
      this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.deleteSelectedMemberButton.Location = new System.Drawing.Point(949, 358);
      this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
      this.deleteSelectedMemberButton.Size = new System.Drawing.Size(114, 72);
      this.deleteSelectedMemberButton.TabIndex = 23;
      this.deleteSelectedMemberButton.Text = "Delete Selected";
      this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
      // 
      // createTeamButton
      // 
      this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.createTeamButton.Location = new System.Drawing.Point(356, 735);
      this.createTeamButton.Name = "createTeamButton";
      this.createTeamButton.Size = new System.Drawing.Size(296, 61);
      this.createTeamButton.TabIndex = 25;
      this.createTeamButton.Text = "Create Team";
      this.createTeamButton.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1084, 827);
      this.Controls.Add(this.createTeamButton);
      this.Controls.Add(this.deleteSelectedMemberButton);
      this.Controls.Add(this.teamMembersListBox);
      this.Controls.Add(this.addNewMemeberGroupBox);
      this.Controls.Add(this.addMemberButton);
      this.Controls.Add(this.selectTeamMemberDropDown);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.teamNameValue);
      this.Controls.Add(this.teamNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.addNewMemeberGroupBox.ResumeLayout(false);
      this.addNewMemeberGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameValue;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Button addMemberButton;
    private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.GroupBox addNewMemeberGroupBox;
    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.TextBox cellphoneValue;
    private System.Windows.Forms.Label cellphoneLabel;
    private System.Windows.Forms.TextBox emailValue;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.TextBox lastNameValue;
    private System.Windows.Forms.Label LastNameLabel;
    private System.Windows.Forms.TextBox firstNameValue;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button deleteSelectedMemberButton;
    private System.Windows.Forms.Button createTeamButton;
  }
}