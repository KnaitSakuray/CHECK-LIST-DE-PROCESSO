
namespace LED_EPL.Forms.Private
{
    partial class RJMessageForm
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
            this.pnlMessageText = new System.Windows.Forms.Panel();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pbIcon = new FontAwesome.Sharp.IconPictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlTittleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnlMessageText.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlTittleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMessageText
            // 
            this.pnlMessageText.AutoScroll = true;
            this.pnlMessageText.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessageText.Controls.Add(this.lblMessageText);
            this.pnlMessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessageText.Location = new System.Drawing.Point(50, 40);
            this.pnlMessageText.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMessageText.Name = "pnlMessageText";
            this.pnlMessageText.Size = new System.Drawing.Size(355, 65);
            this.pnlMessageText.TabIndex = 20;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMessageText.Location = new System.Drawing.Point(0, 0);
            this.lblMessageText.MaximumSize = new System.Drawing.Size(345, 0);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Padding = new System.Windows.Forms.Padding(5, 22, 0, 22);
            this.lblMessageText.Size = new System.Drawing.Size(54, 61);
            this.lblMessageText.TabIndex = 1;
            this.lblMessageText.Text = "lblText";
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlIcon.Controls.Add(this.pbIcon);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIcon.Location = new System.Drawing.Point(0, 40);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(50, 65);
            this.pnlIcon.TabIndex = 21;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.pbIcon.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.pbIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.pbIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbIcon.IconSize = 40;
            this.pbIcon.Location = new System.Drawing.Point(7, 20);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(40, 40);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 105);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(405, 60);
            this.pnlButtons.TabIndex = 19;
            // 
            // pnlTittleBar
            // 
            this.pnlTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.pnlTittleBar.Controls.Add(this.btnExit);
            this.pnlTittleBar.Controls.Add(this.lblCaption);
            this.pnlTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTittleBar.Name = "pnlTittleBar";
            this.pnlTittleBar.Size = new System.Drawing.Size(405, 40);
            this.pnlTittleBar.TabIndex = 18;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::CHECK_LIST_DE_PROCESSO.Properties.Resources.CloseWhite;
            this.btnExit.Location = new System.Drawing.Point(365, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCaption.Location = new System.Drawing.Point(13, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(56, 17);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Caption";
            // 
            // RJMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 165);
            this.Controls.Add(this.pnlMessageText);
            this.Controls.Add(this.pnlIcon);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTittleBar);
            this.MaximumSize = new System.Drawing.Size(800, 650);
            this.MinimumSize = new System.Drawing.Size(405, 165);
            this.Name = "RJMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RJMessageForm";
            this.Load += new System.EventHandler(this.RJMessageForm_Load);
            this.pnlMessageText.ResumeLayout(false);
            this.pnlMessageText.PerformLayout();
            this.pnlIcon.ResumeLayout(false);
            this.pnlIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlTittleBar.ResumeLayout(false);
            this.pnlTittleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMessageText;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.Panel pnlIcon;
        private FontAwesome.Sharp.IconPictureBox pbIcon;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlTittleBar;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCaption;
    }
}