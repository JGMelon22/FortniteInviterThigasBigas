namespace LibersLobersThiagones;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        progressBarPensando = new System.Windows.Forms.ProgressBar();
        gerarButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // richTextBox1
        // 
        richTextBox1.Enabled = false;
        richTextBox1.Location = new System.Drawing.Point(86, 29);
        richTextBox1.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(282, 119);
        richTextBox1.TabIndex = 5;
        richTextBox1.Text = ("let thiagaoRespondeu: boolean = false;\n\ndo {\n    console.log(\'Ué\');\n} while (thia" + "gaoRespondeu == false);");
        richTextBox1.Visible = false;
        // 
        // progressBarPensando
        // 
        progressBarPensando.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
        progressBarPensando.Location = new System.Drawing.Point(86, 213);
        progressBarPensando.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
        progressBarPensando.MarqueeAnimationSpeed = 70;
        progressBarPensando.Name = "progressBarPensando";
        progressBarPensando.Size = new System.Drawing.Size(282, 44);
        progressBarPensando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
        progressBarPensando.TabIndex = 4;
        progressBarPensando.Visible = false;
        // 
        // gerarButton
        // 
        gerarButton.Cursor = System.Windows.Forms.Cursors.Hand;
        gerarButton.Location = new System.Drawing.Point(86, 158);
        gerarButton.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
        gerarButton.Name = "gerarButton";
        gerarButton.Size = new System.Drawing.Size(282, 44);
        gerarButton.TabIndex = 3;
        gerarButton.Text = "Gerar Convite";
        gerarButton.UseVisualStyleBackColor = true;
        gerarButton.Click += gerarButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(447, 300);
        Controls.Add(richTextBox1);
        Controls.Add(progressBarPensando);
        Controls.Add(gerarButton);
        Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Gerador de convite Fortinite";
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.ProgressBar progressBarPensando;

    private System.Windows.Forms.Button gerarButton;

    #endregion
}