using System;
using System.Windows.Forms;

namespace FutElencoDesktop.Views
{
	public partial class MenuView : Form
	{
		public MenuView()
		{
			InitializeComponent();
		}

		private void JogadoresButton_Click(object sender, EventArgs e)
		{
			var jogadoresListView = new JogadoresListView();
			jogadoresListView.Show();
		}

		private void TimesButton_Click(object sender, EventArgs e)
		{
			var timesListView = new TimesListView();
			timesListView.Show();
		}
	}
}
