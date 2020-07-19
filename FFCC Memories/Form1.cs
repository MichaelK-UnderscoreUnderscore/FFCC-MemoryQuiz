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
			KatA.Enabled = false;
			KatFu.Enabled = false;
			KatKa.Enabled = false;
			KatKe.Enabled = false;
			KatKi.Enabled = false;
			KatKo.Enabled = false;
			KatMa.Enabled = false;
			KatMo.Enabled = false;
			KatNe.Enabled = false;
			KatO.Enabled = false;
			KatRa.Enabled = false;
			KatRe.Enabled = false;
			KatRi.Enabled = false;
			KatRu.Enabled = false;
			KatSa.Enabled = false;
			KatSe.Enabled = false;
			KatShi.Enabled = false;
			KatSo.Enabled = false;
			KatTa.Enabled = false;
			KatTe.Enabled = false;
			KatU.Enabled = false;
			HirA.Enabled = false;
			HirI.Enabled = false;
			HirMo.Enabled = false;
			HirNa.Enabled = false;
			HirO.Enabled = false;
			HirSa.Enabled = false;
			HirSe.Enabled = false;
			HirSo.Enabled = false;
			HirTo.Enabled = false;
			Num1.Enabled = false;
			Kanji.Enabled = false;
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
			current++;
			nextButtons();
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
				progressBar1.Value = 100 * answer1 / (answer1 + answer2 + answer3);
				progressBar2.Value = 100 * answer2 / (answer1 + answer2 + answer3);
				progressBar3.Value = 100 * answer3 / (answer1 + answer2 + answer3);
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
								Kanji.Enabled = true;
								continue;
							}
						case "Kat-a":
							{
								KatA.Enabled = true;
								continue;
							}
						case "Kat-fu":
							{
								KatFu.Enabled = true;
								continue;
							}
						case "Kat-ka":
							{
								KatKa.Enabled = true;
								continue;
							}
						case "Kat-ke":
							{
								KatKe.Enabled = true;
								continue;
							}
						case "Kat-o":
							{
								KatO.Enabled = true;
								continue;
							}
						case "Kat-ki":
							{
								KatKi.Enabled = true;
								continue;
							}
						case "Kat-Ko":
							{
								KatKo.Enabled = true;
								continue;
							}
						case "Kat-ma":
							{
								KatMa.Enabled = true;
								continue;
							}
						case "Kat-mo":
							{
								KatMo.Enabled = true;
								continue;
							}
						case "Kat-ne":
							{
								KatNe.Enabled = true;
								continue;
							}
						case "Kat-ra":
							{
								KatRa.Enabled = true;
								continue;
							}
						case "Kat-re":
							{
								KatRe.Enabled = true;
								continue;
							}
						case "Kat-ri":
							{
								KatRi.Enabled = true;
								continue;
							}
						case "Kat-ru":
							{
								KatRu.Enabled = true;
								continue;
							}
						case "Kat-sa":
							{
								KatSa.Enabled = true;
								continue;
							}
						case "Kat-se":
							{
								KatSe.Enabled = true;
								continue;
							}
						case "Kat-shi":
							{
								KatShi.Enabled = true;
								continue;
							}
						case "Kat-so":
							{
								KatSo.Enabled = true;
								continue;
							}
						case "Kat-ta":
							{
								KatTa.Enabled = true;
								continue;
							}
						case "Kat-te":
							{
								KatTe.Enabled = true;
								continue;
							}
						case "Kat-u":
							{
								KatU.Enabled = true;
								continue;
							}
						case "Hir-a":
							{
								HirA.Enabled = true;
								continue;
							}
						case "Hir-i":
							{
								HirI.Enabled = true;
								continue;
							}
						case "Hir-mo":
							{
								HirMo.Enabled = true;
								continue;
							}
						case "Hir-na":
							{
								HirNa.Enabled = true;
								continue;
							}
						case "Hir-o":
							{
								HirO.Enabled = true;
								continue;
							}
						case "Hir-sa":
							{
								HirSa.Enabled = true;
								continue;
							}
						case "Hir-se":
							{
								HirSe.Enabled = true;
								continue;
							}
						case "Hir-so":
							{
								HirSo.Enabled = true;
								continue;
							}
						case "Hir-to":
							{
								HirTo.Enabled = true;
								continue;
							}
						case "Num-1":
							{
								Num1.Enabled = true;
								continue;
							}
					}
				}
			}
		}

		private void KatShi_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				ButtonTest("Kat-shi", false);
			if (e.Button == MouseButtons.Right)
				ButtonTest("Kat-shi", true);
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
		private void KatRe_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-re", true);
		}
		private void KatU_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-u", true);
		}
		private void KatKo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ko", true);
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
		private void HirSa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-sa", false);
		}
		private void HirMo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-mo", false);
		}
		private void HirNa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Hir-na", false);
		}
		private void KatTa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ta", false);
		}
		private void KatNe_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ne", false);
		}
		private void KatKa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ka", false);
		}
		private void KatMa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ma", false);
		}
		private void KatRi_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ri", false);
		}
		private void KatSa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-sa", false);
		}
		private void Num1_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Num-1", false);
		}
		private void Kanji_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kanji", false);
		}
		private void KatRa_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ra", false);
		}
		private void KatO_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-o", false);
		}
		private void KatRu_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ru", false);
		}
		private void KatMo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-mo", false);
		}
		private void KatSo_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-so", false);
		}
		private void KatKe_Click(object sender, MouseEventArgs e)
		{
			ButtonTest("Kat-ke", false);
		}
		private void reset_Click(object sender, EventArgs e)
		{
			resetButtons();
			mem.CopyTo(temp_mem, 0);
			current = 0;
			nextButtons();
			AnswerTest();
		}
	}
}
