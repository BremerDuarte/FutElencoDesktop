using FutElencoDesktop.DAL;
using FutElencoDesktop.Model;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class EditarTimeView : Form
	{
		private FutElencoContext DB = new FutElencoContext();
		private TimesListView _owner = new TimesListView();
		private Time _time;
		public EditarTimeView(TimesListView owner, string timeID)
		{
			InitializeComponent();

			this._owner = owner;

			DB.Times.Load();

			int ID;
			int.TryParse(timeID, out ID);

			var time = _time = DB.Times.Find(ID);
			NomeComplexoTextBox.Text = time.NomeCompleto;
			NomeTextBox.Text = time.Nome;
			SiglaTextBox.Text = time.Sigla;

			this.FormClosing += new FormClosingEventHandler(this.OwnerFormPerformRefresh);
		}

		private void SalvarButton_Click(object sender, EventArgs e)
		{
			if (ValidarCadastro())
			{
				return;
			}

			_time.NomeCompleto = NomeComplexoTextBox.Text;
			_time.Nome = NomeTextBox.Text;
			_time.Sigla = SiglaTextBox.Text.ToUpper();
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
			_owner.PerformRefresh(_time.ID);
		}
	}
}
