using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//importes
using System.Text;
using System.Security.Cryptography;

namespace SHA512Project
{
    public partial class _Default : Page
    {
        //criptografando uma string.
        protected void Page_Load(object sender, EventArgs e)
        {
            var _resultado = criptografadaSHA512("mauriciojunior.org");
            Response.Write(_resultado);
        }

        /// <summary>
        /// Método que recebe valor
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private String criptografadaSHA512(string valor)
        {
            var _stringHash = "";
            try
            {
                UnicodeEncoding _encode = new UnicodeEncoding();
                byte[] _hashBytes, _messageBytes = _encode.GetBytes(valor);

                SHA512Managed _sha512Manager = new SHA512Managed();
                

                _hashBytes = _sha512Manager.ComputeHash(_messageBytes);

                foreach (byte b in _hashBytes)
                {
                    _stringHash += String.Format("{0:x2}", b);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _stringHash;
        }
    }
}