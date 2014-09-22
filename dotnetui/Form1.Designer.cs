namespace dotnetui
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
      this.txtFirstNumber = new System.Windows.Forms.TextBox();
      this.txtSecondNumber = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtFirstNumber
      // 
      this.txtFirstNumber.Location = new System.Drawing.Point(16, 29);
      this.txtFirstNumber.Name = "txtFirstNumber";
      this.txtFirstNumber.Size = new System.Drawing.Size(256, 20);
      this.txtFirstNumber.TabIndex = 0;
      // 
      // txtSecondNumber
      // 
      this.txtSecondNumber.Location = new System.Drawing.Point(16, 68);
      this.txtSecondNumber.Name = "txtSecondNumber";
      this.txtSecondNumber.Size = new System.Drawing.Size(256, 20);
      this.txtSecondNumber.TabIndex = 1;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(16, 94);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(75, 23);
      this.btnCalculate.TabIndex = 2;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.BtnCalculateClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "First number to add";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Second number to add";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 140);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Answer:";
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(16, 157);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(10, 13);
      this.lblResult.TabIndex = 6;
      this.lblResult.Text = "-";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 193);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalculate);
      this.Controls.Add(this.txtSecondNumber);
      this.Controls.Add(this.txtFirstNumber);
      this.Name = "Form1";
      this.Text = "PInvoke UI ";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtFirstNumber;
    private System.Windows.Forms.TextBox txtSecondNumber;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblResult;
  }
}

