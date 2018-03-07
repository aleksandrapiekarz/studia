public class MainPlayer {

	private int _Zdrowie;
	private int _Glod;
	private int _Woda;

	public MainPlayer() {
		_Zdrowie = 150;
		_Glod = 150;
		_Woda = 150;
	}

	public int Zdrowie {
		get { return _Zdrowie; }
		set { _Zdrowie = value; }
	}

	public int Glod {
		get { return _Glod; }
		set { _Glod = value; }
	}

	public int Woda {
		get { return _Woda; }
		set { _Woda = value; }
	}
}
