using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hylos : Heroi {
	public Hylos() {
		this.Nome = "Hylos";
		this.Imagem = MlbbX1Calculator.Properties.Resources.Hylos;
		this.DefesaFisica = 17;
		this.RegenHP = 42;
		this.AtaqueFisico = 105;
		this.Hp = 3309;
		this.VelAtaque = 0.43F;
	}
}
