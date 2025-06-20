using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp8
{
    public enum Estado
    {
        Iniciada,
        EnProceso,
        Terminada
    }
    public class Tarea
    {
        private int codigo;
        private string descrip;
        private Estado estado;

        public int Codigo { get => codigo; }
        public string Descrip { get => descrip; }
        public Estado Estado { get => estado; }

        public Tarea(int codigo, string descrip, Estado estado)
        {
            this.codigo = codigo;
            this.descrip = descrip;
            this.estado = estado;
        }

        public int GetCodigo()
        {
            return codigo;
        }
        public Estado GetEstado()
        {
            return estado;
        }
        public string Descripcion()
        {
            return descrip;
        }
        
    }
}