namespace UltimateTicTacToe {
    partial class GameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InstructionsButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.GameContainer = new System.Windows.Forms.Panel();
            this.t22 = new System.Windows.Forms.PictureBox();
            this.t21 = new System.Windows.Forms.PictureBox();
            this.t20 = new System.Windows.Forms.PictureBox();
            this.t12 = new System.Windows.Forms.PictureBox();
            this.t11 = new System.Windows.Forms.PictureBox();
            this.t10 = new System.Windows.Forms.PictureBox();
            this.t02 = new System.Windows.Forms.PictureBox();
            this.t01 = new System.Windows.Forms.PictureBox();
            this.t00 = new System.Windows.Forms.PictureBox();
            this.BigTable = new System.Windows.Forms.PictureBox();
            this.CurrentTurnContainer = new System.Windows.Forms.Panel();
            this.CurrentTurnStaticLabel = new System.Windows.Forms.Label();
            this.CurrentTurnLabel = new System.Windows.Forms.Label();
            this.CurrentTurnImage = new System.Windows.Forms.PictureBox();
            this.InstructionsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.GameContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigTable)).BeginInit();
            this.CurrentTurnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTurnImage)).BeginInit();
            this.InstructionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContainer
            // 
            this.MenuContainer.Controls.Add(this.ExitButton);
            this.MenuContainer.Controls.Add(this.InstructionsButton);
            this.MenuContainer.Controls.Add(this.PlayButton);
            this.MenuContainer.Controls.Add(this.LogoLabel);
            this.MenuContainer.Controls.Add(this.LogoImage);
            this.MenuContainer.Location = new System.Drawing.Point(0, 1);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(804, 521);
            this.MenuContainer.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(207, 419);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(387, 55);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InstructionsButton
            // 
            this.InstructionsButton.Location = new System.Drawing.Point(207, 332);
            this.InstructionsButton.Name = "InstructionsButton";
            this.InstructionsButton.Size = new System.Drawing.Size(387, 55);
            this.InstructionsButton.TabIndex = 3;
            this.InstructionsButton.Text = "Instructions";
            this.InstructionsButton.UseVisualStyleBackColor = true;
            this.InstructionsButton.Click += new System.EventHandler(this.InstructionsButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(207, 271);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(387, 55);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LogoLabel.Location = new System.Drawing.Point(413, 36);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(181, 204);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Ultimate\r\nTic\r\nTac\r\nToe";
            // 
            // LogoImage
            // 
            this.LogoImage.Image = global::UltimateTicTacToe.Properties.Resources.logo;
            this.LogoImage.Location = new System.Drawing.Point(207, 36);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(200, 200);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // GameContainer
            // 
            this.GameContainer.Controls.Add(this.t22);
            this.GameContainer.Controls.Add(this.t21);
            this.GameContainer.Controls.Add(this.t20);
            this.GameContainer.Controls.Add(this.t12);
            this.GameContainer.Controls.Add(this.t11);
            this.GameContainer.Controls.Add(this.t10);
            this.GameContainer.Controls.Add(this.t02);
            this.GameContainer.Controls.Add(this.t01);
            this.GameContainer.Controls.Add(this.t00);
            this.GameContainer.Controls.Add(this.BigTable);
            this.GameContainer.Controls.Add(this.CurrentTurnContainer);
            this.GameContainer.Location = new System.Drawing.Point(0, 0);
            this.GameContainer.Name = "GameContainer";
            this.GameContainer.Size = new System.Drawing.Size(804, 521);
            this.GameContainer.TabIndex = 5;
            this.GameContainer.Visible = false;
            // 
            // t22
            // 
            this.t22.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t22.Location = new System.Drawing.Point(483, 368);
            this.t22.Name = "t22";
            this.t22.Size = new System.Drawing.Size(130, 130);
            this.t22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t22.TabIndex = 13;
            this.t22.TabStop = false;
            // 
            // t21
            // 
            this.t21.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t21.Location = new System.Drawing.Point(338, 368);
            this.t21.Name = "t21";
            this.t21.Size = new System.Drawing.Size(130, 130);
            this.t21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t21.TabIndex = 12;
            this.t21.TabStop = false;
            // 
            // t20
            // 
            this.t20.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t20.Location = new System.Drawing.Point(192, 368);
            this.t20.Name = "t20";
            this.t20.Size = new System.Drawing.Size(130, 130);
            this.t20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t20.TabIndex = 11;
            this.t20.TabStop = false;
            // 
            // t12
            // 
            this.t12.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t12.Location = new System.Drawing.Point(483, 222);
            this.t12.Name = "t12";
            this.t12.Size = new System.Drawing.Size(130, 130);
            this.t12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t12.TabIndex = 10;
            this.t12.TabStop = false;
            // 
            // t11
            // 
            this.t11.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t11.Location = new System.Drawing.Point(338, 222);
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(130, 130);
            this.t11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t11.TabIndex = 9;
            this.t11.TabStop = false;
            // 
            // t10
            // 
            this.t10.BackColor = System.Drawing.SystemColors.Control;
            this.t10.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t10.Location = new System.Drawing.Point(191, 222);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(130, 130);
            this.t10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t10.TabIndex = 8;
            this.t10.TabStop = false;
            // 
            // t02
            // 
            this.t02.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t02.Location = new System.Drawing.Point(483, 77);
            this.t02.Name = "t02";
            this.t02.Size = new System.Drawing.Size(130, 130);
            this.t02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t02.TabIndex = 7;
            this.t02.TabStop = false;
            // 
            // t01
            // 
            this.t01.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t01.Location = new System.Drawing.Point(338, 77);
            this.t01.Name = "t01";
            this.t01.Size = new System.Drawing.Size(130, 130);
            this.t01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t01.TabIndex = 6;
            this.t01.TabStop = false;
            // 
            // t00
            // 
            this.t00.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.t00.Location = new System.Drawing.Point(192, 77);
            this.t00.Name = "t00";
            this.t00.Size = new System.Drawing.Size(130, 130);
            this.t00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t00.TabIndex = 5;
            this.t00.TabStop = false;
            // 
            // BigTable
            // 
            this.BigTable.Image = global::UltimateTicTacToe.Properties.Resources.table;
            this.BigTable.Location = new System.Drawing.Point(190, 75);
            this.BigTable.Name = "BigTable";
            this.BigTable.Size = new System.Drawing.Size(425, 425);
            this.BigTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigTable.TabIndex = 4;
            this.BigTable.TabStop = false;
            // 
            // CurrentTurnContainer
            // 
            this.CurrentTurnContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CurrentTurnContainer.Controls.Add(this.CurrentTurnStaticLabel);
            this.CurrentTurnContainer.Controls.Add(this.CurrentTurnLabel);
            this.CurrentTurnContainer.Controls.Add(this.CurrentTurnImage);
            this.CurrentTurnContainer.Location = new System.Drawing.Point(0, 0);
            this.CurrentTurnContainer.Name = "CurrentTurnContainer";
            this.CurrentTurnContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentTurnContainer.Size = new System.Drawing.Size(804, 51);
            this.CurrentTurnContainer.TabIndex = 3;
            // 
            // CurrentTurnStaticLabel
            // 
            this.CurrentTurnStaticLabel.AutoSize = true;
            this.CurrentTurnStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTurnStaticLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentTurnStaticLabel.Location = new System.Drawing.Point(356, 6);
            this.CurrentTurnStaticLabel.Name = "CurrentTurnStaticLabel";
            this.CurrentTurnStaticLabel.Size = new System.Drawing.Size(97, 13);
            this.CurrentTurnStaticLabel.TabIndex = 2;
            this.CurrentTurnStaticLabel.Text = "CURRENT TURN:";
            this.CurrentTurnStaticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentTurnLabel
            // 
            this.CurrentTurnLabel.AutoSize = true;
            this.CurrentTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTurnLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentTurnLabel.Location = new System.Drawing.Point(352, 20);
            this.CurrentTurnLabel.Name = "CurrentTurnLabel";
            this.CurrentTurnLabel.Size = new System.Drawing.Size(165, 26);
            this.CurrentTurnLabel.TabIndex = 1;
            this.CurrentTurnLabel.Text = "BLUE PLAYER";
            this.CurrentTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentTurnImage
            // 
            this.CurrentTurnImage.Image = global::UltimateTicTacToe.Properties.Resources.o;
            this.CurrentTurnImage.Location = new System.Drawing.Point(309, 6);
            this.CurrentTurnImage.Name = "CurrentTurnImage";
            this.CurrentTurnImage.Size = new System.Drawing.Size(40, 40);
            this.CurrentTurnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentTurnImage.TabIndex = 0;
            this.CurrentTurnImage.TabStop = false;
            // 
            // InstructionsPanel
            // 
            this.InstructionsPanel.Controls.Add(this.label2);
            this.InstructionsPanel.Controls.Add(this.button1);
            this.InstructionsPanel.Controls.Add(this.label1);
            this.InstructionsPanel.Location = new System.Drawing.Point(1, 0);
            this.InstructionsPanel.Name = "InstructionsPanel";
            this.InstructionsPanel.Size = new System.Drawing.Size(804, 522);
            this.InstructionsPanel.TabIndex = 14;
            this.InstructionsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTRUCTIONS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackButton_Clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Win three small boards in order to win the big board.\r\nYour opponent\'s previous m" +
    "ove determines in which small board\r\nyou must play your next move.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 522);
            this.Controls.Add(this.GameContainer);
            this.Controls.Add(this.InstructionsPanel);
            this.Controls.Add(this.MenuContainer);
            this.Name = "GameForm";
            this.Text = "Ultimate Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.MenuContainer.ResumeLayout(false);
            this.MenuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.GameContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigTable)).EndInit();
            this.CurrentTurnContainer.ResumeLayout(false);
            this.CurrentTurnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTurnImage)).EndInit();
            this.InstructionsPanel.ResumeLayout(false);
            this.InstructionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuContainer;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button InstructionsButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel GameContainer;
        private System.Windows.Forms.Label CurrentTurnLabel;
        private System.Windows.Forms.PictureBox CurrentTurnImage;
        private System.Windows.Forms.Label CurrentTurnStaticLabel;
        private System.Windows.Forms.Panel CurrentTurnContainer;
        private System.Windows.Forms.PictureBox BigTable;
        private System.Windows.Forms.PictureBox t00;
        private System.Windows.Forms.PictureBox t22;
        private System.Windows.Forms.PictureBox t21;
        private System.Windows.Forms.PictureBox t20;
        private System.Windows.Forms.PictureBox t12;
        private System.Windows.Forms.PictureBox t11;
        private System.Windows.Forms.PictureBox t10;
        private System.Windows.Forms.PictureBox t02;
        private System.Windows.Forms.PictureBox t01;
        private System.Windows.Forms.Panel InstructionsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}