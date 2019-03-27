namespace FutElencoDesktop.Views
{
	partial class MenuView
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
			this.JogadoresButton = new System.Windows.Forms.Button();
			this.TimesButton = new System.Windows.Forms.Button();
			this.JogosButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// JogadoresButton
			// 
			this.JogadoresButton.Location = new System.Drawing.Point(46, 46);
			this.JogadoresButton.Name = "JogadoresButton";
			this.JogadoresButton.Size = new System.Drawing.Size(124, 23);
			this.JogadoresButton.TabIndex = 0;
			this.JogadoresButton.Text = "Jogadores";
			this.JogadoresButton.UseVisualStyleBackColor = true;
			this.JogadoresButton.Click += new System.EventHandler(this.JogadoresButton_Click);
			// 
			// TimesButton
			// 
			this.TimesButton.Location = new System.Drawing.Point(46, 84);
			this.TimesButton.Name = "TimesButton";
			this.TimesButton.Size = new System.Drawing.Size(124, 23);
			this.TimesButton.TabIndex = 1;
			this.TimesButton.Text = "Times";
			this.TimesButton.UseVisualStyleBackColor = true;
			this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
			// 
			// JogosButton
			// 
			this.JogosButton.Location = new System.Drawing.Point(46, 123);
			this.JogosButton.Name = "JogosButton";
			this.JogosButton.Size = new System.Drawing.Size(124, 23);
			this.JogosButton.TabIndex = 2;
			this.JogosButton.Text = "Jogos";
			this.JogosButton.UseVisualStyleBackColor = true;
			// 
			// MenuView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 375);
			this.Controls.Add(this.JogosButton);
			this.Controls.Add(this.TimesButton);
			this.Controls.Add(this.JogadoresButton);
			this.Name = "MenuView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Início";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button JogadoresButton;
		private System.Windows.Forms.Button TimesButton;
		private System.Windows.Forms.Button JogosButton;
	}
}