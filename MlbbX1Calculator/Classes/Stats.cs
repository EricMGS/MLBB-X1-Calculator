using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Stats {
	//atributos
	private int hp = 0;
	private int mana = 0;
	private int ataqueFisico = 0;
	private int defesaFisica = 0;
	private int penFisica = 0;
	private int regenHP = 0;
	private int regenMana = 0;
	private int poderMagico = 0;
	private int defesaMagica = 0;
	private int penMagica = 0;
	private int velMovimento = 0;
	private float penFisicaPorc = 0;
	private float rouboVidaFisico = 0;
	private float penMagicaPorc = 0;
	private float rouboVidaMagico = 0;
	private float redCooldown = 0;
	private float chanceCritico = 0;
	private float danoCritico = 0;
	private float vampirismo = 0;
	private float velAtaque = 0;

	//propriedades
	public int Hp { 
		get => hp;
		set {
			hp = value > 0 ? value : 0;
		}
	}
	public int Mana { 
		get => mana;
		set {
			mana = value > 0 ? value : 0;
		}
	}
	public int AtaqueFisico {
		get => ataqueFisico;
		set {
			ataqueFisico = value > 0 ? value : 0;
		}
	}
	public int DefesaFisica {
		get => defesaFisica;
		set {
			defesaFisica = value > 0 ? value : 0;
		}
	}
	public int PenFisica {
		get => penFisica;
		set {
			penFisica = value > 0 ? value : 0;
		}
	}
	public int RegenHP {
		get => regenHP;
		set {
			regenHP = value > 0 ? value : 0;
		}
	}
	public int RegenMana {
		get => regenMana;
		set {
			regenMana = value > 0 ? value : 0;
		}
	}
	public int PoderMagico {
		get => poderMagico;
		set
		{
			poderMagico = value > 0 ? value : 0;
		}
	}
	public int DefesaMagica {
		get => defesaMagica;
		set {
			defesaMagica = value > 0 ? value : 0;
		}
	}
	public int PenMagica {
		get => penMagica;
		set {
			penMagica = value > 0 ? value : 0;
		}
	}
	public int VelMovimento {
		get => velMovimento;
		set {
			velMovimento = value > 0 ? value : 0;
		}
	}
	public float PenFisicaPorc {
		get => penFisicaPorc;
		set {
			penFisicaPorc = value > 0 ? value : 0F;
		}
	}
	public float RouboVidaFisico {
		get => rouboVidaFisico;
		set {
			if (value >= 0 && value <= 1F)
				rouboVidaFisico = value;
			else if (value < 0)
				rouboVidaFisico = 0F;
			else
				rouboVidaFisico = 1F;
		}
	}
	public float PenMagicaPorc {
		get => penMagicaPorc;
		set {
			penMagicaPorc = value > 0 ? value : 0F;
		}
	}
	public float RouboVidaMagico {
		get => rouboVidaMagico;
		set {
			if (value >= 0 && value <= 1)
				rouboVidaMagico = value;
			else if (value < 0)
				rouboVidaMagico = 0F;
			else
				rouboVidaMagico = 1F;
		}
	}
	public float RedCooldown {
		get => redCooldown;
		set {
			if (value >= 0 && value <= 0.4)
				redCooldown = value;
			else if (value < 0)
				redCooldown = 0F;
			else
				redCooldown = 0.4F;
		}
	}
	public float ChanceCritico {
		get => chanceCritico;
		set {
			if (value >= 0 && value <= 1F)
				chanceCritico = value;
			else if (value < 0)
				chanceCritico = 0F;
			else
				chanceCritico = 1F;
		}
	}
	public float DanoCritico {
		get => danoCritico;
		set {
			danoCritico = value > 0 ? value : 0F;
		}
	}
	public float Vampirismo {
		get => vampirismo;
		set {
			if (value >= 0 && value <= 1F)
				vampirismo = value;
			else if (value < 0)
				vampirismo = 0F;
			else
				vampirismo = 1F;
		}
	}
	public float VelAtaque {
		get => velAtaque;
		set {
			if (value >= 0 && value <= 2.5F)
				velAtaque = value;
			else if (value < 0)
				vampirismo = 0F;
			else
				velAtaque = 2.5F;
		}
	}
}
