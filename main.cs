using System;

class MainClass
{
	public static void Main (string[] args)
	{
		Universidad universidad = new Universidad();
		universidad.agregarEstudiante(new Estudiante(123, "Mateo", "Montaño", "Ing. Industrial"));
		universidad.agregarEstudiante(new Estudiante(456, "Marcos", "Terrazas", "Ing. Comercial"));
		universidad.agregarEstudiante(new Estudiante(789, "Lucas", "Campos", "Ing. Sistemas"));

		ExportarEstudiantes exportarEstudiantes = new ExportarEstudiantes(universidad);
		
		exportarEstudiantes.setStrategy(new CsvExportar());
		exportarEstudiantes.exportar(); 	

		Console.WriteLine("---------------------------------");

		exportarEstudiantes.setStrategy(new XmlExportar());
		exportarEstudiantes.exportar();

		Console.WriteLine("---------------------------------");

		exportarEstudiantes.setStrategy(new JsonExportar());
		exportarEstudiantes.exportar(); 	
	}
}
