﻿namespace TennisScoreApp
{
    partial class PlayerInfo
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
            PlayerNameLabel = new Label();
            VictoriesLabel = new Label();
            LossesLabel = new Label();
            DrawLabel = new Label();
            VictoriesListView = new ListView();
            VictoryCompetitor = new ColumnHeader();
            VictoryScore = new ColumnHeader();
            LossesListView = new ListView();
            LossCompetitor = new ColumnHeader();
            LossScore = new ColumnHeader();
            DrawListView = new ListView();
            DrawCompetitor = new ColumnHeader();
            DrawScore = new ColumnHeader();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerNameLabel.Location = new Point(291, 12);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(270, 60);
            PlayerNameLabel.TabIndex = 0;
            PlayerNameLabel.Text = "Player Name";
            // 
            // VictoriesLabel
            // 
            VictoriesLabel.AutoSize = true;
            VictoriesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            VictoriesLabel.Location = new Point(86, 163);
            VictoriesLabel.Name = "VictoriesLabel";
            VictoriesLabel.Size = new Size(105, 32);
            VictoriesLabel.TabIndex = 1;
            VictoriesLabel.Text = "Victories";
            // 
            // LossesLabel
            // 
            LossesLabel.AutoSize = true;
            LossesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LossesLabel.Location = new Point(423, 163);
            LossesLabel.Name = "LossesLabel";
            LossesLabel.Size = new Size(82, 32);
            LossesLabel.TabIndex = 2;
            LossesLabel.Text = "Losses";
            // 
            // DrawLabel
            // 
            DrawLabel.AutoSize = true;
            DrawLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DrawLabel.Location = new Point(738, 163);
            DrawLabel.Name = "DrawLabel";
            DrawLabel.Size = new Size(68, 32);
            DrawLabel.TabIndex = 3;
            DrawLabel.Text = "Draw";
            // 
            // VictoriesListView
            // 
            VictoriesListView.BackColor = Color.DarkOrange;
            VictoriesListView.Columns.AddRange(new ColumnHeader[] { VictoryCompetitor, VictoryScore });
            VictoriesListView.Location = new Point(14, 200);
            VictoriesListView.Margin = new Padding(3, 4, 3, 4);
            VictoriesListView.Name = "VictoriesListView";
            VictoriesListView.Size = new Size(262, 240);
            VictoriesListView.TabIndex = 4;
            VictoriesListView.UseCompatibleStateImageBehavior = false;
            VictoriesListView.View = View.Details;
            // 
            // VictoryCompetitor
            // 
            VictoryCompetitor.Text = "Competitor";
            VictoryCompetitor.Width = 150;
            // 
            // VictoryScore
            // 
            VictoryScore.Text = "Score";
            VictoryScore.Width = 80;
            // 
            // LossesListView
            // 
            LossesListView.BackColor = Color.DarkOrange;
            LossesListView.Columns.AddRange(new ColumnHeader[] { LossCompetitor, LossScore });
            LossesListView.Location = new Point(329, 200);
            LossesListView.Margin = new Padding(3, 4, 3, 4);
            LossesListView.Name = "LossesListView";
            LossesListView.Size = new Size(262, 240);
            LossesListView.TabIndex = 5;
            LossesListView.UseCompatibleStateImageBehavior = false;
            LossesListView.View = View.Details;
            // 
            // LossCompetitor
            // 
            LossCompetitor.Text = "Competitor";
            LossCompetitor.Width = 150;
            // 
            // LossScore
            // 
            LossScore.Text = "Score";
            LossScore.Width = 80;
            // 
            // DrawListView
            // 
            DrawListView.BackColor = Color.DarkOrange;
            DrawListView.Columns.AddRange(new ColumnHeader[] { DrawCompetitor, DrawScore });
            DrawListView.Location = new Point(638, 200);
            DrawListView.Margin = new Padding(3, 4, 3, 4);
            DrawListView.Name = "DrawListView";
            DrawListView.Size = new Size(262, 240);
            DrawListView.TabIndex = 6;
            DrawListView.UseCompatibleStateImageBehavior = false;
            DrawListView.View = View.Details;
            // 
            // DrawCompetitor
            // 
            DrawCompetitor.Text = "Competitor";
            DrawCompetitor.Width = 150;
            // 
            // DrawScore
            // 
            DrawScore.Text = "Score";
            DrawScore.Width = 75;
            // 
            // PlayerInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(914, 600);
            Controls.Add(DrawListView);
            Controls.Add(LossesListView);
            Controls.Add(VictoriesListView);
            Controls.Add(DrawLabel);
            Controls.Add(LossesLabel);
            Controls.Add(VictoriesLabel);
            Controls.Add(PlayerNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlayerInfo";
            Text = "PlayerInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerNameLabel;
        private Label VictoriesLabel;
        private Label LossesLabel;
        private Label DrawLabel;
        private ListView VictoriesListView;
        private ListView LossesListView;
        private ListView DrawListView;
        private ColumnHeader VictoryCompetitor;
        private ColumnHeader VictoryScore;
        private ColumnHeader LossCompetitor;
        private ColumnHeader LossScore;
        private ColumnHeader DrawCompetitor;
        private ColumnHeader DrawScore;
    }
}