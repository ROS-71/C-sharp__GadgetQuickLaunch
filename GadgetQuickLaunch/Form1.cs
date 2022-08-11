using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace GadgetQuickLaunch
	{

	public partial class Form1 : Form
		{
		public Form1()
			{
			
			Thread.Sleep(3000);				// Делаем задержку запуска приложения, чтобы SideBar не выталкивал её за свои границы и запускался первым.
			InitializeComponent();

			//-------------------------ЭФФЕКТ ТЕНИ НА НАДПИСИ НА КНОПКЕ ЧЕРЕЗ НАЛОЖЕНИЕ НА НЕЁ LABEL------------------------------------------

			// ДЛЯ КНОПКИ AwesomeMiner
			// Задаём эффект текста label на названии кнопки, через установлении ПОЛНОЙ прозрачности label поверх кнопки
			var pos1 = this.PointToScreen(label_btAwesomeMiner.Location);
			pos1 = btAwesomeMiner.PointToClient(pos1);
			label_btAwesomeMiner.Parent = btAwesomeMiner;
			label_btAwesomeMiner.Location = pos1;
			label_btAwesomeMiner.BackColor = Color.Transparent;
			// Задаём исчезание и появления эффекта тени при наведении мыши и убирании мыши с кнопки
			btAwesomeMiner.MouseEnter += (s, e) => label_btAwesomeMiner?.Hide();
			btAwesomeMiner.MouseLeave += (s, e) => label_btAwesomeMiner?.Show();

			// ДЛЯ КНОПКИ MS VISUAL STUDIO
			var pos2 = this.PointToScreen(label_bt_MS_Visual_Studio.Location);
			pos2 = bt_MS_Visual_Studio.PointToClient(pos2);
			label_bt_MS_Visual_Studio.Parent = bt_MS_Visual_Studio;
			label_bt_MS_Visual_Studio.Location = pos2;
			label_bt_MS_Visual_Studio.BackColor = Color.Transparent;
			bt_MS_Visual_Studio.MouseEnter += (s, e) => label_bt_MS_Visual_Studio.Hide();
			bt_MS_Visual_Studio.MouseLeave += (s, e) => label_bt_MS_Visual_Studio.Show();


			// ДЛЯ КНОПКИ MS VS CODE
			var pos3 = this.PointToScreen(label_bt_MS_VS_Code.Location);
			pos3 = bt_MS_Visual_Studio_Code.PointToClient(pos3);
			label_bt_MS_VS_Code.Parent = bt_MS_Visual_Studio_Code;
			label_bt_MS_VS_Code.Location = pos3;
			label_bt_MS_VS_Code.BackColor = Color.Transparent;
			bt_MS_Visual_Studio_Code.MouseEnter += (s, e) => label_bt_MS_VS_Code.Hide();
			bt_MS_Visual_Studio_Code.MouseLeave += (s, e) => label_bt_MS_VS_Code.Show();

			// ДЛЯ КНОПКИ NOTEPAD++
			var pos4 = this.PointToScreen(label_bt_NotePadPlusPlus.Location);
			pos4 = bt_NotePadPlusPlus.PointToClient(pos4);
			label_bt_NotePadPlusPlus.Parent = bt_NotePadPlusPlus;
			label_bt_NotePadPlusPlus.Location = pos4;
			label_bt_NotePadPlusPlus.BackColor = Color.Transparent;
			bt_NotePadPlusPlus.MouseEnter += (s, e) => label_bt_NotePadPlusPlus.Hide();
			bt_NotePadPlusPlus.MouseLeave += (s, e) => label_bt_NotePadPlusPlus.Show();

			// ДЛЯ КНОПКИ WORLD OF TANKS
			var pos5 = this.PointToScreen(label_btWOT.Location);
			pos5 = btWOT.PointToClient(pos5);
			label_btWOT.Parent = btWOT;
			label_btWOT.Location = pos5;
			label_btWOT.BackColor = Color.Transparent;
			btWOT.MouseEnter += (s, e) => label_btWOT.Hide();
			btWOT.MouseLeave += (s, e) => label_btWOT.Show();
//------------------------------------------------------------------------------------------------------------------------------------------
			}
		

		// Задаём расположение запусак формы, в данном случае нижний правый угол.  Обязательно ставим StartPosition: Manual в свойствах формы!
		private void Form1_Load(object sender, EventArgs e)
			{
			Location = new Point(3240, 994);
			}

		// Закрытие формы
		public void btCloseForm_Click(object sender, EventArgs e)
			{
			Close();
			}

		// Запуск майнинг программы Awesome Miner
		private void btAwesomeMiner_Click(object sender, EventArgs e)
			{
			Process.Start(@"D:\INVESTING\Awesome Miner\AwesomeMiner.exe");

			// ссылка на кнопку btnFocus с указание фокуса на неё необходима для удаления остаточного эффекта чёрной рамки
			// параметры кнопки btnFocus: размеры 0х0 пикселей, visible = true, enabled = true; color = transparent (internet) - все параметры необходимы для невидимости этой кнопки
			// расположение кнопки btnFocus в нижнем правом углу формы
			btnFocus.Focus();
			}
		
		private void bt_MS_Visual_Studio_Click(object sender, EventArgs e)
			{
			Process.Start(@"H:\Microsoft Visual Studio\Studio\Common7\IDE\devenv.exe");
			btnFocus.Focus();
			}

		private void bt_MS_Visual_Studio_Code_Click(object sender, EventArgs e)
			{
			Process.Start(@"H:\Microsoft_VS_Code\Code.exe");
			ProcessStartInfo arg = new ProcessStartInfo();
			arg.Arguments = " --disable -gpu";
			btnFocus.Focus();
			}

		private void bt_NotePadPlusPlus_Click(object sender, EventArgs e)
			{
			Process.Start(@"C:\Program Files\Notepad++\notepad++.exe");
			btnFocus.Focus();
			}

		private void btWOT_Click(object sender, EventArgs e)
			{
			Process.Start(@"H:\Wargaming.net\GameCenter\wgc.exe");
			btnFocus.Focus();
			}

		}

	}

