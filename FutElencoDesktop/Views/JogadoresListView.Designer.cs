namespace FutElencoDesktop
{
	partial class JogadoresListView
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewJogadores = new System.Windows.Forms.DataGridView();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
			this.CadastrarButton = new System.Windows.Forms.Button();
			this.SairButton = new System.Windows.Forms.Button();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.FiltrarButton = new System.Windows.Forms.Button();
			this.FiltroTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogadores)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewJogadores
			// 
			this.dataGridViewJogadores.AllowUserToAddRows = false;
			this.dataGridViewJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnApelido,
            this.ColumnDataNascimento,
            this.ColumnPosicao,
            this.ColumnTime,
            this.ColumnEditar,
            this.ColumnExcluir});
			this.dataGridViewJogadores.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewJogadores.Name = "dataGridViewJogadores";
			this.dataGridViewJogadores.Size = new System.Drawing.Size(760, 397);
			this.dataGridViewJogadores.TabIndex = 0;
			this.dataGridViewJogadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJogadores_CellClick);
			// 
			// ColumnID
			// 
			this.ColumnID.DataPropertyName = "ID";
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Visible = false;
			// 
			// ColumnNome
			// 
			this.ColumnNome.DataPropertyName = "Nome";
			this.ColumnNome.HeaderText = "Nome";
			this.ColumnNome.Name = "ColumnNome";
			this.ColumnNome.ReadOnly = true;
			// 
			// ColumnApelido
			// 
			this.ColumnApelido.DataPropertyName = "Apelido";
			this.ColumnApelido.HeaderText = "Apelido";
			this.ColumnApelido.Name = "ColumnApelido";
			this.ColumnApelido.ReadOnly = true;
			// 
			// ColumnDataNascimento
			// 
			this.ColumnDataNascimento.DataPropertyName = "DataNascimento";
			this.ColumnDataNascimento.HeaderText = "Data de Nascimento";
			this.ColumnDataNascimento.Name = "ColumnDataNascimento";
			this.ColumnDataNascimento.ReadOnly = true;
			// 
			// ColumnPosicao
			// 
			this.ColumnPosicao.DataPropertyName = "NomePosicao";
			this.ColumnPosicao.HeaderText = "Posição";
			this.ColumnPosicao.Name = "ColumnPosicao";
			this.ColumnPosicao.ReadOnly = true;
			// 
			// ColumnTime
			// 
			this.ColumnTime.DataPropertyName = "NomeTime";
			this.ColumnTime.HeaderText = "Time";
			this.ColumnTime.Name = "ColumnTime";
			this.ColumnTime.ReadOnly = true;
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
			// CadastrarButton
			// 
			this.CadastrarButton.Location = new System.Drawing.Point(615, 424);
			this.CadastrarButton.Name = "CadastrarButton";
			this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
			this.CadastrarButton.TabIndex = 1;
			this.CadastrarButton.Text = "Cadastrar";
			this.CadastrarButton.UseVisualStyleBackColor = true;
			this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
			// 
			// SairButton
			// 
			this.SairButton.Location = new System.Drawing.Point(697, 424);
			this.SairButton.Name = "SairButton";
			this.SairButton.Size = new System.Drawing.Size(75, 23);
			this.SairButton.TabIndex = 2;
			this.SairButton.Text = "Sair";
			this.SairButton.UseVisualStyleBackColor = true;
			this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(437, 424);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(75, 23);
			this.RefreshButton.TabIndex = 3;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// FiltrarButton
			// 
			this.FiltrarButton.Location = new System.Drawing.Point(217, 424);
			this.FiltrarButton.Name = "FiltrarButton";
			this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
			this.FiltrarButton.TabIndex = 4;
			this.FiltrarButton.Text = "Filtrar";
			this.FiltrarButton.UseVisualStyleBackColor = true;
			this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
			// 
			// FiltroTextBox
			// 
			this.FiltroTextBox.Location = new System.Drawing.Point(43, 426);
			this.FiltroTextBox.Name = "FiltroTextBox";
			this.FiltroTextBox.Size = new System.Drawing.Size(168, 20);
			this.FiltroTextBox.TabIndex = 5;
			// 
			// JogadoresListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.FiltroTextBox);
			this.Controls.Add(this.FiltrarButton);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.SairButton);
			this.Controls.Add(this.CadastrarButton);
			this.Controls.Add(this.dataGridViewJogadores);
			this.Name = "JogadoresListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogadores";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewJogadores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewJogadores;
		private System.Windows.Forms.Button CadastrarButton;
		private System.Windows.Forms.Button SairButton;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApelido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNascimento;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosicao;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnEditar;
		private System.Windows.Forms.DataGridViewButtonColumn ColumnExcluir;
		private System.Windows.Forms.Button FiltrarButton;
		private System.Windows.Forms.TextBox FiltroTextBox;
	}
}

