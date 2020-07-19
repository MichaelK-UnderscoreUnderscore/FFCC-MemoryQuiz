using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;

namespace FFCC_Memories
{

	public partial class Form1 : Form
	{
		
		private Memories[] mem = new Memories[25];
		private Memories[] temp_mem = new Memories[25];
		private int current = 0;
		private int answer1 = 0;
		private int answer2 = 0;
		private int answer3 = 0;

		public Form1()
		{
			InitializeComponent();
			resetButtons();
			LoadData();
			AnswerTest();
			nextButtons();
		}

		private void LoadData()
		{
			JObject jobj1 = JObject.Parse(File.ReadAllText("FFCC-Any.json"));
			int i = 0;

			foreach (JObject jobj2 in jobj1["memories"])
			{
				mem[i] = new Memories();
				foreach(JObject jobj3 in jobj2["buttons"])
				{
					mem[i].setButton((int)jobj3["id"], (string)jobj3["Name"]);
					mem[i].setModifier((int)jobj3["id"], (bool)jobj3["Mod"]);
				}
				mem[i].setImage((string)jobj2["image"]);
				mem[i].setAnswer((int)jobj2["answer"]);
				i++;
			}
			mem.CopyTo(temp_mem, 0);
		}
		
		private void resetButtons()
		{
			KatA.Visible = false;
			KatFu.Visible = false;
			KatKa.Visible = false;
			KatKi.Visible = false;
			KatMa.Visible = false;
			KatO.Visible = false;
			KatRu.Visible = false;
			KatSe.Visible = false;
			KatShi.Visible = false;
			KatSo.Visible = false;
			KatTe.Visible = false;
			KatU.Visible = false;
			HirA.Visible = false;
			HirI.Visible = false;
			HirNa.Visible = false;
			HirO.Visible = false;
			HirSe.Visible = false;
			HirSo.Visible = false;
			HirTo.Visible = false;
			Kanji.Visible = false;
			answer.Visible = false;
		}

		private void ButtonTest(string str, bool mod)
		{
			for (int i = 0; i < temp_mem.Length; i++)
			{
				if (temp_mem[i] == null) continue;
				if (str != temp_mem[i].getButton(current) || mod != temp_mem[i].getModifier(current))
				{
					temp_mem[i] = null;
					continue;
				}
			}
			resetButtons();
			AnswerTest();
			if (answer.Text == "?")
			{
				current++;
				line.Text = (current + 1).ToString();
				nextButtons();
			}
			else
			{
				answer.Visible = true;
			}

		}

		private void AnswerTest()
		{
			answer1 = 0;
			answer2 = 0;
			answer3 = 0;
			for (int i = 0; i < temp_mem.Length; i++)
			{
				if (temp_mem[i] == null) continue;

				switch (temp_mem[i].getAnswer())
				{
					case 1:
						{
							answer1++;
							continue;
						}
					case 2:
						{
							answer2++;
							continue;
						}
					case 3:
						{
							answer3++;
							continue;
						}
				}

			}

			remain.Text = (answer1 + answer2 + answer3).ToString();
			if (answer1 + answer2 + answer3 > 0)
			{
				chart1.Series["Series1"].Points[0].YValues[0] = 100 * answer3 / (answer1 + answer2 + answer3);
				chart1.Series["Series1"].Points[1].YValues[0] = 100 * answer2 / (answer1 + answer2 + answer3);
				chart1.Series["Series1"].Points[2].YValues[0] = 100 * answer1 / (answer1 + answer2 + answer3);
				chart1.Update();
				chart1.Refresh();
				answer.Text = "?";
				if (answer1 == 0 && answer2 == 0)
				{
					answer.Text = "3";
				}
				if (answer1 == 0 && answer3 == 0)
				{
					answer.Text = "2";
				}
				if (answer2 == 0 && answer3 == 0)
				{
					answer.Text = "1";
				}
			} else answer.Text = "E";
		}

		private void nextButtons()
		{
			if (current < 5) {
				for (int i = 0; i < temp_mem.Length; i++)
				{
					if (temp_mem[i] == null) continue;

					switch (temp_mem[i].getButton(current))
					{
						case "Kanji":
							{
								Kanji.Visible = true;
								continue;
							}
						case "Kat-a":
							{
								KatA.Visible = true;
								continue;
							}
						case "Kat-fu":
							{
								KatFu.Visible = true;
								continue;
							}
						case "Kat-ka":
							{
								KatKa.Visible = true;
								continue;
							}
						case "Kat-o":
							{
								KatO.Visible = true;
								continue;
							}
						case "Kat-ki":
							{
								KatKi.Visible = true;
								continue;
							}
						case "Kat-ma":
							{
								KatMa.Visible = true;
								continue;
							}
						case "Kat-ru":
							{
								KatRu.Visible = true;
								continue;
							}
						case "Kat-se":
							{
								KatSe.Visible = true;
								continue;
							}
						case "Kat-shi":
							{
								KatShi.Visible = true;
								continue;
							}
						case "Kat-so":
							{
								KatSo.Visible = true;
								continue;
							}
						case "Kat-te":
							{
								KatTe.Visible = true;
								continue;
							}
						case "Kat-u":
							{
								KatU.Visible = true;
								continue;
							}
						case "Hir-a":
							{
								HirA.Visible = true;
								continue;
							}
						case "Hir-i":
							{
								HirI.Visible = true;
								continue;
							}
						case "Hir-na":
							{
								HirNa.Visible = true;
								continue;
							}
						case "Hir-o":
							{
								HirO.Visible = true;
								continue;
							}
						case "Hir-se":
							{
								HirSe.Visible = true;
								continue;
							}
						case "Hir-so":
							{
								HirSo.Visible = true;
								continue;
							}
						case "Hir-to":
							{
								HirTo.Visible = true;
								continue;
							}
					}
				}
			}
		}

		private void KatTe_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				ButtonTest("Kat-te", false);
			if (e.Button == MouseButtons.Right)
				ButtonTest("Kat-te", true);
		}
		private void KatKi_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				ButtonTest("Kat-ki", false);
			if (e.Button == MouseButtons.Right)
				ButtonTest("Kat-ki", true);
		}
		private void HirTo_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				ButtonTest("Hir-to", false);
			if (e.Button == MouseButtons.Right)
				ButtonTest("Hir-to", true);
		}
		private void KatShi_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-shi", false);
		}
		private void KatU_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-u", true);
		}
		private void HirA_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-a", false);
		}
		private void KatSe_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-se", false);
		}
		private void HirSo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-so", false);
		}
		private void HirSe_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-se", false);
		}
		private void KatFu_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-fu", false);
		}
		private void KatA_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-a", false);
		}
		private void HirI_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-i", false);
		}
		private void HirO_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-o", false);
		}
		private void HirNa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-na", false);
		}
		private void KatKa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ka", false);
		}
		private void KatMa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ma", false);
		}
		private void Kanji_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kanji", false);
		}
		private void KatO_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-o", false);
		}
		private void KatRu_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ru", false);
		}
		private void KatSo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-so", false);
		}
		private void reset_Click(object sender, EventArgs e)
		{
			resetButtons();
			mem.CopyTo(temp_mem, 0);
			current = 0;
			line.Text = (current + 1).ToString();
			nextButtons();
			AnswerTest();
		}
    }
}
