using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MlbbX1Calculator
{
	public partial class frmPrincipal : Form
	{
		Hashtable herois = new Hashtable();
		Hashtable itens = new Hashtable();
		public frmPrincipal()
		{
			InitializeComponent();

			herois.Add("Layla", new Layla());
			herois.Add("Zilong", new Zilong());
			herois.Add("Terizla", new Terizla());
			herois.Add("Dyrroth", new Dyrroth());
			herois.Add("Silvana", new Silvana());
			herois.Add("Rafaela", new Rafaela());
			herois.Add("Gord", new Gord());
			herois.Add("Estes", new Estes());
			herois.Add("Harley", new Harley());
			herois.Add("Angela", new Angela());
			herois.Add("Kaja", new Kaja());
			herois.Add("Thamuz", new Thamuz());
			herois.Add("Guinevere", new Guinevere());
			herois.Add("Lylia", new Lylia());
			herois.Add("Hylos", new Hylos());
			herois.Add("Wanwan", new Wanwan());
			foreach (DictionaryEntry item in herois) {
				cmbHeroi1.Items.Add(item.Key.ToString());
				cmbHeroi2.Items.Add(item.Key.ToString());
			}

			itens.Add("", -1); //para campo nulo no combobox
			itens.Add("Lâmina do desespero", new LaminaDoDesespero());
			itens.Add("Voz do vento", new VozDoVento());
			foreach (DictionaryEntry item in itens) {
				cmbItem1Heroi1.Items.Add(item.Key.ToString());
				cmbItem2Heroi1.Items.Add(item.Key.ToString());
				cmbItem3Heroi1.Items.Add(item.Key.ToString());
				cmbItem4Heroi1.Items.Add(item.Key.ToString());
				cmbItem5Heroi1.Items.Add(item.Key.ToString());
				cmbItem6Heroi1.Items.Add(item.Key.ToString());
				cmbItem1Heroi2.Items.Add(item.Key.ToString());
				cmbItem2Heroi2.Items.Add(item.Key.ToString());
				cmbItem3Heroi2.Items.Add(item.Key.ToString());
				cmbItem4Heroi2.Items.Add(item.Key.ToString());
				cmbItem5Heroi2.Items.Add(item.Key.ToString());
				cmbItem6Heroi2.Items.Add(item.Key.ToString());
			}
		}

		private void atribuiItens(Heroi hero1, Heroi hero2) {
			Item item1h1, item2h1, item3h1, item4h1, item5h1, item6h1;
			Item item1h2, item2h2, item3h2, item4h2, item5h2, item6h2;

			if (cmbItem1Heroi1.SelectedIndex != -1 && cmbItem1Heroi1.SelectedItem.ToString() != "") {
				item1h1 = (Item)itens[cmbItem1Heroi1.SelectedItem.ToString()];
				item1h1.add(hero1);
			}
			if (cmbItem2Heroi1.SelectedIndex != -1 && cmbItem2Heroi1.SelectedItem.ToString() != "") {
				item2h1 = (Item)itens[cmbItem2Heroi1.SelectedItem.ToString()];
				item2h1.add(hero1);
			}
			if (cmbItem3Heroi1.SelectedIndex != -1 && cmbItem3Heroi1.SelectedItem.ToString() != "") {
				item3h1 = (Item)itens[cmbItem3Heroi1.SelectedItem.ToString()];
				item3h1.add(hero1);
			}
			if (cmbItem4Heroi1.SelectedIndex != -1 && cmbItem4Heroi1.SelectedItem.ToString() != "") {
				item4h1 = (Item)itens[cmbItem4Heroi1.SelectedItem.ToString()];
				item4h1.add(hero1);
			}
			if (cmbItem5Heroi1.SelectedIndex != -1 && cmbItem5Heroi1.SelectedItem.ToString() != "") {
				item5h1 = (Item)itens[cmbItem5Heroi1.SelectedItem.ToString()];
				item5h1.add(hero1);
			}
			if (cmbItem6Heroi1.SelectedIndex != -1 && cmbItem6Heroi1.SelectedItem.ToString() != "") {
				item6h1 = (Item)itens[cmbItem6Heroi1.SelectedItem.ToString()];
				item6h1.add(hero1);
			}
			if (cmbItem1Heroi2.SelectedIndex != -1 && cmbItem1Heroi2.SelectedItem.ToString() != "") {
				item1h2 = (Item)itens[cmbItem1Heroi2.SelectedItem.ToString()];
				item1h2.add(hero2);
			}
			if (cmbItem2Heroi2.SelectedIndex != -1 && cmbItem2Heroi2.SelectedItem.ToString() != "") {
				item2h2 = (Item)itens[cmbItem2Heroi2.SelectedItem.ToString()];
				item2h2.add(hero2);
			}
			if (cmbItem3Heroi2.SelectedIndex != -1 && cmbItem3Heroi2.SelectedItem.ToString() != "") {
				item3h2 = (Item)itens[cmbItem3Heroi2.SelectedItem.ToString()];
				item3h2.add(hero2);
			}
			if (cmbItem4Heroi2.SelectedIndex != -1 && cmbItem4Heroi2.SelectedItem.ToString() != "") {
				item4h2 = (Item)itens[cmbItem4Heroi2.SelectedItem.ToString()];
				item4h2.add(hero2);
			}
			if (cmbItem5Heroi2.SelectedIndex != -1 && cmbItem5Heroi2.SelectedItem.ToString() != "") {
				item5h2 = (Item)itens[cmbItem5Heroi2.SelectedItem.ToString()];
				item5h2.add(hero2);
			}
			if (cmbItem6Heroi2.SelectedIndex != -1 && cmbItem6Heroi2.SelectedItem.ToString() != "") {
				item6h2 = (Item)itens[cmbItem6Heroi2.SelectedItem.ToString()];
				item6h2.add(hero2);
			}
		}

		private void btnX1_Click(object sender, EventArgs e) {
			Heroi hero1, hero2;
			int dano = 0;
			int danoTotal1 = 0, danoTotal2 = 0;
			string selecao1;
			string selecao2;
			Type class1, class2;

			cmbHeroi1.Focus(); //apenas para remover o foco do botão

			if (cmbHeroi1.SelectedItem == null || cmbHeroi2.SelectedItem == null) {
				MessageBox.Show("Selecione os heróis", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else {
				selecao1 = cmbHeroi1.SelectedItem.ToString();
				selecao2 = cmbHeroi2.SelectedItem.ToString();
				class1 = herois[selecao1].GetType();
				hero1 = (Heroi)Activator.CreateInstance(class1);
				class2 = herois[selecao2].GetType();
				hero2 = (Heroi)Activator.CreateInstance(class2);
				this.atribuiItens(hero1, hero2);

				while (hero1.Hp != 0 && hero2.Hp != 0) {
					dano = hero1.atacar();
					danoTotal1 += dano;
					if (hero1.DanoReal == true)
						hero2.recebeDano(dano, true);
					else
						hero2.recebeDano(dano);

					dano = hero2.atacar();
					danoTotal2 += dano;
					if (hero2.DanoReal == true)
						hero1.recebeDano(dano, true);
					else
						hero1.recebeDano(dano);
				}

				if (hero1.Hp == 0) {
					MessageBox.Show(
						hero2.Nome + " ganha\n" +
						"Dano total " + hero1.Nome + " = " + danoTotal1 + "\n" +
						"Dano total " + hero2.Nome + " = " + danoTotal2,
						hero1.Nome + " x " + hero2.Nome);
				}
				else if (hero2.Hp == 0) {
					MessageBox.Show(
						hero1.Nome + " ganha\n" +
						"Dano total " + hero1.Nome + " = " + danoTotal1 + "\n" +
						"Dano total " + hero2.Nome + " = " + danoTotal2,
						hero1.Nome + " x " + hero2.Nome);
				}
			}
		}

		private void cmbHeroi1_SelectedIndexChanged(object sender, EventArgs e) {
			string selecao = cmbHeroi1.SelectedItem.ToString();

			imgHeroi1.Visible = true;
			Heroi heroiSelecionado = (Heroi)herois[selecao];
			imgHeroi1.Image = heroiSelecionado.Imagem;

			//Tentei deixar o fundo transparente mas não consegui
			/*
			lblHeroi1.ForeColor = System.Drawing.Color.Black;
			lblItens1.ForeColor = System.Drawing.Color.Black;
			lblHeroi1.Parent = imgHeroi2;
			lblHeroi1.BackColor = Color.Transparent;
			lblItens1.Parent = imgHeroi2;
			lblItens1.BackColor = Color.Transparent; */
			lblHeroi1.Visible = false;
			lblItens1.Visible = false;

		}

		private void cmbHeroi2_SelectedIndexChanged(object sender, EventArgs e) {
			string selecao = cmbHeroi2.SelectedItem.ToString();

			imgHeroi2.Visible = true;
			Heroi heroiSelecionado = (Heroi)herois[selecao];
			imgHeroi2.Image = heroiSelecionado.Imagem;

			//Tentei deixar o fundo transparente mas não consegui
			/*lblHeroi2.ForeColor = System.Drawing.Color.Black;
			lblItens2.ForeColor = System.Drawing.Color.Black;
			lblHeroi2.Parent = imgHeroi2;
			lblHeroi2.BackColor = Color.Transparent;
			lblItens2.Parent = imgHeroi2;
			lblItens2.BackColor = Color.Transparent;*/
			lblItens2.Visible = false;
			lblHeroi2.Visible = false;

		}

		private void cmbItem1Heroi1_SelectedIndexChanged(object sender, EventArgs e) {
			string selecao = cmbItem1Heroi1.SelectedIndex.ToString();
			if (selecao == "") {
				cmbItem1Heroi1.ResetText();
				cmbItem1Heroi1.SelectedItem = null;
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}
	}
}
