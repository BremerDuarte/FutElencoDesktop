using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class EditarJogadorView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		private JogadoresListView _owner;
		private Jogador _jogador;

		public EditarJogadorView(JogadoresListView owner, string ID)
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

			DB.Jogadores.Load();
			var jogadorID = int.Parse(ID);
			var jogador = _jogador = DB.Jogadores.Find(jogadorID);
			NomeTextBox.Text = jogador.Nome;
			ApelidoTextBox.Text = jogador.Apelido;
			DataNascimentoDateTimePicker.Text = jogador.DataNascimento.ToString();
			PosicaoComboBox.SelectedValue = jogador.Posicao.ID;
			TimeComboBox.SelectedValue = jogador.Time.ID;

			this.FormClosing += new FormClosingEventHandler(this.OwnerFormPerformRefresh);
		}

		private void SalvarButton_Click(object sender, EventArgs e)
		{
			if (ValidarCadastro())
			{
				return;
			}

			var posicaoID = (int)PosicaoComboBox.SelectedValue;
			var posicao = DB.Posicoes.Find(posicaoID);
			var timeID = (int)TimeComboBox.SelectedValue;
			var time = DB.Times.Find(timeID);

			_jogador.Nome = NomeTextBox.Text.ToUpper();
			_jogador.Apelido = ApelidoTextBox.Text.ToUpper();
			_jogador.DataNascimento = DateTime.Parse(DataNascimentoDateTimePicker.Text);
			_jogador.Posicao = posicao;
			_jogador.Time = time;

			DB.SaveChanges();
			this.Close();
		}

		private void CancelarButton_Click(object sender, EventArgs e)
		{
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
				}
				else
				{
					error = true;
				}
			}

			return error;
		}

		private void OwnerFormPerformRefresh(object sender, FormClosingEventArgs e)
		{
			_owner.PerformRefreshAfterUpdate(_jogador.ID);
		}
	}
}
