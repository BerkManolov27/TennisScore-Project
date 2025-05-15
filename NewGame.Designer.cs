namespace TennisScoreApp
{
    partial class NewGame
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
            components = new System.ComponentModel.Container();
            NewGameTitle = new Label();
            FirstPlayerLabel = new Label();
            FirstPlayerPointsLabel = new Label();
            SecondPlayerPointsLabel = new Label();
            SecondPlayerLabel = new Label();
            FirstPlayerTextBox = new TextBox();
            SecondPlayerTextBox = new TextBox();
            FirstPlayerPoints = new NumericUpDown();
            SecondPlayerPoints = new NumericUpDown();
            SaveButton = new Button();
            VsLabel = new Label();
            FirstPlayerNameErrorProvider = new ErrorProvider(components);
            FirstPlayerNameErrorLabel = new Label();
            SecondPlayerNameErrorProvider = new ErrorProvider(components);
            SecondPlayerNameErrorLabel = new Label();
            SameNamesErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstPlayerNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerNameErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // NewGameTitle
            // 
            NewGameTitle.AutoSize = true;
            NewGameTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            NewGameTitle.Location = new Point(326, 50);
            NewGameTitle.Name = "NewGameTitle";
            NewGameTitle.Size = new Size(234, 60);
            NewGameTitle.TabIndex = 0;
            NewGameTitle.Text = "New game";
            // 
            // FirstPlayerLabel
            // 
            FirstPlayerLabel.AutoSize = true;
            FirstPlayerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerLabel.Location = new Point(154, 133);
            FirstPlayerLabel.Name = "FirstPlayerLabel";
            FirstPlayerLabel.Size = new Size(107, 28);
            FirstPlayerLabel.TabIndex = 1;
            FirstPlayerLabel.Text = "First Player";
            // 
            // FirstPlayerPointsLabel
            // 
            FirstPlayerPointsLabel.AutoSize = true;
            FirstPlayerPointsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerPointsLabel.Location = new Point(88, 313);
            FirstPlayerPointsLabel.Name = "FirstPlayerPointsLabel";
            FirstPlayerPointsLabel.Size = new Size(65, 28);
            FirstPlayerPointsLabel.TabIndex = 3;
            FirstPlayerPointsLabel.Text = "Points";
            // 
            // SecondPlayerPointsLabel
            // 
            SecondPlayerPointsLabel.AutoSize = true;
            SecondPlayerPointsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerPointsLabel.Location = new Point(595, 315);
            SecondPlayerPointsLabel.Name = "SecondPlayerPointsLabel";
            SecondPlayerPointsLabel.Size = new Size(65, 28);
            SecondPlayerPointsLabel.TabIndex = 4;
            SecondPlayerPointsLabel.Text = "Points";
            // 
            // SecondPlayerLabel
            // 
            SecondPlayerLabel.AutoSize = true;
            SecondPlayerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerLabel.Location = new Point(641, 133);
            SecondPlayerLabel.Name = "SecondPlayerLabel";
            SecondPlayerLabel.Size = new Size(135, 28);
            SecondPlayerLabel.TabIndex = 2;
            SecondPlayerLabel.Text = "Second Player";
            SecondPlayerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // FirstPlayerTextBox
            // 
            FirstPlayerTextBox.BackColor = Color.DarkOrange;
            FirstPlayerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstPlayerTextBox.Location = new Point(41, 165);
            FirstPlayerTextBox.Margin = new Padding(3, 4, 3, 4);
            FirstPlayerTextBox.Name = "FirstPlayerTextBox";
            FirstPlayerTextBox.Size = new Size(339, 34);
            FirstPlayerTextBox.TabIndex = 1;
            FirstPlayerTextBox.Validating += ValidatePlayerName;
            // 
            // SecondPlayerTextBox
            // 
            SecondPlayerTextBox.BackColor = Color.DarkOrange;
            SecondPlayerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SecondPlayerTextBox.Location = new Point(528, 165);
            SecondPlayerTextBox.Margin = new Padding(3, 4, 3, 4);
            SecondPlayerTextBox.Name = "SecondPlayerTextBox";
            SecondPlayerTextBox.Size = new Size(339, 34);
            SecondPlayerTextBox.TabIndex = 2;
            SecondPlayerTextBox.Validating += ValidatePlayerName;
            // 
            // FirstPlayerPoints
            // 
            FirstPlayerPoints.BackColor = Color.DarkOrange;
            FirstPlayerPoints.Location = new Point(154, 315);
            FirstPlayerPoints.Margin = new Padding(3, 4, 3, 4);
            FirstPlayerPoints.Name = "FirstPlayerPoints";
            FirstPlayerPoints.Size = new Size(137, 27);
            FirstPlayerPoints.TabIndex = 3;
            // 
            // SecondPlayerPoints
            // 
            SecondPlayerPoints.BackColor = Color.DarkOrange;
            SecondPlayerPoints.Location = new Point(662, 317);
            SecondPlayerPoints.Margin = new Padding(3, 4, 3, 4);
            SecondPlayerPoints.Name = "SecondPlayerPoints";
            SecondPlayerPoints.Size = new Size(137, 27);
            SecondPlayerPoints.TabIndex = 4;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.HotTrack;
            SaveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(352, 439);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(208, 69);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // VsLabel
            // 
            VsLabel.AutoSize = true;
            VsLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            VsLabel.Location = new Point(410, 295);
            VsLabel.Name = "VsLabel";
            VsLabel.Size = new Size(104, 81);
            VsLabel.TabIndex = 10;
            VsLabel.Text = "VS";
            // 
            // FirstPlayerNameErrorProvider
            // 
            FirstPlayerNameErrorProvider.ContainerControl = this;
            // 
            // FirstPlayerNameErrorLabel
            // 
            FirstPlayerNameErrorLabel.AutoSize = true;
            FirstPlayerNameErrorLabel.ForeColor = Color.Red;
            FirstPlayerNameErrorLabel.Location = new Point(41, 208);
            FirstPlayerNameErrorLabel.Name = "FirstPlayerNameErrorLabel";
            FirstPlayerNameErrorLabel.Size = new Size(0, 20);
            FirstPlayerNameErrorLabel.TabIndex = 11;
            // 
            // SecondPlayerNameErrorProvider
            // 
            SecondPlayerNameErrorProvider.ContainerControl = this;
            // 
            // SecondPlayerNameErrorLabel
            // 
            SecondPlayerNameErrorLabel.AutoSize = true;
            SecondPlayerNameErrorLabel.ForeColor = Color.Red;
            SecondPlayerNameErrorLabel.Location = new Point(528, 208);
            SecondPlayerNameErrorLabel.Name = "SecondPlayerNameErrorLabel";
            SecondPlayerNameErrorLabel.Size = new Size(0, 20);
            SecondPlayerNameErrorLabel.TabIndex = 12;
            // 
            // SameNamesErrorLabel
            // 
            SameNamesErrorLabel.AutoSize = true;
            SameNamesErrorLabel.ForeColor = Color.Red;
            SameNamesErrorLabel.Location = new Point(277, 228);
            SameNamesErrorLabel.Name = "SameNamesErrorLabel";
            SameNamesErrorLabel.Size = new Size(0, 20);
            SameNamesErrorLabel.TabIndex = 13;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(914, 600);
            Controls.Add(SameNamesErrorLabel);
            Controls.Add(SecondPlayerNameErrorLabel);
            Controls.Add(FirstPlayerNameErrorLabel);
            Controls.Add(VsLabel);
            Controls.Add(SaveButton);
            Controls.Add(SecondPlayerPoints);
            Controls.Add(FirstPlayerPoints);
            Controls.Add(SecondPlayerTextBox);
            Controls.Add(FirstPlayerTextBox);
            Controls.Add(SecondPlayerPointsLabel);
            Controls.Add(FirstPlayerPointsLabel);
            Controls.Add(SecondPlayerLabel);
            Controls.Add(FirstPlayerLabel);
            Controls.Add(NewGameTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewGame";
            Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)FirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstPlayerNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerNameErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewGameTitle;
        private Label FirstPlayerLabel;
        private Label FirstPlayerPointsLabel;
        private Label SecondPlayerPointsLabel;
        private Label SecondPlayerLabel;
        private TextBox FirstPlayerTextBox;
        private TextBox SecondPlayerTextBox;
        private NumericUpDown FirstPlayerPoints;
        private NumericUpDown SecondPlayerPoints;
        private Button SaveButton;
        private Label VsLabel;
        private ErrorProvider FirstPlayerNameErrorProvider;
        private Label FirstPlayerNameErrorLabel;
        private ErrorProvider SecondPlayerNameErrorProvider;
        private Label SecondPlayerNameErrorLabel;
        private Label SameNamesErrorLabel;
    }
}