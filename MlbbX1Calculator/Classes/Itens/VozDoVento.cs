using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VozDoVento : Item {
	public VozDoVento() {
		this.Nome = "Voz do vento";
		this.VelAtaque = 1.1F;
		this.ChanceCritico = 10;
	}

	~VozDoVento() {
		this.remove();
	}
}

