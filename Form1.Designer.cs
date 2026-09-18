    namespace SistemaUsuarios;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        txtLogin = new TextBox();
        txtSenha = new TextBox();
        btnEntrar = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(635, 47);
        label1.Name = "label1";
        label1.Size = new Size(46, 20);
        label1.TabIndex = 0;
        label1.Text = "Login";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(635, 104);
        label2.Name = "label2";
        label2.Size = new Size(59, 20);
        label2.TabIndex = 1;
        label2.Text = "Usuário";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(645, 204);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 2;
        label3.Text = "Senha";
        // 
        // txtLogin
        // 
        txtLogin.Location = new Point(604, 142);
        txtLogin.Name = "txtLogin";
        txtLogin.Size = new Size(125, 27);
        txtLogin.TabIndex = 3;
        // 
        // txtSenha
        // 
        txtSenha.Location = new Point(604, 253);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(125, 27);
        txtSenha.TabIndex = 4;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // btnEntrar
        // 
        btnEntrar.Location = new Point(621, 355);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(94, 29);
        btnEntrar.TabIndex = 5;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = true;
        btnEntrar.Click += btnEntrar_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.InactiveBorder;
        ClientSize = new Size(1360, 671);
        Controls.Add(btnEntrar);
        Controls.Add(txtSenha);
        Controls.Add(txtLogin);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Login";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtLogin;
    private TextBox txtSenha;
    private Button btnEntrar;
}
