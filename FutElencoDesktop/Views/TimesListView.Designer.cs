namespace FutElencoDesktop.Views
{
	partial class TimesListView
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
			this.TimesDataGridView = new System.Windows.Forms.DataGridView();
			this.CadastrarButton = new System.Windows.Forms.Button();
			this.SairButton = new System.Windows.Forms.Button();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnJogadores = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.TimesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// TimesDataGridView
			// 
			this.TimesDataGridView.AllowUserToAddRows = false;
			this.TimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNomeCompleto,
            this.ColumnNome,
            this.ColumnSigla,
            this.ColumnJogadores,
            this.ColumnEditar,
            this.ColumnExcluir});
			this.TimesDataGridView.Location = new System.Drawing.Point(13, 13);
			this.TimesDataGridView.Name = "TimesDataGridView";
			this.TimesDataGridView.Size = new System.Drawing.Size(775, 389);
			this.TimesDataGridView.TabIndex = 0;
			this.TimesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimesDataGridView_CellClick);
			// 
			// CadastrarButton
			// 
			this.CadastrarButton.Location = new System.Drawing.Point(630, 408);
			this.CadastrarButton.Name = "CadastrarButton";
			this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
			this.CadastrarButton.TabIndex = 1;
			this.CadastrarButton.Text = "Cadastrar";
			this.CadastrarButton.UseVisualStyleBackColor = true;
			this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
			// 
			// SairButton
			// 
			this.SairButton.Location = new System.Drawing.Point(713, 408);
			this.SairButton.Name = "SairButton";
			this.SairButton.Size = new System.Drawing.Size(75, 23);
			this.SairButton.TabIndex = 2;
			this.SairButton.Text = "Sair";
			this.SairButton.UseVisualStyleBackColor = true;
			this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
			// 
			// ColumnID
			// 
			this.ColumnID.DataPropertyName = "ID";
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			// 
			// ColumnNomeCompleto
			// 
			this.ColumnNomeCompleto.DataPropertyName = "NomeCompleto";
			this.ColumnNomeCompleto.HeaderText = "Nome Completo";
			this.ColumnNomeCompleto.Name = "ColumnNomeCompleto";
			this.ColumnNomeCompleto.ReadOnly = true;
			// 
			// ColumnNome
			// 
			this.ColumnNome.DataPropertyName = "Nome";
			this.ColumnNome.HeaderText = "Nome";
			this.ColumnNome.Name = "ColumnNome";
			this.ColumnNome.ReadOnly = true;
			// 
			// ColumnSigla
			// 
			this.ColumnSigla.DataPropertyName = "Sigla";
			this.ColumnSigla.HeaderText = "Sigla";
			this.ColumnSigla.Name = "ColumnSigla";
			this.ColumnSigla.ReadOnly = true;
			// 
			// ColumnJogadores
			// 
			this.ColumnJogadores.HeaderText = "";
			this.ColumnJogadores.Name = "ColumnJogadores";
			this.ColumnJogadores.ReadOnly = true;
			this.ColumnJogadores.Text = "Jogadores";
			this.ColumnJogadores.UseColumnTextForButtonValue = true;
			// 
			// ColumnEditar
			// 
			this.ColumnEditar.HeaderText = "";
			this.ColumnEditar.Name = "ColumnEditar";
			this.ColumnEditar.ReadOnly = true;
			this.ColumnEditar.Text = "Editar";
			this.ColumnEditar.UseColumnTextForButtonValue = true;
			// 
			// ColumnExcluir
			// 
			this.ColumnExcluir.HeaderText = "";
			this.ColumnExcluir.Name = "ColumnExcluir";
			this.ColumnExcluir.ReadOnly = true;
			this.ColumnExcluir.Text = "Excluir";
			this.ColumnExcluir.UseColumnTextForButtonValue = true;
			// 
			// TimesListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SairButton);
			this.Controls.Add(this.CadastrarButton);
			this.Controls.Add(this.TimesDataGridView);
			this.Name = "TimesListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Times";
			((System.ComponentModel.ISupportInitialize)(this.TimesDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView TimesDataGridView;
		private System.Windows.Forms.Button CadastrarButton;
		private System.Windows.Forms.Button SairButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCompleto;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSigla;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnJogadores;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnEditar;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnExcluir;
	}
}