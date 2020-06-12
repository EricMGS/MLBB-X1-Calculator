using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dyrroth : Heroi {
	private bool dobro = false;

	public Dyrroth() {
		this.Nome = "Dyrroth";
		this.Imagem = MlbbX1Calculator.Properties.Resources.Dyrroth;
		this.VelMovimento = 266;
		this.DefesaFisica = 19;
		this.DefesaMagica = 10;
		this.Mana = 0;
		this.RegenHP = 41;
		this.AtaqueFisico = 117;
		this.PoderMagico = 0;
		this.Hp = 2758;
		this.VelAtaque = 0.92F;
		this.RegenMana = 0;
	}

	//A cada dois ataques o próximo ataque causa o dobro de dano
	public override int atacar() {
		if (dobro == false) {
			dobro = true;
			return base.atacar();
		}
		dobro = false;
		return base.atacar() * 2;
	}
}
