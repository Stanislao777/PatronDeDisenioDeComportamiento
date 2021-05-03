class Estudiante
{
	private int ci;
	private string nombre;
	private string apellido;
	private string carrera;

	public Estudiante(int ci, string nombre, string apellido, string carrera)
	{
		this.ci = ci;
		this.nombre = nombre;
		this.apellido = apellido;
		this.carrera = carrera;
	}

	public int getCi()
	{
		return ci;
	}

	public string getNombre()
	{
		return nombre;
	}

	public string getApellido()
	{
		return apellido;
	}

	public string getCarrera()
	{
		return carrera;
	}
}