namespace FutElencoDesktop.Views
{
	partial class EditarTimeView
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
			this.CancelarButton = new System.Windows.Forms.Button();
			this.SalvarButton = new System.Windows.Forms.Button();
			this.SiglaTextBox = new System.Windows.Forms.TextBox();
			this.NomeTextBox = new System.Windows.Forms.TextBox();
			this.NomeComplexoTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelarButton
			// 
			this.CancelarButton.Location = new System.Drawing.Point(260, 121);
			this.CancelarButton.Name = "CancelarButton";
			this.CancelarButton.Size = new System.Drawing.Size(75, 23);
			this.CancelarButton.TabIndex = 15;
			this.CancelarButton.Text = "Cancelar";
			this.CancelarButton.UseVisualStyleBackColor = true;
			this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
			// 
			// SalvarButton
			// 
			this.SalvarButton.Location = new System.Drawing.Point(179, 121);
			this.SalvarButton.Name = "SalvarButton";
			this.SalvarButton.Size = new System.Drawing.Size(75, 23);
			this.SalvarButton.TabIndex = 14;
			this.SalvarButton.Text = "Salvar";
			this.SalvarButton.UseVisualStyleBackColor = true;
			this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
			// 
			// SiglaTextBox
			// 
			this.SiglaTextBox.Location = new System.Drawing.Point(100, 74);
			this.SiglaTextBox.Name = "SiglaTextBox";
			this.SiglaTextBox.Size = new System.Drawing.Size(235, 20);
			this.SiglaTextBox.TabIndex = 13;
			// 
			// NomeTextBox
			// 
			this.NomeTextBox.Location = new System.Drawing.Point(100, 45);
			this.NomeTextBox.Name = "NomeTextBox";
			this.NomeTextBox.Size = new System.Drawing.Size(235, 20);
			this.NomeTextBox.TabIndex = 12;
			// 
			// NomeComplexoTextBox
			// 
			this.NomeComplexoTextBox.Location = new System.Drawing.Point(100, 17);
			this.NomeComplexoTextBox.Name = "NomeComplexoTextBox";
			this.NomeComplexoTextBox.Size = new System.Drawing.Size(235, 20);
			this.NomeComplexoTextBox.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Sigla";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nome";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nome Completo";
			// 
			// EditarTimeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 158);
			this.Controls.Add(this.CancelarButton);
			this.Controls.Add(this.SalvarButton);
			this.Controls.Add(this.SiglaTextBox);
			this.Controls.Add(this.NomeTextBox);
			this.Controls.Add(this.NomeComplexoTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EditarTimeView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditarTimeView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelarButton;
		private System.Windows.Forms.Button SalvarButton;
		private System.Windows.Forms.TextBox SiglaTextBox;
		private System.Windows.Forms.TextBox NomeTextBox;
		private System.Windows.Forms.TextBox NomeComplexoTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}