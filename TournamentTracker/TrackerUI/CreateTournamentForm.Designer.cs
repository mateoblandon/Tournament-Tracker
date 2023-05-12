namespace TrackerUI
{
  partial class CreateTournamentForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentNameValue = new System.Windows.Forms.TextBox();
      this.tournamentNameLabel = new System.Windows.Forms.Label();
      this.entryFeeValue = new System.Windows.Forms.TextBox();
      this.entryFeeLabel = new System.Windows.Forms.Label();
      this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
      this.selectTeamLabel = new System.Windows.Forms.Label();
      this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
      this.addTeamButton = new System.Windows.Forms.Button();
      this.createPrizeButton = new System.Windows.Forms.Button();
      this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
      this.tournamentPlayersLabel = new System.Windows.Forms.Label();
      this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
      this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
      this.prizesLabel = new System.Windows.Forms.Label();
      this.prizesListBox = new System.Windows.Forms.ListBox();
      this.createTournamentButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.headerLabel.Location = new System.Drawing.Point(89, 38);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(291, 45);
      this.headerLabel.TabIndex = 1;
      this.headerLabel.Text = "Create Tournament";
      // 
      // tournamentNameValue
      // 
      this.tournamentNameValue.Location = new System.Drawing.Point(87, 135);
      this.tournamentNameValue.Name = "tournamentNameValue";
      this.tournamentNameValue.Size = new System.Drawing.Size(395, 35);
      this.tournamentNameValue.TabIndex = 10;
      // 
      // tournamentNameLabel
      // 
      this.tournamentNameLabel.AutoSize = true;
      this.tournamentNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.tournamentNameLabel.Location = new System.Drawing.Point(82, 102);
      this.tournamentNameLabel.Name = "tournamentNameLabel";
      this.tournamentNameLabel.Size = new System.Drawing.Size(186, 30);
      this.tournamentNameLabel.TabIndex = 9;
      this.tournamentNameLabel.Text = "Tournament Name";
      // 
      // entryFeeValue
      // 
      this.entryFeeValue.Location = new System.Drawing.Point(190, 200);
      this.entryFeeValue.Name = "entryFeeValue";
      this.entryFeeValue.Size = new System.Drawing.Size(125, 35);
      this.entryFeeValue.TabIndex = 12;
      this.entryFeeValue.Text = "0";
      // 
      // entryFeeLabel
      // 
      this.entryFeeLabel.AutoSize = true;
      this.entryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.entryFeeLabel.Location = new System.Drawing.Point(82, 205);
      this.entryFeeLabel.Name = "entryFeeLabel";
      this.entryFeeLabel.Size = new System.Drawing.Size(98, 30);
      this.entryFeeLabel.TabIndex = 11;
      this.entryFeeLabel.Text = "Entry Fee";
      // 
      // selectTeamDropDown
      // 
      this.selectTeamDropDown.FormattingEnabled = true;
      this.selectTeamDropDown.Location = new System.Drawing.Point(87, 382);
      this.selectTeamDropDown.Name = "selectTeamDropDown";
      this.selectTeamDropDown.Size = new System.Drawing.Size(395, 38);
      this.selectTeamDropDown.TabIndex = 14;
      // 
      // selectTeamLabel
      // 
      this.selectTeamLabel.AutoSize = true;
      this.selectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.selectTeamLabel.Location = new System.Drawing.Point(82, 349);
      this.selectTeamLabel.Name = "selectTeamLabel";
      this.selectTeamLabel.Size = new System.Drawing.Size(123, 30);
      this.selectTeamLabel.TabIndex = 13;
      this.selectTeamLabel.Text = "Select Team";
      // 
      // createNewTeamLabel
      // 
      this.createNewTeamLabel.AutoSize = true;
      this.createNewTeamLabel.Location = new System.Drawing.Point(368, 349);
      this.createNewTeamLabel.Name = "createNewTeamLabel";
      this.createNewTeamLabel.Size = new System.Drawing.Size(114, 30);
      this.createNewTeamLabel.TabIndex = 15;
      this.createNewTeamLabel.TabStop = true;
      this.createNewTeamLabel.Text = "create new";
      this.createNewTeamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLabel_LinkClicked);
      // 
      // addTeamButton
      // 
      this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.addTeamButton.Location = new System.Drawing.Point(183, 436);
      this.addTeamButton.Name = "addTeamButton";
      this.addTeamButton.Size = new System.Drawing.Size(201, 49);
      this.addTeamButton.TabIndex = 16;
      this.addTeamButton.Text = "Add Team";
      this.addTeamButton.UseVisualStyleBackColor = true;
      this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
      // 
      // createPrizeButton
      // 
      this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizeButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.createPrizeButton.Location = new System.Drawing.Point(183, 506);
      this.createPrizeButton.Name = "createPrizeButton";
      this.createPrizeButton.Size = new System.Drawing.Size(201, 49);
      this.createPrizeButton.TabIndex = 17;
      this.createPrizeButton.Text = "Create Prize";
      this.createPrizeButton.UseVisualStyleBackColor = true;
      this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
      // 
      // tournamentTeamsListBox
      // 
      this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tournamentTeamsListBox.FormattingEnabled = true;
      this.tournamentTeamsListBox.ItemHeight = 30;
      this.tournamentTeamsListBox.Location = new System.Drawing.Point(580, 135);
      this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
      this.tournamentTeamsListBox.Size = new System.Drawing.Size(335, 182);
      this.tournamentTeamsListBox.TabIndex = 18;
      // 
      // tournamentPlayersLabel
      // 
      this.tournamentPlayersLabel.AutoSize = true;
      this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.tournamentPlayersLabel.Location = new System.Drawing.Point(575, 102);
      this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
      this.tournamentPlayersLabel.Size = new System.Drawing.Size(156, 30);
      this.tournamentPlayersLabel.TabIndex = 19;
      this.tournamentPlayersLabel.Text = "Teams / Players";
      // 
      // removeSelectedPlayersButton
      // 
      this.removeSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeSelectedPlayersButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.removeSelectedPlayersButton.Location = new System.Drawing.Point(934, 194);
      this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
      this.removeSelectedPlayersButton.Size = new System.Drawing.Size(114, 72);
      this.removeSelectedPlayersButton.TabIndex = 20;
      this.removeSelectedPlayersButton.Text = "Remove Selected";
      this.removeSelectedPlayersButton.UseVisualStyleBackColor = true;
      this.removeSelectedPlayersButton.Click += new System.EventHandler(this.removeSelectedPlayersButton_Click);
      // 
      // removeSelectedPrizeButton
      // 
      this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeSelectedPrizeButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.removeSelectedPrizeButton.Location = new System.Drawing.Point(934, 441);
      this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
      this.removeSelectedPrizeButton.Size = new System.Drawing.Size(114, 78);
      this.removeSelectedPrizeButton.TabIndex = 23;
      this.removeSelectedPrizeButton.Text = "Remove Seected";
      this.removeSelectedPrizeButton.UseVisualStyleBackColor = true;
      this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
      // 
      // prizesLabel
      // 
      this.prizesLabel.AutoSize = true;
      this.prizesLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.prizesLabel.Location = new System.Drawing.Point(575, 349);
      this.prizesLabel.Name = "prizesLabel";
      this.prizesLabel.Size = new System.Drawing.Size(67, 30);
      this.prizesLabel.TabIndex = 22;
      this.prizesLabel.Text = "Prizes";
      // 
      // prizesListBox
      // 
      this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.prizesListBox.FormattingEnabled = true;
      this.prizesListBox.ItemHeight = 30;
      this.prizesListBox.Location = new System.Drawing.Point(580, 382);
      this.prizesListBox.Name = "prizesListBox";
      this.prizesListBox.Size = new System.Drawing.Size(335, 182);
      this.prizesListBox.TabIndex = 21;
      // 
      // createTournamentButton
      // 
      this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTournamentButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.createTournamentButton.Location = new System.Drawing.Point(382, 596);
      this.createTournamentButton.Name = "createTournamentButton";
      this.createTournamentButton.Size = new System.Drawing.Size(296, 61);
      this.createTournamentButton.TabIndex = 24;
      this.createTournamentButton.Text = "Create Tournament";
      this.createTournamentButton.UseVisualStyleBackColor = true;
      this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
      // 
      // CreateTournamentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1129, 669);
      this.Controls.Add(this.createTournamentButton);
      this.Controls.Add(this.removeSelectedPrizeButton);
      this.Controls.Add(this.prizesLabel);
      this.Controls.Add(this.prizesListBox);
      this.Controls.Add(this.removeSelectedPlayersButton);
      this.Controls.Add(this.tournamentPlayersLabel);
      this.Controls.Add(this.tournamentTeamsListBox);
      this.Controls.Add(this.createPrizeButton);
      this.Controls.Add(this.addTeamButton);
      this.Controls.Add(this.createNewTeamLabel);
      this.Controls.Add(this.selectTeamDropDown);
      this.Controls.Add(this.selectTeamLabel);
      this.Controls.Add(this.entryFeeValue);
      this.Controls.Add(this.entryFeeLabel);
      this.Controls.Add(this.tournamentNameValue);
      this.Controls.Add(this.tournamentNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTournamentForm";
      this.Text = "Create Tournament";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox tournamentNameValue;
    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.TextBox entryFeeValue;
    private System.Windows.Forms.Label entryFeeLabel;
    private System.Windows.Forms.ComboBox selectTeamDropDown;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.LinkLabel createNewTeamLabel;
    private System.Windows.Forms.Button addTeamButton;
    private System.Windows.Forms.Button createPrizeButton;
    private System.Windows.Forms.ListBox tournamentTeamsListBox;
    private System.Windows.Forms.Label tournamentPlayersLabel;
    private System.Windows.Forms.Button removeSelectedPlayersButton;
    private System.Windows.Forms.Button removeSelectedPrizeButton;
    private System.Windows.Forms.Label prizesLabel;
    private System.Windows.Forms.ListBox prizesListBox;
    private System.Windows.Forms.Button createTournamentButton;
  }
}