using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosreal2
{
    class RepositorioAutos
    {
        public List<Datos> ListaAutos { get; set; } = new List<Datos>();
        private readonly string _archivo = Environment.CurrentDirectory + "\\Autos.txt";
        

        public RepositorioAutos()
        {
            LeerDatosDelArchivo();
        }
          


        public void Agregar (Datos datos)
        {
            GuardarEnArchivo(datos);
            ListaAutos.Add(datos);
        }

        private void GuardarEnArchivo(Datos datos)
        {
            
        }

       
        public List<Datos> GetListaOrdenadaAscendente()
        {
            return ListaAutos.OrderBy(c => c.Patente).ToList();

        }
        public List<Datos> GetListaOrdenadaDescendente()
        {
            return ListaAutos.OrderByDescending(c => c.Patente).ToList();
        }

        private string ConstruirLinea(Datos datos)
        {
            return $"{datos.Modelo};{datos.Marca};" +
                   $"{datos.Patente}" +
                   $"{datos.Aniodefabricacion}; {datos.Combustible.GetHashCode()}" +
                   $"{datos.Color}";
            



        }

        public void Borrar (Datos datos)
        {
            ListaAutos.Remove(datos);
        }
        
        public void Editar (Datos datos)
        {

        }


        public int GetCantidad()
        {
            return ListaAutos.Count;
        }

        public List<Datos> GetLista()
        {
            return ListaAutos;
        }

        public void LeerDatosDelArchivo()
        {
            var ruta = Directory.GetCurrentDirectory();
            var archivo = "Autos.csv";
            StreamReader lector = new StreamReader($"{ruta}\\{archivo}");
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Datos datos = ContruirAutos(linea);
                ListaAutos.Add(datos);
            }
            lector.Close();
        }

        private Datos ContruirAutos(string linea)
        {
            var campos = linea.Split(';');
            Datos datos = new Datos
            {
                Patente = campos[0],
                
                
              

            };
            return datos;
                 
        }

        public void GuardarDatosEnArchivo()
        {
            var ruta = Directory.GetCurrentDirectory();
            var archivo = "Autos.csv";
            StreamWriter escritor = new StreamWriter($"{ruta}\\{archivo}");
            foreach(var autos in ListaAutos)
            {
                var LineaCsv = construirLinea(autos);
                escritor.WriteLine(LineaCsv);
            }
            escritor.Close();
        }

        private string construirLinea(Datos autos)
        {
            string linea = $"{autos.Aniodefabricacion}";
            return linea;
        }
    }
    
}
