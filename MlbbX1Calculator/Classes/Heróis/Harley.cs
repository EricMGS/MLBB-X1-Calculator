using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Harley : Heroi {
	public Harley() {
		this.Nome = "Harley";
		this.Imagem = MlbbX1Calculator.Properties.Resources.Harley;
		this.DefesaFisica = 19;
		this.RegenHP = 36;
		this.AtaqueFisico = 114;
		this.Hp = 2501;
		this.VelAtaque = 0.85F;
	}
}
