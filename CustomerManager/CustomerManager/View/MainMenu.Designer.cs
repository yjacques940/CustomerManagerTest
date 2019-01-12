namespace CustomerManager
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.appointmentManagerButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.welcolmeMessage = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appointmentManagerButton
            // 
            this.appointmentManagerButton.BackgroundImage = global::CustomerManager.Properties.Resources.baseline_access_time_black_18dp;
            this.appointmentManagerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.appointmentManagerButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentManagerButton.Location = new System.Drawing.Point(110, 93);
            this.appointmentManagerButton.Name = "appointmentManagerButton";
            this.appointmentManagerButton.Size = new System.Drawing.Size(87, 72);
            this.appointmentManagerButton.TabIndex = 0;
            this.appointmentManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.appointmentManagerButton.UseVisualStyleBackColor = true;
            this.appointmentManagerButton.Click += new System.EventHandler(this.appointmentManagerButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackgroundImage = global::CustomerManager.Properties.Resources.baseline_search_black_18dp;
            this.searchCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchCustomerButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerButton.Location = new System.Drawing.Point(302, 93);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(87, 72);
            this.searchCustomerButton.TabIndex = 1;
            this.searchCustomerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            // 
            // emailButton
            // 
            this.emailButton.BackgroundImage = global::CustomerManager.Properties.Resources.baseline_email_black_18dp;
            this.emailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.emailButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(110, 231);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(87, 72);
            this.emailButton.TabIndex = 2;
            this.emailButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // welcolmeMessage
            // 
            this.welcolmeMessage.AutoSize = true;
            this.welcolmeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcolmeMessage.Location = new System.Drawing.Point(12, 9);
            this.welcolmeMessage.Name = "welcolmeMessage";
            this.welcolmeMessage.Size = new System.Drawing.Size(151, 16);
            this.welcolmeMessage.TabIndex = 3;
            this.welcolmeMessage.Text = "[welcolme message]";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(516, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 15);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "[date]";
            // 
            // dateTimeTimer
            // 
            this.dateTimeTimer.Interval = 1000;
            this.dateTimeTimer.Tick += new System.EventHandler(this.dateTimeTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion des rendez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rechercher un client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(107, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Envoyer un courriel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ajouter un client";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackgroundImage = global::CustomerManager.Properties.Resources.AddPersonIcon;
            this.addCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addCustomerButton.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(487, 93);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(87, 72);
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CustomerManager.Properties.Resources.loggingBackground19201080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.welcolmeMessage);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.searchCustomerButton);
            this.Controls.Add(this.appointmentManagerButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(704, 455);
            this.MinimumSize = new System.Drawing.Size(704, 455);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointmentManagerButton;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Label welcolmeMessage;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer dateTimeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCustomerButton;
    }
}