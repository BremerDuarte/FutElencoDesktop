namespace FutElencoDesktop.Views
{
	partial class CadastroJogadorView
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
			this.NomeLabel = new System.Windows.Forms.Label();
			this.ApelidoLabel = new System.Windows.Forms.Label();
			this.DataNascimentoLabel = new System.Windows.Forms.Label();
			this.PosicaoLabel = new System.Windows.Forms.Label();
			this.CadastrarButton = new System.Windows.Forms.Button();
			this.NomeTextBox = new System.Windows.Forms.TextBox();
			this.ApelidoTextBox = new System.Windows.Forms.TextBox();
			this.DataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.PosicaoComboBox = new System.Windows.Forms.ComboBox();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.TimeComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// NomeLabel
			// 
			this.NomeLabel.AutoSize = true;
			this.NomeLabel.Location = new System.Drawing.Point(81, 52);
			this.NomeLabel.Name = "NomeLabel";
			this.NomeLabel.Size = new System.Drawing.Size(35, 13);
			this.NomeLabel.TabIndex = 0;
			this.NomeLabel.Text = "Nome";
			// 
			// ApelidoLabel
			// 
			this.ApelidoLabel.AutoSize = true;
			this.ApelidoLabel.Location = new System.Drawing.Point(74, 79);
			this.ApelidoLabel.Name = "ApelidoLabel";
			this.ApelidoLabel.Size = new System.Drawing.Size(42, 13);
			this.ApelidoLabel.TabIndex = 1;
			this.ApelidoLabel.Text = "Apelido";
			// 
			// DataNascimentoLabel
			// 
			this.DataNascimentoLabel.AutoSize = true;
			this.DataNascimentoLabel.Location = new System.Drawing.Point(12, 107);
			this.DataNascimentoLabel.Name = "DataNascimentoLabel";
			this.DataNascimentoLabel.Size = new System.Drawing.Size(104, 13);
			this.DataNascimentoLabel.TabIndex = 2;
			this.DataNascimentoLabel.Text = "Data de Nascimento";
			// 
			// PosicaoLabel
			// 
			this.PosicaoLabel.AutoSize = true;
			this.PosicaoLabel.Location = new System.Drawing.Point(71, 133);
			this.PosicaoLabel.Name = "PosicaoLabel";
			this.PosicaoLabel.Size = new System.Drawing.Size(45, 13);
			this.PosicaoLabel.TabIndex = 3;
			this.PosicaoLabel.Text = "Posição";
			// 
			// CadastrarButton
			// 
			this.CadastrarButton.Location = new System.Drawing.Point(434, 224);
			this.CadastrarButton.Name = "CadastrarButton";
			this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
			this.CadastrarButton.TabIndex = 4;
			this.CadastrarButton.Text = "Cadastrar";
			this.CadastrarButton.UseVisualStyleBackColor = true;
			this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
			// 
			// NomeTextBox
			// 
			this.NomeTextBox.Location = new System.Drawing.Point(122, 49);
			this.NomeTextBox.Name = "NomeTextBox";
			this.NomeTextBox.Size = new System.Drawing.Size(304, 20);
			this.NomeTextBox.TabIndex = 5;
			// 
			// ApelidoTextBox
			// 
			this.ApelidoTextBox.Location = new System.Drawing.Point(122, 75);
			this.ApelidoTextBox.Name = "ApelidoTextBox";
			this.ApelidoTextBox.Size = new System.Drawing.Size(304, 20);
			this.ApelidoTextBox.TabIndex = 6;
			// 
			// DataNascimentoDateTimePicker
			// 
			this.DataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
			this.DataNascimentoDateTimePicker.Location = new System.Drawing.Point(122, 107);
			this.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker";
			this.DataNascimentoDateTimePicker.Size = new System.Drawing.Size(129, 20);
			this.DataNascimentoDateTimePicker.TabIndex = 7;
			// 
			// PosicaoComboBox
			// 
			this.PosicaoComboBox.FormattingEnabled = true;
			this.PosicaoComboBox.Location = new System.Drawing.Point(122, 133);
			this.PosicaoComboBox.Name = "PosicaoComboBox";
			this.PosicaoComboBox.Size = new System.Drawing.Size(200, 21);
			this.PosicaoComboBox.TabIndex = 8;
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(81, 163);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(30, 13);
			this.TimeLabel.TabIndex = 9;
			this.TimeLabel.Text = "Time";
			// 
			// TimeComboBox
			// 
			this.TimeComboBox.FormattingEnabled = true;
			this.TimeComboBox.Location = new System.Drawing.Point(122, 163);
			this.TimeComboBox.Name = "TimeComboBox";
			this.TimeComboBox.Size = new System.Drawing.Size(200, 21);
			this.TimeComboBox.TabIndex = 10;
			// 
			// CadastroJogadorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 259);
			this.Controls.Add(this.TimeComboBox);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.PosicaoComboBox);
			this.Controls.Add(this.DataNascimentoDateTimePicker);
			this.Controls.Add(this.ApelidoTextBox);
			this.Controls.Add(this.NomeTextBox);
			this.Controls.Add(this.CadastrarButton);
			this.Controls.Add(this.PosicaoLabel);
			this.Controls.Add(this.DataNascimentoLabel);
			this.Controls.Add(this.ApelidoLabel);
			this.Controls.Add(this.NomeLabel);
			this.Name = "CadastroJogadorView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NomeLabel;
		private System.Windows.Forms.Label ApelidoLabel;
		private System.Windows.Forms.Label DataNascimentoLabel;
		private System.Windows.Forms.Label PosicaoLabel;
		private System.Windows.Forms.Button CadastrarButton;
		private System.Windows.Forms.TextBox NomeTextBox;
		private System.Windows.Forms.TextBox ApelidoTextBox;
		private System.Windows.Forms.DateTimePicker DataNascimentoDateTimePicker;
		private System.Windows.Forms.ComboBox PosicaoComboBox;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.ComboBox TimeComboBox;
	}
}