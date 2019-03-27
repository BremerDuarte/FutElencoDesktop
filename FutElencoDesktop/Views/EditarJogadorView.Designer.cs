namespace FutElencoDesktop.Views
{
	partial class EditarJogadorView
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
			this.TimeComboBox = new System.Windows.Forms.ComboBox();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.PosicaoComboBox = new System.Windows.Forms.ComboBox();
			this.DataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ApelidoTextBox = new System.Windows.Forms.TextBox();
			this.NomeTextBox = new System.Windows.Forms.TextBox();
			this.SalvarButton = new System.Windows.Forms.Button();
			this.PosicaoLabel = new System.Windows.Forms.Label();
			this.DataNascimentoLabel = new System.Windows.Forms.Label();
			this.ApelidoLabel = new System.Windows.Forms.Label();
			this.NomeLabel = new System.Windows.Forms.Label();
			this.CancelarButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TimeComboBox
			// 
			this.TimeComboBox.FormattingEnabled = true;
			this.TimeComboBox.Location = new System.Drawing.Point(121, 148);
			this.TimeComboBox.Name = "TimeComboBox";
			this.TimeComboBox.Size = new System.Drawing.Size(200, 21);
			this.TimeComboBox.TabIndex = 21;
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(80, 148);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(30, 13);
			this.TimeLabel.TabIndex = 20;
			this.TimeLabel.Text = "Time";
			// 
			// PosicaoComboBox
			// 
			this.PosicaoComboBox.FormattingEnabled = true;
			this.PosicaoComboBox.Location = new System.Drawing.Point(121, 118);
			this.PosicaoComboBox.Name = "PosicaoComboBox";
			this.PosicaoComboBox.Size = new System.Drawing.Size(200, 21);
			this.PosicaoComboBox.TabIndex = 19;
			// 
			// DataNascimentoDateTimePicker
			// 
			this.DataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";
			this.DataNascimentoDateTimePicker.Location = new System.Drawing.Point(121, 92);
			this.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker";
			this.DataNascimentoDateTimePicker.Size = new System.Drawing.Size(129, 20);
			this.DataNascimentoDateTimePicker.TabIndex = 18;
			// 
			// ApelidoTextBox
			// 
			this.ApelidoTextBox.Location = new System.Drawing.Point(121, 60);
			this.ApelidoTextBox.Name = "ApelidoTextBox";
			this.ApelidoTextBox.Size = new System.Drawing.Size(304, 20);
			this.ApelidoTextBox.TabIndex = 17;
			// 
			// NomeTextBox
			// 
			this.NomeTextBox.Location = new System.Drawing.Point(121, 34);
			this.NomeTextBox.Name = "NomeTextBox";
			this.NomeTextBox.Size = new System.Drawing.Size(304, 20);
			this.NomeTextBox.TabIndex = 16;
			// 
			// SalvarButton
			// 
			this.SalvarButton.Location = new System.Drawing.Point(350, 215);
			this.SalvarButton.Name = "SalvarButton";
			this.SalvarButton.Size = new System.Drawing.Size(75, 23);
			this.SalvarButton.TabIndex = 15;
			this.SalvarButton.Text = "Salvar";
			this.SalvarButton.UseVisualStyleBackColor = true;
			this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
			// 
			// PosicaoLabel
			// 
			this.PosicaoLabel.AutoSize = true;
			this.PosicaoLabel.Location = new System.Drawing.Point(70, 118);
			this.PosicaoLabel.Name = "PosicaoLabel";
			this.PosicaoLabel.Size = new System.Drawing.Size(45, 13);
			this.PosicaoLabel.TabIndex = 14;
			this.PosicaoLabel.Text = "Posição";
			// 
			// DataNascimentoLabel
			// 
			this.DataNascimentoLabel.AutoSize = true;
			this.DataNascimentoLabel.Location = new System.Drawing.Point(11, 92);
			this.DataNascimentoLabel.Name = "DataNascimentoLabel";
			this.DataNascimentoLabel.Size = new System.Drawing.Size(104, 13);
			this.DataNascimentoLabel.TabIndex = 13;
			this.DataNascimentoLabel.Text = "Data de Nascimento";
			// 
			// ApelidoLabel
			// 
			this.ApelidoLabel.AutoSize = true;
			this.ApelidoLabel.Location = new System.Drawing.Point(73, 64);
			this.ApelidoLabel.Name = "ApelidoLabel";
			this.ApelidoLabel.Size = new System.Drawing.Size(42, 13);
			this.ApelidoLabel.TabIndex = 12;
			this.ApelidoLabel.Text = "Apelido";
			// 
			// NomeLabel
			// 
			this.NomeLabel.AutoSize = true;
			this.NomeLabel.Location = new System.Drawing.Point(80, 37);
			this.NomeLabel.Name = "NomeLabel";
			this.NomeLabel.Size = new System.Drawing.Size(35, 13);
			this.NomeLabel.TabIndex = 11;
			this.NomeLabel.Text = "Nome";
			// 
			// CancelarButton
			// 
			this.CancelarButton.Location = new System.Drawing.Point(432, 215);
			this.CancelarButton.Name = "CancelarButton";
			this.CancelarButton.Size = new System.Drawing.Size(75, 23);
			this.CancelarButton.TabIndex = 22;
			this.CancelarButton.Text = "Cancelar";
			this.CancelarButton.UseVisualStyleBackColor = true;
			this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
			// 
			// EditarJogadorView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 241);
			this.Controls.Add(this.CancelarButton);
			this.Controls.Add(this.TimeComboBox);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.PosicaoComboBox);
			this.Controls.Add(this.DataNascimentoDateTimePicker);
			this.Controls.Add(this.ApelidoTextBox);
			this.Controls.Add(this.NomeTextBox);
			this.Controls.Add(this.SalvarButton);
			this.Controls.Add(this.PosicaoLabel);
			this.Controls.Add(this.DataNascimentoLabel);
			this.Controls.Add(this.ApelidoLabel);
			this.Controls.Add(this.NomeLabel);
			this.Name = "EditarJogadorView";
			this.Text = "Editar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox TimeComboBox;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.ComboBox PosicaoComboBox;
		private System.Windows.Forms.DateTimePicker DataNascimentoDateTimePicker;
		private System.Windows.Forms.TextBox ApelidoTextBox;
		private System.Windows.Forms.TextBox NomeTextBox;
		private System.Windows.Forms.Button SalvarButton;
		private System.Windows.Forms.Label PosicaoLabel;
		private System.Windows.Forms.Label DataNascimentoLabel;
		private System.Windows.Forms.Label ApelidoLabel;
		private System.Windows.Forms.Label NomeLabel;
		private System.Windows.Forms.Button CancelarButton;
	}
}