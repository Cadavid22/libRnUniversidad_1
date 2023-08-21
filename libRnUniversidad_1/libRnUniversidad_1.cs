using System.ComponentModel.DataAnnotations;

namespace libRnUniversidad_1

{
    public class libRnUniversidad_1
    {
        #region "Atributos"
        private int intTipoEst;

        private string strError;
        #endregion

        #region "Constructor"

        #endregion

        #region "Propiedades"
        //ENTRADA
        public int TipoEstudiante
        {
            set {intTipoEst = value;}  
        }
        //SALIDA
        public string Error
        { 
            get { return strError; }
        }
        #endregion

        #region "Metodos Privados"
        private bool leerArchivo()
        { 
            if(!Validar())
                return false;

            try
            { 
                
            }
        }
        #endregion

        #region "Metodos Publicos"

        #endregion
    }
}