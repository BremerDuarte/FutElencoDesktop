using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class CadastroJogadorView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		private JogadoresListView _owner;
		public CadastroJogadorView(JogadoresListView owner, string ID = "")
		{
			InitializeComponent();
			this._owner = owner;
			DataNascimentoDateTimePicker.Format = DateTimePickerFormat.Custom;
			DataNascimentoDateTimePicker.CustomFormat = "dd/MM/yyyy";

			DB.Posicoes.Load();
			PosicaoComboBox.ValueMember = "ID";
			PosicaoComboBox.DisplayMember = "Nome";
			PosicaoComboBox.DataSource = DB.Posicoes.Local.ToBindingList();

			DB.Times.Load();
			TimeComboBox.ValueMember = "ID";
			TimeComboBox.DisplayMember = "Nome";
			TimeComboBox.DataSource = DB.Times.Local.ToBindingList();

			if (ID != string.Empty)
			{
				DB.Jogadores.Load();
				var jogadorID = int.Parse(ID);
				var jogador = DB.Jogadores.First(x => x.ID == jogadorID);
				NomeTextBox.Text = jogador.Nome;
				ApelidoTextBox.Text = jogador.Apelido;
				DataNascimentoDateTimePicker.Text = jogador.DataNascimento.ToString();
				PosicaoComboBox.SelectedValue = jogador.Posicao.ID;
				TimeComboBox.SelectedValue = jogador.Time.ID;
			}

			this.FormClosing += new FormClosingEventHandler(this.OwnerFormPerformRefresh);
		}

		private void CadastrarButton_Click(object sender, EventArgs e)
		{
			if (ValidarCadastro())
			{
				return;
			}

			var jogador = new Jogador();
			var posicaoID = (int)PosicaoComboBox.SelectedValue;
			var posicao = DB.Posicoes.Single(p => p.ID == posicaoID);
			var timeID = (int)TimeComboBox.SelectedValue;
			var time = DB.Times.Single(t => t.ID == timeID);

			jogador.Nome = NomeTextBox.Text.ToUpper();
			jogador.Apelido = ApelidoTextBox.Text.ToUpper();
			jogador.DataNascimento = DateTime.Parse(DataNascimentoDateTimePicker.Text);
			jogador.Posicao = posicao;
			jogador.Time = time;

			DB.Jogadores.Add(jogador);
			DB.SaveChanges();
			this.Close();
		}

		private bool ValidarCadastro()
		{
			var error = false;
			if (NomeTextBox.Text == string.Empty)
			{
				NomeTextBox.BackColor = Color.OrangeRed;
				error = true;
			}

			if (ApelidoTextBox.Text == string.Empty)
			{
				ApelidoTextBox.BackColor = Color.OrangeRed;
				error = true;
			}

			if (DataNascimentoDateTimePicker.Text == string.Empty)
			{
				DataNascimentoDateTimePicker.BackColor = Color.OrangeRed;
				error = true;
			}
			else
			{
				DateTime dataNascimento;
				if (DateTime.TryParse(DataNascimentoDateTimePicker.Text, out dataNascimento))
				{
					bool invalidDate = dataNascimento > DateTime.Today;
					if (invalidDate)
					{
						DataNascimentoDateTimePicker.BackColor = Color.OrangeRed;
						error = true;
					}
				} else
				{
					error = true;
				}
			}

			return error;
		}

		private void OwnerFormPerformRefresh(object sender, FormClosingEventArgs e)
		{
			_owner.PerformRefresh();
		}
	}
}
