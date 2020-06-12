using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.PropertyGridInternal;

class Heroi : Stats{
	private Hashtable itens = new Hashtable();
	private string nome;
	private bool danoReal = false;
	private Image imagem;

	public string Nome { get => nome; set => nome = value; }
	public bool DanoReal { get => danoReal; set => danoReal = value; }
	public Image Imagem { get => imagem; set => imagem = value; }

	public void regenerarHP() {
		this.Hp = this.RegenHP / 5;
	}

	public float ataquesPorSegundo() {
		return 0.83F * this.VelAtaque;
	}

	public virtual float dps() {
		return this.AtaqueFisico * this.ataquesPorSegundo();
	}

	public virtual int atacar() {
		Random crit = new Random();
		if (this.ChanceCritico * 100 <= crit.Next(0, 100))
			return (int)((this.dps() * (1+this.DanoCritico)) * this.penetracaoArmadura());
		return (int)(this.dps() * this.penetracaoArmadura());
	}

	public float penetracaoArmadura() {
		return 1 + ((0.00845F * this.PenFisica) / (1 + 0.00845F * this.PenFisica));
	}

	public int danoReduzido(int dano) {
		float reducao =  1 - ((0.00845F * this.DefesaFisica) / (1 + 0.00845F * this.DefesaFisica));
		return (int)(dano * reducao);
	}

	public void recebeDano(int danoFisico) {
		this.Hp -= this.danoReduzido(danoFisico);
	}

	public void recebeDano(int danoFisico, bool isDanoReal) {
		this.Hp -= danoFisico;
	}

	public bool addItem(Item item) {
		if (this.itens.Contains(item.Nome)) {
			return false;
		} 
		else {
			this.itens.Add(item.Nome, item);
			return true;
		}
	}

	public void removeItem(string nome) {
		this.itens.Remove(nome);
	}
}