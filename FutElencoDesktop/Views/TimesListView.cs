using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class TimesListView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		public TimesListView()
		{
			InitializeComponent();

			DB.Times.Load();

			TimesDataGridView.AutoGenerateColumns = false;
			TimesDataGridView.DataSource = DB.Times.Local.ToBindingList();
		}

		private void CadastrarButton_Click(object sender, EventArgs e)
		{
			var cadastrarView = new CadastroTimeView(this);
			cadastrarView.Show();
		}

		private void SairButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TimesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;


			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				var currentRow = TimesDataGridView.Rows.SharedRow(e.RowIndex);
				var timeID = currentRow.Cells["columnID"].Value.ToString();

				if (timeID != string.Empty)
				{
					var cellValue = TimesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
					if (cellValue.Equals("Jogadores"))
					{
						int.TryParse(timeID, out int ID);
						var jogadoresListView = new JogadoresListView(ID);
						jogadoresListView.Show();
					}
					else if (cellValue.Equals("Editar"))
					{
						var editarView = new EditarTimeView(this, timeID);
						editarView.Show();
					}
					else if (cellValue.Equals("Excluir"))
					{
						var nomeTime = currentRow.Cells["columnNome"].Value.ToString();
						var dialogResult = MessageBox.Show("Deseja realmente excluir o time " + nomeTime + "?", "Atenção", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
						{
							var time = DB.Times.Single(t => t.ID.ToString() == timeID);
							
							var timeEmUso = DB.Jogadores.Any(j => j.Time.ID == time.ID);
							if (timeEmUso)
							{
								MessageBox.Show(String.Format("Não é possível excluir o time {0} porque existem jogadores associados a ele.", nomeTime));
							}
							else
							{ 
								var jogadoresApagados = DB.Jogadores.Where(j => j.TimeID == time.ID).ToList();
								foreach (var j in jogadoresApagados)
								{
									DB.Entry<Jogador>(j).State = EntityState.Deleted; //Necessário atualizar pois o instância DB atual não enxerga a alteração na instância do JogadoresListView
								}
								DB.Times.Remove(time);
								DB.SaveChanges();
								PerformRefresh();
							}

						}
					}
				}
			}
		}

		public void PerformRefresh()
		{
			DB.Times.Load();
			TimesDataGridView.Refresh();
		}

		public void PerformRefresh(int timeID)
		{
			var time = DB.Times.Find(timeID);
			DB.Entry(time).Reload();
			TimesDataGridView.Refresh();
		}

	}
}
