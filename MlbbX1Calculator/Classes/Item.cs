using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item : Stats{
	private Heroi heroi;
	private string nome = "";

	internal Heroi Heroi { get => heroi; set => heroi = value; }
	public string Nome { get => nome; set => nome = value; }

	public void add(Heroi heroi) {
		this.heroi = heroi;
		//this.heroi.addItem(this);
		this.heroi.Hp += this.Hp;
		this.heroi.Mana += this.Mana;
		this.heroi.AtaqueFisico += this.AtaqueFisico;
		this.heroi.DefesaFisica += this.DefesaFisica;
		this.heroi.PenFisica += this.PenFisica;
		this.heroi.RegenHP += this.RegenHP;
		this.heroi.RegenMana += this.RegenMana;
		this.heroi.PoderMagico += this.PoderMagico;
		this.heroi.DefesaMagica += this.DefesaMagica;
		this.heroi.PenMagica += this.PenMagica;
		this.heroi.VelMovimento += this.VelMovimento;
		this.heroi.PenFisicaPorc += this.PenFisicaPorc;
		this.heroi.RouboVidaFisico += this.RouboVidaFisico;
		this.heroi.PenMagicaPorc += this.PenMagicaPorc;
		this.heroi.RouboVidaMagico += this.RouboVidaMagico;
		this.heroi.RedCooldown += this.RedCooldown;
		this.heroi.ChanceCritico += this.ChanceCritico;
		this.heroi.DanoCritico += this.DanoCritico;
		this.heroi.Vampirismo += this.Vampirismo;
		this.heroi.VelAtaque *= this.VelAtaque;
}

	public void remove() {
		if (this.heroi != null) {
			this.heroi.removeItem(this.Nome);
			this.heroi.Hp -= this.Hp;
			this.heroi.Mana -= this.Mana;
			this.heroi.AtaqueFisico -= this.AtaqueFisico;
			this.heroi.DefesaFisica -= this.DefesaFisica;
			this.heroi.PenFisica -= this.PenFisica;
			this.heroi.RegenHP -= this.RegenHP;
			this.heroi.RegenMana -= this.RegenMana;
			this.heroi.PoderMagico -= this.PoderMagico;
			this.heroi.DefesaMagica -= this.DefesaMagica;
			this.heroi.PenMagica -= this.PenMagica;
			this.heroi.VelMovimento -= this.VelMovimento;
			this.heroi.PenFisicaPorc -= this.PenFisicaPorc;
			this.heroi.RouboVidaFisico -= this.RouboVidaFisico;
			this.heroi.PenMagicaPorc -= this.PenMagicaPorc;
			this.heroi.RouboVidaMagico -= this.RouboVidaMagico;
			this.heroi.RedCooldown -= this.RedCooldown;
			this.heroi.ChanceCritico -= this.ChanceCritico;
			this.heroi.DanoCritico -= this.DanoCritico;
			this.heroi.Vampirismo -= this.Vampirismo;
			this.heroi.VelAtaque -= this.VelAtaque;
		}
	}
}
