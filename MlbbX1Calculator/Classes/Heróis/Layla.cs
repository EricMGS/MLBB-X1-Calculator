using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Layla : Heroi{
	public Layla() {
		this.Nome = "Layla";
		this.Imagem = MlbbX1Calculator.Properties.Resources.Layla;
		this.VelMovimento = 240;
		this.DefesaFisica = 15;
		this.DefesaMagica = 10;
		this.Mana = 424;
		this.RegenHP = 27;
		this.AtaqueFisico = 130;
		this.PoderMagico = 0;
		this.Hp = 2500;
		this.VelAtaque = 0.85F;
		this.RegenMana = 14;
	}
}
