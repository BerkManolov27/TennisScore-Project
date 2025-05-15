
using static System.Windows.Forms.ListViewItem;

namespace TennisScoreApp
{
    partial class TennisScore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            RankingLable = new Label();
            LatestGamesLable = new Label();
            RankingListView = new ListView();
            PlayerName = new ColumnHeader();
            Score = new ColumnHeader();
            LatestGamesListView = new ListView();
            FirstPlayer = new ColumnHeader();
            SecondPlayer = new ColumnHeader();
            Winner = new ColumnHeader();
            WinnerScore = new ColumnHeader();
            AddNewGameButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(362, 12);
            Title.Name = "Title";
            Title.Size = new Size(266, 60);
            Title.TabIndex = 0;
            Title.Text = "Tennis Score";
            // 
            // RankingLable
            // 
            RankingLable.AutoSize = true;
            RankingLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RankingLable.Location = new Point(64, 83);
            RankingLable.Name = "RankingLable";
            RankingLable.Size = new Size(100, 32);
            RankingLable.TabIndex = 1;
            RankingLable.Text = "Ranking";
            // 
            // LatestGamesLable
            // 
            LatestGamesLable.AutoSize = true;
            LatestGamesLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LatestGamesLable.Location = new Point(64, 360);
            LatestGamesLable.Name = "LatestGamesLable";
            LatestGamesLable.Size = new Size(155, 32);
            LatestGamesLable.TabIndex = 2;
            LatestGamesLable.Text = "Latest Games";
            // 
            // RankingListView
            // 
            RankingListView.BackColor = Color.DarkOrange;
            RankingListView.Columns.AddRange(new ColumnHeader[] { PlayerName, Score });
            RankingListView.LabelEdit = true;
            RankingListView.Location = new Point(64, 120);
            RankingListView.Margin = new Padding(3, 4, 3, 4);
            RankingListView.Name = "RankingListView";
            RankingListView.Size = new Size(793, 160);
            RankingListView.TabIndex = 3;
            RankingListView.UseCompatibleStateImageBehavior = false;
            RankingListView.View = View.Details;
            RankingListView.Click += ViewProfileButtonClick;
            // 
            // PlayerName
            // 
            PlayerName.Text = "Player Name";
            PlayerName.Width = 500;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 190;
            // 
            // LatestGamesListView
            // 
            LatestGamesListView.BackColor = Color.DarkOrange;
            LatestGamesListView.Columns.AddRange(new ColumnHeader[] { FirstPlayer, SecondPlayer, Winner, WinnerScore });
            LatestGamesListView.Location = new Point(64, 397);
            LatestGamesListView.Margin = new Padding(3, 4, 3, 4);
            LatestGamesListView.Name = "LatestGamesListView";
            LatestGamesListView.Size = new Size(793, 160);
            LatestGamesListView.TabIndex = 4;
            LatestGamesListView.UseCompatibleStateImageBehavior = false;
            LatestGamesListView.View = View.Details;
            // 
            // FirstPlayer
            // 
            FirstPlayer.Text = "FirstPlayer";
            FirstPlayer.Width = 200;
            // 
            // SecondPlayer
            // 
            SecondPlayer.Text = "Second Player";
            SecondPlayer.Width = 200;
            // 
            // Winner
            // 
            Winner.Text = "Winner";
            Winner.Width = 200;
            // 
            // WinnerScore
            // 
            WinnerScore.Text = "Score";
            WinnerScore.Width = 90;
            // 
            // AddNewGameButton
            // 
            AddNewGameButton.BackColor = Color.FromArgb(128, 128, 255);
            AddNewGameButton.Location = new Point(682, 337);
            AddNewGameButton.Margin = new Padding(3, 4, 3, 4);
            AddNewGameButton.Name = "AddNewGameButton";
            AddNewGameButton.Size = new Size(162, 44);
            AddNewGameButton.TabIndex = 5;
            AddNewGameButton.Text = "Add New Game";
            AddNewGameButton.UseVisualStyleBackColor = false;
            AddNewGameButton.Click += AddNewGameButton_Click;
            // 
            // TennisScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(912, 589);
            Controls.Add(AddNewGameButton);
            Controls.Add(LatestGamesListView);
            Controls.Add(RankingListView);
            Controls.Add(LatestGamesLable);
            Controls.Add(RankingLable);
            Controls.Add(Title);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "TennisScore";
            Text = "Score";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label RankingLable;
        private Label LatestGamesLable;
        private ListView RankingListView;
        private ListView LatestGamesListView;
        private ColumnHeader PlayerName;
        private ColumnHeader Score;
        private ColumnHeader FirstPlayer;
        private ColumnHeader SecondPlayer;
        private ColumnHeader Winner;
        private ColumnHeader WinnerScore;
        private Button AddNewGameButton;
    }
}
