
namespace Quadris {
  partial class FrmMain {
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
      this.components = new System.ComponentModel.Container();
      this.panBoard = new System.Windows.Forms.Panel();
      this.tmrFps = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // panBoard
      // 
      this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.panBoard.Location = new System.Drawing.Point(176, 51);
      this.panBoard.Name = "panBoard";
      this.panBoard.Size = new System.Drawing.Size(292, 355);
      this.panBoard.TabIndex = 1;
      // 
      // tmrFps
      // 
      this.tmrFps.Enabled = true;
      this.tmrFps.Interval = 17;
      this.tmrFps.Tick += new System.EventHandler(this.tmrFps_Tick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(770, 689);
      this.Controls.Add(this.panBoard);
      this.Name = "FrmMain";
      this.Text = "Quadris!";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panBoard;
    private System.Windows.Forms.Timer tmrFps;
  }
}

