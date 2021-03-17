using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Balcao
{
    class Etiqueta
    {
        public void GerarEtiqueta(string codigoInterno,string contador,string nome,PictureBox picLayout)
        {
            string codigoBarra = "";
            switch (codigoInterno.Count())
            {
                case 1: codigoBarra = "0000" + codigoInterno ; break;
                case 2: codigoBarra = "000" + codigoInterno; break;
                case 3: codigoBarra = "00" + codigoInterno; break;
                case 4: codigoBarra = "0" + codigoInterno; break;
                case 5: codigoBarra = codigoInterno; break;
            }
            switch (contador.Count())
            {
                case 1: codigoBarra += "00" + contador; break;
                case 2: codigoBarra += "0" + contador; break;
                case 3: codigoBarra += contador; break;

            }



            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            Bitmap croppedBitmap = CropBitmap(writer.Write(codigoBarra), 0, 0, 100, 30);
          
            Bitmap imgPicLayout = new Bitmap(picLayout.Width, picLayout.Height);


            Graphics desenho = Graphics.FromImage(imgPicLayout);

            #region Referencia
            // referencia
            desenho.Clear(Color.White);
            Rectangle rect = new Rectangle(5, 5, 110, 70);
            Pen lapis = new Pen(Color.Black, 2);
            Font fontTitulo = new Font("Calibri", 10, FontStyle.Bold);
            Font fontValor = new Font("Calibri", 14, FontStyle.Bold);
            Font font = new Font("Calibri", 7, FontStyle.Bold);
            Font fontMenor = new Font("Calibri", 8, FontStyle.Bold);
            SolidBrush cor = new SolidBrush(Color.Black);
            #endregion


            //montagem da etiqueta
            //desenho.DrawRectangle(lapis, rect);
            desenho.DrawString(nome, font, cor, 2, 3);
            desenho.DrawString("Mercado Tittio", font, cor, 50, 65);
            desenho.DrawString(codigoBarra, fontMenor, cor, 2, 55);
            desenho.DrawImage(croppedBitmap, 0, 25);
            picLayout.BackgroundImage = imgPicLayout;
          
        }

        public void GerarEtiquetaCodigo(string codigoInterno,  string nome, PictureBox picLayout)
        {
            string codigoBarra = "";
            switch (codigoInterno.Count())
            {
                case 1: codigoBarra = "0000" + codigoInterno; break;
                case 2: codigoBarra = "000" + codigoInterno; break;
                case 3: codigoBarra = "00" + codigoInterno; break;
                case 4: codigoBarra = "0" + codigoInterno; break;
                case 5: codigoBarra = codigoInterno; break;
            }
         



            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            Bitmap croppedBitmap = CropBitmap(writer.Write(codigoBarra), 0, 0, 100, 30);

            Bitmap imgPicLayout = new Bitmap(picLayout.Width, picLayout.Height);


            Graphics desenho = Graphics.FromImage(imgPicLayout);

            #region Referencia
            // referencia
            desenho.Clear(Color.White);
            Rectangle rect = new Rectangle(5, 5, 110, 70);
            Pen lapis = new Pen(Color.Black, 2);
            Font fontTitulo = new Font("Calibri", 10, FontStyle.Bold);
            Font fontValor = new Font("Calibri", 14, FontStyle.Bold);
            Font font = new Font("Calibri", 7, FontStyle.Bold);
            Font fontMenor = new Font("Calibri", 8, FontStyle.Bold);
            SolidBrush cor = new SolidBrush(Color.Black);
            #endregion


            //montagem da etiqueta
            //desenho.DrawRectangle(lapis, rect);
            desenho.DrawString(nome, font, cor, 2, 3);
            desenho.DrawString("Mercado Tittio", font, cor, 50, 65);
            desenho.DrawString(codigoBarra, fontMenor, cor, 2, 55);
            desenho.DrawImage(croppedBitmap, 0, 25);
            picLayout.BackgroundImage = imgPicLayout;

        }


        public void GerarEtiqueta1x(PictureBox picFinal, PictureBox picLayout01)
        {
            Bitmap imgPicLayout = new Bitmap(picFinal.Width, picFinal.Height);
            Graphics desenho = Graphics.FromImage(imgPicLayout);
            desenho.DrawImage(picLayout01.BackgroundImage, 0, 0);
           
            picFinal.BackgroundImage = imgPicLayout;
        }
        public void GerarEtiqueta2x(PictureBox picFinal, PictureBox picLayout01, PictureBox picLayout02)
        {
            Bitmap imgPicLayout = new Bitmap(picFinal.Width, picFinal.Height);
            Graphics desenho = Graphics.FromImage(imgPicLayout);
            desenho.DrawImage(picLayout01.BackgroundImage, 0, 0);
            desenho.DrawImage(picLayout02.BackgroundImage, 130, 0);
           
            picFinal.BackgroundImage = imgPicLayout;
        }
        public void GerarEtiqueta3x(PictureBox picFinal,PictureBox picLayout01, PictureBox picLayout02, PictureBox picLayout03)
        {
            Bitmap imgPicLayout = new Bitmap(picFinal.Width, picFinal.Height);
            Graphics desenho = Graphics.FromImage(imgPicLayout);
            desenho.DrawImage(picLayout01.BackgroundImage, 0, 0);
            desenho.DrawImage(picLayout02.BackgroundImage, 130, 0);
            desenho.DrawImage(picLayout03.BackgroundImage, 260, 0);
            picFinal.BackgroundImage = imgPicLayout;
        }

        public Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
        {
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
        }
        public string returnCodigobarra(string codigoInterno, string contador)
        {
            string codigoBarra = "";
            switch (codigoInterno.Count())
            {
                case 1: codigoBarra = "0000" + codigoInterno; break;
                case 2: codigoBarra = "000" + codigoInterno; break;
                case 3: codigoBarra = "00" + codigoInterno; break;
                case 4: codigoBarra = "0" + codigoInterno; break;
                case 5: codigoBarra = codigoInterno; break;
            }
            switch (contador.Count())
            {
                case 1: codigoBarra += "00" + contador; break;
                case 2: codigoBarra += "0" + contador; break;
                case 3: codigoBarra += contador; break;

            }
            return codigoBarra;
        }
    }
}
