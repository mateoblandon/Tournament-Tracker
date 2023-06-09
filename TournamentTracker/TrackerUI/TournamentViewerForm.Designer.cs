﻿namespace TrackerUI
{
  partial class TournamentViewerForm
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentName = new System.Windows.Forms.Label();
      this.roundLabel = new System.Windows.Forms.Label();
      this.roundDropDown = new System.Windows.Forms.ComboBox();
      this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
      this.matchupListBox = new System.Windows.Forms.ListBox();
      this.teamOneName = new System.Windows.Forms.Label();
      this.teamOneScoreLabel = new System.Windows.Forms.Label();
      this.teamOneScoreValue = new System.Windows.Forms.TextBox();
      this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
      this.teamTwoScoreLabel = new System.Windows.Forms.Label();
      this.teamTwoName = new System.Windows.Forms.Label();
      this.versusLabel = new System.Windows.Forms.Label();
      this.scoreButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.headerLabel.Location = new System.Drawing.Point(42, 26);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(197, 45);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Tournament:";
      // 
      // tournamentName
      // 
      this.tournamentName.AutoSize = true;
      this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
      this.tournamentName.Location = new System.Drawing.Point(245, 26);
      this.tournamentName.Name = "tournamentName";
      this.tournamentName.Size = new System.Drawing.Size(136, 45);
      this.tournamentName.TabIndex = 1;
      this.tournamentName.Text = "<none>";
      // 
      // roundLabel
      // 
      this.roundLabel.AutoSize = true;
      this.roundLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.roundLabel.Location = new System.Drawing.Point(45, 112);
      this.roundLabel.Name = "roundLabel";
      this.roundLabel.Size = new System.Drawing.Size(73, 30);
      this.roundLabel.TabIndex = 2;
      this.roundLabel.Text = "Round";
      // 
      // roundDropDown
      // 
      this.roundDropDown.FormattingEnabled = true;
      this.roundDropDown.Location = new System.Drawing.Point(136, 104);
      this.roundDropDown.Name = "roundDropDown";
      this.roundDropDown.Size = new System.Drawing.Size(273, 38);
      this.roundDropDown.TabIndex = 3;
      this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
      // 
      // unplayedOnlyCheckbox
      // 
      this.unplayedOnlyCheckbox.AutoSize = true;
      this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.DodgerBlue;
      this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(136, 178);
      this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
      this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(165, 34);
      this.unplayedOnlyCheckbox.TabIndex = 4;
      this.unplayedOnlyCheckbox.Text = "Unplayed Only";
      this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
      this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckbox_CheckedChanged);
      // 
      // matchupListBox
      // 
      this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.matchupListBox.FormattingEnabled = true;
      this.matchupListBox.ItemHeight = 30;
      this.matchupListBox.Location = new System.Drawing.Point(50, 248);
      this.matchupListBox.Name = "matchupListBox";
      this.matchupListBox.Size = new System.Drawing.Size(359, 332);
      this.matchupListBox.TabIndex = 5;
      this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
      // 
      // teamOneName
      // 
      this.teamOneName.AutoSize = true;
      this.teamOneName.ForeColor = System.Drawing.Color.DodgerBlue;
      this.teamOneName.Location = new System.Drawing.Point(592, 248);
      this.teamOneName.Name = "teamOneName";
      this.teamOneName.Size = new System.Drawing.Size(131, 30);
      this.teamOneName.TabIndex = 6;
      this.teamOneName.Text = "<Team one>";
      // 
      // teamOneScoreLabel
      // 
      this.teamOneScoreLabel.AutoSize = true;
      this.teamOneScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.teamOneScoreLabel.Location = new System.Drawing.Point(592, 304);
      this.teamOneScoreLabel.Name = "teamOneScoreLabel";
      this.teamOneScoreLabel.Size = new System.Drawing.Size(64, 30);
      this.teamOneScoreLabel.TabIndex = 7;
      this.teamOneScoreLabel.Text = "Score";
      // 
      // teamOneScoreValue
      // 
      this.teamOneScoreValue.Location = new System.Drawing.Point(697, 299);
      this.teamOneScoreValue.Name = "teamOneScoreValue";
      this.teamOneScoreValue.Size = new System.Drawing.Size(195, 35);
      this.teamOneScoreValue.TabIndex = 8;
      // 
      // teamTwoScoreValue
      // 
      this.teamTwoScoreValue.Location = new System.Drawing.Point(697, 512);
      this.teamTwoScoreValue.Name = "teamTwoScoreValue";
      this.teamTwoScoreValue.Size = new System.Drawing.Size(195, 35);
      this.teamTwoScoreValue.TabIndex = 11;
      // 
      // teamTwoScoreLabel
      // 
      this.teamTwoScoreLabel.AutoSize = true;
      this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.teamTwoScoreLabel.Location = new System.Drawing.Point(592, 517);
      this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
      this.teamTwoScoreLabel.Size = new System.Drawing.Size(64, 30);
      this.teamTwoScoreLabel.TabIndex = 10;
      this.teamTwoScoreLabel.Text = "Score";
      // 
      // teamTwoName
      // 
      this.teamTwoName.AutoSize = true;
      this.teamTwoName.ForeColor = System.Drawing.Color.DodgerBlue;
      this.teamTwoName.Location = new System.Drawing.Point(592, 461);
      this.teamTwoName.Name = "teamTwoName";
      this.teamTwoName.Size = new System.Drawing.Size(130, 30);
      this.teamTwoName.TabIndex = 9;
      this.teamTwoName.Text = "<Team two>";
      // 
      // versusLabel
      // 
      this.versusLabel.AutoSize = true;
      this.versusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.versusLabel.Location = new System.Drawing.Point(692, 390);
      this.versusLabel.Name = "versusLabel";
      this.versusLabel.Size = new System.Drawing.Size(53, 30);
      this.versusLabel.TabIndex = 12;
      this.versusLabel.Text = "-VS-";
      // 
      // scoreButton
      // 
      this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.scoreButton.Location = new System.Drawing.Point(943, 390);
      this.scoreButton.Name = "scoreButton";
      this.scoreButton.Size = new System.Drawing.Size(78, 40);
      this.scoreButton.TabIndex = 13;
      this.scoreButton.Text = "Score";
      this.scoreButton.UseVisualStyleBackColor = true;
      this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
      // 
      // TournamentViewerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1163, 675);
      this.Controls.Add(this.scoreButton);
      this.Controls.Add(this.versusLabel);
      this.Controls.Add(this.teamTwoScoreValue);
      this.Controls.Add(this.teamTwoScoreLabel);
      this.Controls.Add(this.teamTwoName);
      this.Controls.Add(this.teamOneScoreValue);
      this.Controls.Add(this.teamOneScoreLabel);
      this.Controls.Add(this.teamOneName);
      this.Controls.Add(this.matchupListBox);
      this.Controls.Add(this.unplayedOnlyCheckbox);
      this.Controls.Add(this.roundDropDown);
      this.Controls.Add(this.roundLabel);
      this.Controls.Add(this.tournamentName);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentViewerForm";
      this.Text = "Tournament Viewer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label tournamentName;
    private System.Windows.Forms.Label roundLabel;
    private System.Windows.Forms.ComboBox roundDropDown;
    private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneName;
    private System.Windows.Forms.Label teamOneScoreLabel;
    private System.Windows.Forms.TextBox teamOneScoreValue;
    private System.Windows.Forms.TextBox teamTwoScoreValue;
    private System.Windows.Forms.Label teamTwoScoreLabel;
    private System.Windows.Forms.Label teamTwoName;
    private System.Windows.Forms.Label versusLabel;
    private System.Windows.Forms.Button scoreButton;
  }
}

