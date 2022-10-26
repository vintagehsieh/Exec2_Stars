using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Stars
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int rows = 0;

			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//呼叫星星方法
			string stars = GenerateLeftStars(rows);

			//呈現星星
			resultTextBox.Text = stars;
		}

		private void rightButton_Click(object sender, EventArgs e)
		{
			int rows = 0;

			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			string stars = GenerateRightStars(rows);

			resultTextBox.Text = stars;
		}

		private void isoTriangle_Click(object sender, EventArgs e)
		{
			int rows = 0;

			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string stars = GenerateIsoStars(rows);

			resultTextBox.Text = stars;
		}

		private string GenerateIsoStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				stars += new string(' ', (rows - i) * 2) + new string('*', 2 * i - 1) + "\r\n";
			}

			return stars;
		}

		private string GenerateRightStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				//stars += new string('*', i).PadLeft(rows, ' '*2) + "\r\n"; //看起來歪歪的
				stars += new string(' ', (rows - i) * 2) + new string('*', i) + "\r\n";
			}

			return stars;
		}

		private string GenerateLeftStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				stars += new string('*', i) + "\r\n";
			}

			return stars;
		}

		private int GetRows()
		{
			//取得rowsTextBox中的數字
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);

			if (isInt == false)
			{
				throw new Exception("請輸入列數!");
			}

			if (rows < 0)
			{
				throw new Exception("請輸入非負的正整數!");
			}

			return rows;
		}
	}
}
