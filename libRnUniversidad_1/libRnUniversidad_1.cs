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
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt";
                int intCant = 0;
                string strLinea;
                string strCodigo;
                string strCodigo;
                float fltNota;
                itnCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath);
                while ((strLinea = Archivo.ReadLine()) != null)
                {
                    vectorLinea = strLinea.Split(':');
                    strCodigo = vectorLinea[0];
                    fltNota = Convert.ToSingle(vectorLinea[1]);
                    if (strCodigo == intTipoEst.ToString() && fltProm >= fltNota)
                    {
                        fltValCredito = Convert.ToSingle(vectorLinea[2]);
                        IntCredit = Convert.ToInt16(vectorLinea[3]);
                        fltDesc = Convert.ToSingle(vectorLinea[4]);
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion

        #region "Metodos Publicos"

        #endregion
    }
}