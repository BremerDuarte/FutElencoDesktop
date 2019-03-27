using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class CadastroTimeView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		private TimesListView _owner;
		public CadastroTimeView(TimesListView owner)
		{
			InitializeComponent();

			this._owner = owner;
			this.FormClosing += new FormClosingEventHandler(this.OwnerFormPerformRefresh);
		}

		private void CancelarButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SalvarButton_Click(object sender, EventArgs e)
		{
			if (ValidarCadastro())
			{
				return;
			}

			var time = new Time() {
				NomeCompleto = NomeComplexoTextBox.Text,
				Nome = NomeTextBox.Text,
				Sigla = SiglaTextBox.Text.ToUpper()
			};

			DB.Times.Add(time);
			DB.SaveChanges();
			this.Close();

		}

		private bool ValidarCadastro()
		{
			var error = false;
			if (NomeComplexoTextBox.Text == string.Empty)
			{
				NomeComplexoTextBox.BackColor = Color.OrangeRed;
				error = true;
			}

			if (NomeTextBox.Text == string.Empty)
			{
				NomeTextBox.BackColor = Color.OrangeRed;
				error = true;
			}

			if (SiglaTextBox.Text == string.Empty)
			{
				SiglaTextBox.BackColor = Color.OrangeRed;
				error = true;
			}

			return error;
		}

		private void OwnerFormPerformRefresh(object sender, FormClosingEventArgs e)
		{
			_owner.PerformRefresh();
		}
	}
}
