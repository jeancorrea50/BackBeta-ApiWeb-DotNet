//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Runtime.Serialization.Json;
//using System.Text;
//using System.Threading.Tasks;

//namespace BackOffice.Infrastructure.CrossCutting.Utilities
//{
//    public class PdfHelper
//    {
//        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
       

//        public void CriarTexto(PdfPTable tabela, string texto, int alinhamentoHorz = Element.ALIGN_LEFT, bool negrito = false, bool italico = false, int tamanhoFonte = 11, int alturaCelula = 18)
//        {
//            int estilo = Font.NORMAL;

//            if (negrito && italico)
//            {
//                estilo = Font.BOLDITALIC;
//            }
//            else if (negrito)
//            {
//                estilo = Font.BOLD;
//            }
//            else if (italico)
//            {
//                estilo = Font.ITALIC;

//            }

//            var fonteCelula = new Font(fonteBase, tamanhoFonte, estilo, BaseColor.BLACK);

//            var celula = new PdfPCell(new Phrase(texto, fonteCelula));


//            celula.HorizontalAlignment = Element.ALIGN_LEFT;
//            celula.VerticalAlignment = Element.ALIGN_MIDDLE;
//            celula.Border = 0;
//            celula.FixedHeight = alturaCelula;

//            tabela.AddCell(celula);
//        }

//        public string ConverteStringBase64(string texto)
//        {
//            try
//            {
//                byte[] textoAsBytes = Encoding.ASCII.GetBytes(texto);
//                string resultado = System.Convert.ToBase64String(textoAsBytes);
//                return resultado;
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}
