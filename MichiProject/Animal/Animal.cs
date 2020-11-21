using MichiProject.Animal.Enums;
using MichiProject.Animal.Interfaces;
using System;

namespace MichiProject.Animal
{
    /// <summary>
    /// Super clase del reino animal
    /// Aqui van todos los atributos comunes de los animales
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Clasificacion filogenetica de menos especifico a mas especifico
        /// </summary>
        #region [Propiedades]
        public string Reino { get; set; }
        public string Filo { get; set; }
        public string Clase { get; set; }
        public string Orden { get; set; }
        public string Familia { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        #endregion [Propiedades]

        #region[Constructor]
         public Animal()
        {
            this.Reino = EnumReino.Animal.ToString();
        }
        #endregion[Constructor]

        #region [Metodos Abstractos]
        // Al usar virtual el compiladir no obliga a implementarlo
        public virtual void Alimentacion() { }
        public virtual void Comunicacion() { }
        public virtual void Movimiento() { }
        public virtual void Reproduccion() { }
        public virtual void Respiracion() { }
        #endregion [Metodos Abstractos]
    }
}