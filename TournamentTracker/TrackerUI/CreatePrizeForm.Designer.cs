﻿namespace TrackerUI
{
  partial class CreatePrizeForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
      this.headerLabel = new System.Windows.Forms.Label();
      this.placeNumberValue = new System.Windows.Forms.TextBox();
      this.placeNumberLabel = new System.Windows.Forms.Label();
      this.placeNameValue = new System.Windows.Forms.TextBox();
      this.placeNameLabel = new System.Windows.Forms.Label();
      this.prizeAmountValue = new System.Windows.Forms.TextBox();
      this.prizeAmountLabel = new System.Windows.Forms.Label();
      this.prizePercentageValue = new System.Windows.Forms.TextBox();
      this.prizePercentageLabel = new System.Windows.Forms.Label();
      this.orLabel = new System.Windows.Forms.Label();
      this.createPrizeButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.headerLabel.Location = new System.Drawing.Point(75, 63);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(189, 45);
      this.headerLabel.TabIndex = 12;
      this.headerLabel.Text = "Create Prize";
      // 
      // placeNumberValue
      // 
      this.placeNumberValue.Location = new System.Drawing.Point(237, 136);
      this.placeNumberValue.Name = "placeNumberValue";
      this.placeNumberValue.Size = new System.Drawing.Size(231, 35);
      this.placeNumberValue.TabIndex = 25;
      // 
      // placeNumberLabel
      // 
      this.placeNumberLabel.AutoSize = true;
      this.placeNumberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.placeNumberLabel.Location = new System.Drawing.Point(78, 141);
      this.placeNumberLabel.Name = "placeNumberLabel";
      this.placeNumberLabel.Size = new System.Drawing.Size(144, 30);
      this.placeNumberLabel.TabIndex = 24;
      this.placeNumberLabel.Text = "Place Number";
      // 
      // placeNameValue
      // 
      this.placeNameValue.Location = new System.Drawing.Point(237, 188);
      this.placeNameValue.Name = "placeNameValue";
      this.placeNameValue.Size = new System.Drawing.Size(231, 35);
      this.placeNameValue.TabIndex = 27;
      // 
      // placeNameLabel
      // 
      this.placeNameLabel.AutoSize = true;
      this.placeNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.placeNameLabel.Location = new System.Drawing.Point(78, 193);
      this.placeNameLabel.Name = "placeNameLabel";
      this.placeNameLabel.Size = new System.Drawing.Size(124, 30);
      this.placeNameLabel.TabIndex = 26;
      this.placeNameLabel.Text = "Place Name";
      // 
      // prizeAmountValue
      // 
      this.prizeAmountValue.Location = new System.Drawing.Point(237, 241);
      this.prizeAmountValue.Name = "prizeAmountValue";
      this.prizeAmountValue.Size = new System.Drawing.Size(231, 35);
      this.prizeAmountValue.TabIndex = 29;
      this.prizeAmountValue.Text = "0";
      // 
      // prizeAmountLabel
      // 
      this.prizeAmountLabel.AutoSize = true;
      this.prizeAmountLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.prizeAmountLabel.Location = new System.Drawing.Point(78, 246);
      this.prizeAmountLabel.Name = "prizeAmountLabel";
      this.prizeAmountLabel.Size = new System.Drawing.Size(139, 30);
      this.prizeAmountLabel.TabIndex = 28;
      this.prizeAmountLabel.Text = "Prize Amount";
      // 
      // prizePercentageValue
      // 
      this.prizePercentageValue.Location = new System.Drawing.Point(265, 366);
      this.prizePercentageValue.Name = "prizePercentageValue";
      this.prizePercentageValue.Size = new System.Drawing.Size(231, 35);
      this.prizePercentageValue.TabIndex = 31;
      this.prizePercentageValue.Text = "0";
      // 
      // prizePercentageLabel
      // 
      this.prizePercentageLabel.AutoSize = true;
      this.prizePercentageLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.prizePercentageLabel.Location = new System.Drawing.Point(78, 371);
      this.prizePercentageLabel.Name = "prizePercentageLabel";
      this.prizePercentageLabel.Size = new System.Drawing.Size(167, 30);
      this.prizePercentageLabel.TabIndex = 30;
      this.prizePercentageLabel.Text = "Prize Percentage";
      // 
      // orLabel
      // 
      this.orLabel.AutoSize = true;
      this.orLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.orLabel.Location = new System.Drawing.Point(190, 319);
      this.orLabel.Name = "orLabel";
      this.orLabel.Size = new System.Drawing.Size(48, 30);
      this.orLabel.TabIndex = 32;
      this.orLabel.Text = "-or-";
      // 
      // createPrizeButton
      // 
      this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createPrizeButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.createPrizeButton.Location = new System.Drawing.Point(130, 463);
      this.createPrizeButton.Name = "createPrizeButton";
      this.createPrizeButton.Size = new System.Drawing.Size(296, 61);
      this.createPrizeButton.TabIndex = 33;
      this.createPrizeButton.Text = "Create Prize";
      this.createPrizeButton.UseVisualStyleBackColor = true;
      this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
      // 
      // CreatePrizeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(570, 637);
      this.Controls.Add(this.createPrizeButton);
      this.Controls.Add(this.orLabel);
      this.Controls.Add(this.prizePercentageValue);
      this.Controls.Add(this.prizePercentageLabel);
      this.Controls.Add(this.prizeAmountValue);
      this.Controls.Add(this.prizeAmountLabel);
      this.Controls.Add(this.placeNameValue);
      this.Controls.Add(this.placeNameLabel);
      this.Controls.Add(this.placeNumberValue);
      this.Controls.Add(this.placeNumberLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreatePrizeForm";
      this.Text = "Create Prize";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.TextBox placeNumberValue;
    private System.Windows.Forms.Label placeNumberLabel;
    private System.Windows.Forms.TextBox placeNameValue;
    private System.Windows.Forms.Label placeNameLabel;
    private System.Windows.Forms.TextBox prizeAmountValue;
    private System.Windows.Forms.Label prizeAmountLabel;
    private System.Windows.Forms.TextBox prizePercentageValue;
    private System.Windows.Forms.Label prizePercentageLabel;
    private System.Windows.Forms.Label orLabel;
    private System.Windows.Forms.Button createPrizeButton;
  }
}