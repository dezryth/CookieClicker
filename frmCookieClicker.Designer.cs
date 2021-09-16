namespace CookieClicker
{
  partial class frmCookieClicker
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookieClicker));
      this.btnBegin = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.tbClicksPerSec = new System.Windows.Forms.TextBox();
      this.lblPrompt = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.lblNumClicks = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnBegin
      // 
      this.btnBegin.Location = new System.Drawing.Point(12, 72);
      this.btnBegin.Name = "btnBegin";
      this.btnBegin.Size = new System.Drawing.Size(75, 23);
      this.btnBegin.TabIndex = 0;
      this.btnBegin.Text = "Begin";
      this.btnBegin.UseVisualStyleBackColor = true;
      this.btnBegin.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(103, 72);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // tbClicksPerSec
      // 
      this.tbClicksPerSec.Location = new System.Drawing.Point(16, 36);
      this.tbClicksPerSec.Name = "tbClicksPerSec";
      this.tbClicksPerSec.Size = new System.Drawing.Size(100, 20);
      this.tbClicksPerSec.TabIndex = 2;
      this.tbClicksPerSec.TabStop = false;
      this.tbClicksPerSec.Text = "1";
      this.tbClicksPerSec.TextChanged += new System.EventHandler(this.tbClicksPerSec_TextChanged);
      // 
      // lblPrompt
      // 
      this.lblPrompt.AutoSize = true;
      this.lblPrompt.Location = new System.Drawing.Point(12, 9);
      this.lblPrompt.Name = "lblPrompt";
      this.lblPrompt.Size = new System.Drawing.Size(149, 13);
      this.lblPrompt.TabIndex = 3;
      this.lblPrompt.Text = "How many clicks per second?";
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // lblNumClicks
      // 
      this.lblNumClicks.AutoSize = true;
      this.lblNumClicks.Location = new System.Drawing.Point(13, 108);
      this.lblNumClicks.Name = "lblNumClicks";
      this.lblNumClicks.Size = new System.Drawing.Size(45, 13);
      this.lblNumClicks.TabIndex = 4;
      this.lblNumClicks.Text = "Clicked:";
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(13, 125);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(0, 13);
      this.lblStatus.TabIndex = 5;
      // 
      // frmCookieClicker
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(230, 147);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.lblNumClicks);
      this.Controls.Add(this.lblPrompt);
      this.Controls.Add(this.tbClicksPerSec);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnBegin);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCookieClicker";
      this.Text = "CookieClicker";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbClicksPerSec;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblNumClicks;
        private System.Windows.Forms.Label lblStatus;
    }
}

