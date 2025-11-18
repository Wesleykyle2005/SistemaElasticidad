using System.Collections.Generic;
using CapaEntidades;

namespace CapaDatos
{
    public class MaterialRepositorio
    {
        private List<Material> materiales;

        public MaterialRepositorio()
        {
            InicializarMateriales();
        }

        private void InicializarMateriales()
        {
            materiales = new List<Material>
            {
                new Material("Aluminio", 7.0e10, 7.5e10, 2.5e10, 2.2e8),
                new Material("Latón", 9.0e10, 6.0e10, 3.5e10, 4.7e8),
                new Material("Cobre", 11e10, 14e10, 4.4e10, 0),
                new Material("Cristal corona", 6.0e10, 5.0e10, 2.5e10, 10e8),
                new Material("Hierro", 21e10, 16e10, 7.7e10, 3.0e8),
                new Material("Plomo", 1.6e10, 4.1e10, 0.6e10, 0),
                new Material("Níquel", 21e10, 17e10, 7.8e10, 0),
                new Material("Acero", 20e10, 16e10, 7.5e10, 5e8),
                new Material("Bronce fosforado", 0, 0, 0, 5.6e8),
                new Material("Vidrio", 0, 0, 0, 10e8)
            };
        }

        public List<Material> ObtenerTodos()
        {
            return new List<Material>(materiales);
        }

        public Material ObtenerPorNombre(string nombre)
        {
            return materiales.Find(m => m.Nombre == nombre);
        }

        public void AgregarMaterial(Material material)
        {
            materiales.Add(material);
        }

        public bool ActualizarMaterial(string nombreOriginal, Material materialActualizado)
        {
            var material = ObtenerPorNombre(nombreOriginal);
            if (material != null)
            {
                material.Nombre = materialActualizado.Nombre;
                material.ModuloYoung = materialActualizado.ModuloYoung;
                material.ModuloVolumen = materialActualizado.ModuloVolumen;
                material.ModuloCorte = materialActualizado.ModuloCorte;
                material.EsfuerzoRotura = materialActualizado.EsfuerzoRotura;
                material.Compresibilidad = materialActualizado.Compresibilidad;
                return true;
            }
            return false;
        }

        public bool EliminarMaterial(string nombre)
        {
            var material = ObtenerPorNombre(nombre);
            if (material != null)
            {
                materiales.Remove(material);
                return true;
            }
            return false;
        }
    }
}