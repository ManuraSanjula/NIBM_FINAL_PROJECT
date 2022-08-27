namespace NIBM_FINAL_PROJECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.GetHealthInfo = new System.Windows.Forms.Button();
            this.UpdateHealthStatus = new System.Windows.Forms.Button();
            this.DeleteHealthRecords = new System.Windows.Forms.Button();
            this.AddFood = new System.Windows.Forms.Button();
            this.AddHealthInformation = new System.Windows.Forms.Button();
            this.FindsFood = new System.Windows.Forms.Button();
            this.DeleteFoods = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateFoods = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Name = "label2";
            // 
            // GetHealthInfo
            // 
            this.GetHealthInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.GetHealthInfo, "GetHealthInfo");
            this.GetHealthInfo.Name = "GetHealthInfo";
            this.GetHealthInfo.UseVisualStyleBackColor = false;
            this.GetHealthInfo.Click += new System.EventHandler(this.GetHealthInfo_Click);
            // 
            // UpdateHealthStatus
            // 
            this.UpdateHealthStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.UpdateHealthStatus, "UpdateHealthStatus");
            this.UpdateHealthStatus.Name = "UpdateHealthStatus";
            this.UpdateHealthStatus.UseVisualStyleBackColor = false;
            this.UpdateHealthStatus.Click += new System.EventHandler(this.UpdateHealthStatus_Click);
            // 
            // DeleteHealthRecords
            // 
            this.DeleteHealthRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.DeleteHealthRecords, "DeleteHealthRecords");
            this.DeleteHealthRecords.Name = "DeleteHealthRecords";
            this.DeleteHealthRecords.UseVisualStyleBackColor = false;
            this.DeleteHealthRecords.Click += new System.EventHandler(this.DeleteHealthRecords_Click);
            // 
            // AddFood
            // 
            this.AddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.AddFood, "AddFood");
            this.AddFood.Name = "AddFood";
            this.AddFood.UseVisualStyleBackColor = false;
            // 
            // AddHealthInformation
            // 
            this.AddHealthInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.AddHealthInformation, "AddHealthInformation");
            this.AddHealthInformation.Name = "AddHealthInformation";
            this.AddHealthInformation.UseVisualStyleBackColor = false;
            this.AddHealthInformation.Click += new System.EventHandler(this.AddHealthInformation_Click);
            // 
            // FindsFood
            // 
            this.FindsFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.FindsFood, "FindsFood");
            this.FindsFood.Name = "FindsFood";
            this.FindsFood.UseVisualStyleBackColor = false;
            // 
            // DeleteFoods
            // 
            this.DeleteFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.DeleteFoods, "DeleteFoods");
            this.DeleteFoods.Name = "DeleteFoods";
            this.DeleteFoods.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateFoods
            // 
            this.UpdateFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.UpdateFoods, "UpdateFoods");
            this.UpdateFoods.Name = "UpdateFoods";
            this.UpdateFoods.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateFoods);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteFoods);
            this.Controls.Add(this.FindsFood);
            this.Controls.Add(this.AddHealthInformation);
            this.Controls.Add(this.AddFood);
            this.Controls.Add(this.DeleteHealthRecords);
            this.Controls.Add(this.UpdateHealthStatus);
            this.Controls.Add(this.GetHealthInfo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetHealthInfo;
        private System.Windows.Forms.Button UpdateHealthStatus;
        private System.Windows.Forms.Button DeleteHealthRecords;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.Button AddHealthInformation;
        private System.Windows.Forms.Button FindsFood;
        private System.Windows.Forms.Button DeleteFoods;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpdateFoods;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

