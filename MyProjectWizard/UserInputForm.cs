using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectTemplatePepWizard
{
  public partial class UserInputForm : Form
  {
    private TextBox txtPrefixo;
    private TextBox txtDominio;
    private Label label2;
    private Button button1;
    private TrackBar tkbQtdPrefixo;
    private Label label3;
    private Label label4;
    private TextBox txtVersao;
    private Label label1;

    public Dictionary<string, string> ReplacementsDictionary { get; set; }
    private string NomeProjeto { get; set; }
    public UserInputForm()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.txtPrefixo = new System.Windows.Forms.TextBox();
      this.txtDominio = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.tkbQtdPrefixo = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtVersao = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.tkbQtdPrefixo)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPrefixo
      // 
      this.txtPrefixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtPrefixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPrefixo.Cursor = System.Windows.Forms.Cursors.No;
      this.txtPrefixo.Enabled = false;
      this.txtPrefixo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.txtPrefixo.Location = new System.Drawing.Point(14, 36);
      this.txtPrefixo.Name = "txtPrefixo";
      this.txtPrefixo.ReadOnly = true;
      this.txtPrefixo.Size = new System.Drawing.Size(99, 20);
      this.txtPrefixo.TabIndex = 0;
      // 
      // txtDominio
      // 
      this.txtDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtDominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDominio.Cursor = System.Windows.Forms.Cursors.No;
      this.txtDominio.Enabled = false;
      this.txtDominio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.txtDominio.Location = new System.Drawing.Point(121, 36);
      this.txtDominio.Name = "txtDominio";
      this.txtDominio.ReadOnly = true;
      this.txtDominio.Size = new System.Drawing.Size(122, 20);
      this.txtDominio.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label1.Location = new System.Drawing.Point(11, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Prefixo";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label2.Location = new System.Drawing.Point(11, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Qtd. Prefixo";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.button1.Location = new System.Drawing.Point(247, 132);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 12;
      this.button1.Text = "Criar";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tkbQtdPrefixo
      // 
      this.tkbQtdPrefixo.Location = new System.Drawing.Point(6, 85);
      this.tkbQtdPrefixo.Maximum = 4;
      this.tkbQtdPrefixo.Minimum = 1;
      this.tkbQtdPrefixo.Name = "tkbQtdPrefixo";
      this.tkbQtdPrefixo.Size = new System.Drawing.Size(316, 45);
      this.tkbQtdPrefixo.TabIndex = 2;
      this.tkbQtdPrefixo.Value = 2;
      this.tkbQtdPrefixo.Scroll += new System.EventHandler(this.tkbQtdPrefixo_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label3.Location = new System.Drawing.Point(118, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Dominio";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.label4.Location = new System.Drawing.Point(245, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Versão";
      // 
      // txtVersao
      // 
      this.txtVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
      this.txtVersao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.txtVersao.Location = new System.Drawing.Point(247, 36);
      this.txtVersao.Name = "txtVersao";
      this.txtVersao.Size = new System.Drawing.Size(67, 20);
      this.txtVersao.TabIndex = 1;
      this.txtVersao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVersao_KeyDown);
      // 
      // UserInputForm
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.ClientSize = new System.Drawing.Size(337, 166);
      this.ControlBox = false;
      this.Controls.Add(this.txtVersao);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tkbQtdPrefixo);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDominio);
      this.Controls.Add(this.txtPrefixo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "UserInputForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Load += new System.EventHandler(this.UserInputForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tkbQtdPrefixo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      CriarProjeto();
    }

    private void CriarProjeto()
    {
      if (string.IsNullOrWhiteSpace(txtVersao.Text))
      {
        txtVersao.Focus();
        txtVersao.BackColor = Color.PapayaWhip;
        txtVersao.ForeColor = Color.Black;
        return;
      }

      ReplacementsDictionary.Add("$versao$", txtVersao.Text);
      Close();
    }

    private void UserInputForm_Load(object sender, EventArgs e)
    {
      NomeProjeto = ReplacementsDictionary["$safeprojectname$"];
      DefinirVariaveisTemplate();
    }

    private void DefinirVariaveisTemplate()
    {
      string prefixo = string.Empty;
      string dominio = string.Empty;
      string instanciaDominio = string.Empty;

      if (NomeProjeto.Contains("."))
      {

        string padrao = @"(([^.]*\.){" + tkbQtdPrefixo.Value + "})([^.]+)";

        Match match = Regex.Match(NomeProjeto, padrao);

        if (match.Groups.Count > 1)
          prefixo = match.Groups[1].Value.TrimEnd('.');

        if (match.Groups.Count > 3)
          dominio = match.Groups[3].Value;
      }

      if (!string.IsNullOrEmpty(dominio))
      {
        instanciaDominio = char.ToLower(dominio[0]).ToString();

        if (dominio.Length > 1)
          instanciaDominio += dominio.Substring(1);
      }

      ReplacementsDictionary["$prefixoprojeto$"] = prefixo;
      ReplacementsDictionary["$dominio$"] = dominio;
      ReplacementsDictionary["$instanciadominio$"] = instanciaDominio;

      txtPrefixo.Text = prefixo;
      txtDominio.Text = dominio;
    }

    private void tkbQtdPrefixo_Scroll(object sender, EventArgs e)
    {
      DefinirVariaveisTemplate();
    }

    private void txtVersao_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        CriarProjeto();
      }
    }
  }
}