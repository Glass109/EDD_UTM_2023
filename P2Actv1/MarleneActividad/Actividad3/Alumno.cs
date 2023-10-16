namespace Actividad3
{
    internal class Alumno
    {
        string[] mexicanNames = {
            "Alejandra González", "Luis Martínez", "Sofía Rodríguez", "Diego López",
            "Mariana Pérez", "Carlos Hernández", "Valentina Gómez", "Juan Torres",
            "Camila Ramírez", "Javier Díaz", "Ximena Vargas", "José Jiménez",
            "Fernanda Morales", "Andrés Castillo", "Isabella Mendoza", "Daniel Ortega",
            "Lucía Pacheco", "Miguel Silva", "Renata Cruz", "Sebastián Sánchez",
            "Regina Nava", "Mateo Espinosa", "Paula Rivera", "Emiliano Cordero",
            "María Fernández", "Santiago Ríos", "Valeria Guzmán", "Adrián Villa",
            "Diana Navarro", "Ángel Zavala", "Victoria Maldonado", "Óscar Peralta"
        };

        public string Name { get; set; }
        public float Calificacion { get; set; }
        public Alumno(string _name, float _calif)
        {
            Name = _name;
            Calificacion = _calif;
        }
        public Alumno()
        {
            Random rnd = new Random();
            Name = mexicanNames[rnd.Next(mexicanNames.Length)];
            Calificacion = (float)rnd.Next(101) / 10;
        }
    }
}
