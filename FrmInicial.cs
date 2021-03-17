using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balcao
{
    public partial class FrmInicial : Form
    {

        ConexaoDB conexao = new ConexaoDB();
        bool status = false;
        bool codigoEncontrado = false;
        int cont = 0;
        public FrmInicial()
        {
            InitializeComponent();
        }



      


        #region Imprimir Ok
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picFinal.Width, picLayout01.Height);
            picFinal.DrawToBitmap(bm, new Rectangle(0, 0, picFinal.Width, picFinal.Height));
            e.Graphics.DrawImage(bm, 25, 10);

        }
       
        #endregion
        #region Interface
        void ExibirMsd(string x)
        {
            cont = 0;
            lblStatus.Text = x;
        }
        private void TimerMsg_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont > 3)
            {
                lblStatus.Text = "Status";
                
            }
        }
      
        private void FrmInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{Tab}");
                if (txtCodigodeBarra.Focused)
                {
                    AlterarBipado();
                }
            }
        }

        #endregion
        void VarrerGrid()
        {
            try
            {
                string subControle = "0";

                int total = dataGridView.Rows.Count;
                int ordem = 0;
                for (int i = 0; i < total - 1; i++)
                {
                    subControle = dataGridView.Rows[i].Cells[0].Value.ToString();

                    ordem = i + 1;

                    if (int.Parse(subControle) != ordem)
                    {
                        conexao.barControle = ordem;
                        i = total + 1;
                    }
                    else
                    {
                        if (int.Parse(subControle) == (total - 1))
                        {
                            conexao.barControle = total;
                            i = total + 1;
                        }
                    }
                }
                if (conexao.barControle == null)
                {
                    conexao.barControle = 1;
                }
            }
            catch (Exception a)
            {
                conexao.barControle = 1;
            }
        }
        void DadosVariaveisBar()
        {


          //conexao.barData = DateTime.Now.ToString("dd/MM/yyyy");
            conexao.barData = DateTime.Now.Date.ToOADate();
            conexao.barHora = DateTime.Now.ToString("HH:mm:ss");
            conexao.barControle = conexao.barControle;
        }
        void LimparTela()
        {
            txtCodigodeBarra.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtQuantidade.Focus();
        }
        void ImprimirRef(PictureBox pic)
        {
            try
            {
                conexao.BuscarDadosProdutosRef(txtCodigodeBarra.Text);
                if (conexao.codigo == null)
                {
                    conexao.BuscarDadosProdutosCodigoRef(txtCodigodeBarra.Text);
                    if (conexao.codigo != null)
                    {
                        conexao.BuscarDadosProdutos(int.Parse(conexao.codigo.ToString()));
                    }
                    else
                    {
                        ExibirMsd("Produto não Encontrado");
                    }
                }
                else
                {
                    if (conexao.categoria.ToString().Equals("CALÇADOS") || conexao.categoria.ToString().Equals("VIDRO"))
                    {
                        conexao.CarregarDataGridAccess(dataGridView);
                        VarrerGrid();
                        Etiqueta etiqueta = new Etiqueta();
                        etiqueta.GerarEtiqueta(conexao.codigo.ToString(), conexao.barControle.ToString(), conexao.nome.ToString(), pic);
                        conexao.barCodigoBarra = etiqueta.returnCodigobarra(conexao.codigo.ToString(), conexao.barControle.ToString());
                        DadosVariaveisBar();
                        conexao.InsertProducaoCodBarBalcao();
                        conexao.ObjVazio();


                    }
                    else
                    {
                       ExibirMsd("Produto de Categoria Errada");
                    }
                }


            }
            catch { }
        }
        void ImprimirCod(PictureBox pic)
        {
            try
            {
                if (!codigoEncontrado)
                {
                    conexao.BuscarDadosProdutos(int.Parse(txtCodigodeBarra.Text));
                }

                if (conexao.codigo == null)
                {
                    ExibirMsd("Produto não Encontrado");
                }
                else
                {
                    Etiqueta etiqueta = new Etiqueta();
                    etiqueta.GerarEtiquetaCodigo(conexao.codigo.ToString(), conexao.nome.ToString(), pic);
                }

            }
            catch { }
        }



        void ImprimirEstoque(PictureBox picP)
        {
            if (txtCodigodeBarra.Text.Count() > 0 && txtCodigodeBarra.Text.Count() < 6)
            {
                try
                {
                    ImprimirCod(picP);
                }
                catch
                {

                }
            }
        }
        void ImprimirBalcao(PictureBox picP)
        {
            ImprimirRef(picP);
        }

        void EventoEstoque()
        {
            try
            {
                int quantidade = 1;
                try
                {
                    quantidade = int.Parse(txtQuantidade.Text);
                }
                catch { }
                if (quantidade > 1)
                {
                    int rep = 0;
                    int rep3 = 0;
                    int resto = 0;
                    int ultimo = 0;

                    resto = quantidade % 3;

                    if (resto != 0)
                    {
                        ultimo = quantidade - resto;
                    }
                    else
                    {
                        ultimo = 999999999;
                    }

                    while (quantidade > rep)
                    {


                        if (quantidade >= 3)
                        {
                            if (rep != ultimo)
                            {
                                rep3++;
                                switch (rep3)
                                {
                                    case 1: ImprimirEstoque(picLayout01); break;
                                    case 2: ImprimirEstoque(picLayout02); break;

                                    case 3:
                                        ImprimirEstoque(picLayout03);
                                        Etiqueta etiqueta = new Etiqueta();
                                        etiqueta.GerarEtiqueta3x(picFinal, picLayout01, picLayout02, picLayout03);
                                        rep3 = 0;
                                        printDocument1.Print();
                                        break;
                                }
                            }

                            else
                            {
                                Etiqueta etiqueta = new Etiqueta();
                                switch (resto)
                                {
                                    case 1:
                                        ImprimirEstoque(picLayout01);
                                        etiqueta.GerarEtiqueta1x(picFinal, picLayout01);
                                        rep = quantidade;
                                        printDocument1.Print();
                                        break;





                                    case 2:
                                        ImprimirEstoque(picLayout01);
                                        ImprimirEstoque(picLayout02);
                                        etiqueta.GerarEtiqueta2x(picFinal, picLayout01, picLayout02);
                                        rep = quantidade;
                                        printDocument1.Print();
                                        break;


                                }




                            }






                        }
                        else
                        {
                            ImprimirEstoque(picLayout01);
                            ImprimirEstoque(picLayout02);
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.GerarEtiqueta2x(picFinal, picLayout01, picLayout02);
                            rep = quantidade;
                            printDocument1.Print();
                        }


                        rep++;
                    }






                }
                else
                {
                    ImprimirEstoque(picLayout01);
                    Etiqueta etiqueta = new Etiqueta();
                    etiqueta.GerarEtiqueta1x(picFinal, picLayout01);
                    printDocument1.Print();

                }

            }
            catch { }
            finally
            {
                txtCodigodeBarra.Text = string.Empty;
                txtQuantidade.Text = string.Empty;
                conexao.ObjVazio();
            }
        }
        void EventoBalcao()
        {
            try
            {
                int quantidade = 1;
                try
                {
                    quantidade = int.Parse(txtQuantidade.Text);
                }
                catch { }
                if (quantidade > 1)
                {
                    int rep = 0;
                    int rep3 = 0;
                    int resto = 0;
                    int ultimo = 0;

                    resto = quantidade % 3;

                    if (resto != 0)
                    {
                        ultimo = quantidade - resto;
                    }
                    else
                    {
                        ultimo = 999999999;
                    }

                    while (quantidade > rep)
                    {


                        if (quantidade >= 3)
                        {
                            if (rep != ultimo)
                            {
                                rep3++;
                                switch (rep3)
                                {
                                    case 1: ImprimirBalcao(picLayout01); break;
                                    case 2: ImprimirBalcao(picLayout02); break;

                                    case 3:
                                        ImprimirBalcao(picLayout03);
                                        Etiqueta etiqueta = new Etiqueta();
                                        etiqueta.GerarEtiqueta3x(picFinal, picLayout01, picLayout02, picLayout03);
                                        rep3 = 0;
                                        printDocument1.Print();
                                        break;
                                }
                            }

                            else
                            {
                                Etiqueta etiqueta = new Etiqueta();
                                switch (resto)
                                {
                                    case 1:
                                        ImprimirBalcao(picLayout01);
                                        etiqueta.GerarEtiqueta1x(picFinal, picLayout01);
                                        rep = quantidade;
                                        printDocument1.Print();
                                        break;





                                    case 2:
                                        ImprimirBalcao(picLayout01);
                                        ImprimirBalcao(picLayout02);
                                        etiqueta.GerarEtiqueta2x(picFinal, picLayout01, picLayout02);
                                        rep = quantidade;
                                        printDocument1.Print();
                                        break;


                                }




                            }






                        }
                        else
                        {
                            ImprimirBalcao(picLayout01);
                            ImprimirBalcao(picLayout02);
                            Etiqueta etiqueta = new Etiqueta();
                            etiqueta.GerarEtiqueta2x(picFinal, picLayout01, picLayout02);
                            rep = quantidade;
                            printDocument1.Print();
                        }


                        rep++;
                    }






                }
                else
                {
                    ImprimirBalcao(picLayout01);
                    Etiqueta etiqueta = new Etiqueta();
                    etiqueta.GerarEtiqueta1x(picFinal, picLayout01);
                    printDocument1.Print();

                }

            }
            catch { }
            finally
            {
                txtCodigodeBarra.Text = string.Empty;
                txtQuantidade.Text = string.Empty;
                conexao.ObjVazio();
            }
        }

      


        void AlterarBipado()
        {
            try
            {
                if (txtCodigodeBarra.Text.Count() >= 5)
                {

                    try
                    {
                        conexao.BuscarDadosProdutosProdCod(txtCodigodeBarra.Text);
                    }
                    catch (Exception a)
                    {
                        conexao.codBarra = null;
                    }

                    try
                    {
                        if (conexao.codBarra != null)
                        {
                            conexao.AlterarBipadoTrue(txtCodigodeBarra.Text);
                            ExibirMsd("Bipado");
                        }
                    }
                    catch
                    {
                       
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                LimparTela();
            }
            
        }
        private void BtnBalcao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigodeBarra.Text.Count() > 0 && txtQuantidade.Text.Count() > 0)
                {
                    EventoBalcao();
                }
                else
                {
                    ExibirMsd("Valor de Quantidade ou Codigo Faltando");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                LimparTela();
            }
           
            
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigodeBarra.Text.Count() > 0 && txtQuantidade.Text.Count() > 0)
                {
                    EventoEstoque();
                }
                else
                {
                    ExibirMsd("Valor de Quantidade ou Codigo Faltando");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                LimparTela();
            }
        }

       
    }
}
