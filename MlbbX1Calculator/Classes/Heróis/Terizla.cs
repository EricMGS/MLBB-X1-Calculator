using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Terizla : Heroi {
	public Terizla() {
		this.Nome = "Terizla";
		this.Imagem = MlbbX1Calculator.Properties.Resources.Terizla;
		this.VelMovimento = 255;
		this.DefesaFisica = 19;
		this.DefesaMagica = 10;
		this.Mana = 0;
		this.RegenHP = 54;
		this.AtaqueFisico = 129;
		this.PoderMagico = 0;
		this.Hp = 2728;
		this.VelAtaque = 0.82F;
		this.RegenMana = 0;
	}

	//Este herói não recebe beneficios de velocidade de ataque
	public override float dps() {
		return this.AtaqueFisico * 0.82F;
	}
}
