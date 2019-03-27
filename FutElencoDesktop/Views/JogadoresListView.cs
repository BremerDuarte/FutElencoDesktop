using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using FutElencoDesktop.Views;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FutElencoDesktop
{
	public partial class JogadoresListView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		private BindingList<Jogador> jogadorBindingList;
		private int _timeID = 0;
		public JogadoresListView(int timeID = 0)
		{
			InitializeComponent();

			DB.Posicoes.Load();
			DB.Times.Load();
			DB.Jogadores.Load();
			dataGridViewJogadores.AutoGenerateColumns = false;

			jogadorBindingList = DB.Jogadores.Local.ToBindingList();
			if (timeID > 0)
			{
				_timeID = timeID;
				dataGridViewJogadores.DataSource = jogadorBindingList.Where(j => j.Time.ID == _timeID).ToList();
			}
			else
			{
				dataGridViewJogadores.DataSource = jogadorBindingList;
			}
		}

		private void dataGridViewJogadores_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;


			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				var currentRow = dataGridViewJogadores.Rows.SharedRow(e.RowIndex);
				var jogadorID = currentRow.Cells["columnID"].Value.ToString();

				if (jogadorID != string.Empty)
				{
					var cellValue = dataGridViewJogadores.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

					if (cellValue.Equals("Editar"))
					{
						var editarJogadorView = new EditarJogadorView(this, jogadorID);
						editarJogadorView.ShowDialog();
					}
					else if (cellValue.Equals("Excluir"))
					{
						var apelidoJogador = currentRow.Cells["columnApelido"].Value.ToString();
						var dialogResult = MessageBox.Show("Deseja realmente excluir o jogador " + apelidoJogador + "?", "Atenção", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
						{
							var jogador = DB.Jogadores.Single(j => j.ID.ToString() == jogadorID);
							DB.Jogadores.Remove(jogador);
							DB.SaveChanges();
							PerformRefresh();
						}
					}
				}
			}
		}

		private void CadastrarButton_Click(object sender, EventArgs e)
		{
			var cadastrarJogadorView = new CadastroJogadorView(this);
			cadastrarJogadorView.Show();
		}

		public void PerformRefresh()
		{
			DB.Jogadores.Load();
			if (_timeID > 0)
			{
				dataGridViewJogadores.DataSource = jogadorBindingList.Where(j => j.Time.ID == _timeID).ToList();
			}
			dataGridViewJogadores.Refresh();
		}

		public void PerformRefreshAfterUpdate(int jogadorID)
		{
			var jogador = DB.Jogadores.Find(jogadorID);
			DB.Entry(jogador).Reload();
			dataGridViewJogadores.Refresh();
		}

		private void SairButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			PerformRefresh();
		}

		private void FiltrarButton_Click(object sender, EventArgs e)
		{
			var bindingListFiltered = jogadorBindingList.Where(j => j.NomeTime.ToUpper().Contains(FiltroTextBox.Text.ToUpper())).ToList();
			dataGridViewJogadores.DataSource = bindingListFiltered;
			dataGridViewJogadores.Refresh();
		}
	}
}
