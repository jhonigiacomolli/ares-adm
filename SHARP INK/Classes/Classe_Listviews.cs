using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace SHARP_INK.Classes
{
    class Classe_Listviews
    {
        // LST_Veiculos
        public void Criar_LST_Veiculos(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("Numero OS", 100);
            LST.Columns.Add("Proprietário", 200);
            LST.Columns.Add("Veículo", 100);
            LST.Columns.Add("Placa", 100);
            LST.Columns.Add("Cor",200);
            LST.Columns.Add("Tamanho", 150);
            LST.Columns.Add("Cadastro", 100);
            LST.Columns.Add("Entrega", 100);
            LST.Columns.Add("Status OS", 100);    
        }

        public void Criar_CamposPesquisa(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Todos");
            TipoPesquisa.Items.Add("Numero OS");
            TipoPesquisa.Items.Add("Proprietário");
            TipoPesquisa.Items.Add("Veículo");
            TipoPesquisa.Items.Add("Placa");
            TipoPesquisa.Items.Add("Cor");
            TipoPesquisa.Items.Add("Tamanho");
            TipoPesquisa.Items.Add("Data Cadastro");
            TipoPesquisa.Items.Add("Data Entrega");
            TipoPesquisa.SelectedIndex = 0;
        }

        public void ColorirLinhas_veiculos(ListView LST)
        {
            foreach (ListViewItem Item in LST.Items)
            {
                if (Item.SubItems[8].Text.TrimEnd() == "ABERTA")
                {
                    Item.ForeColor = Classe_Tema.Linha_OSAberta;
                }
                if (Item.SubItems[8].Text == "FECHADA")
                {
                    Item.ForeColor = Classe_Tema.Linha_OSFechada;
                }
                if (Item.SubItems[8].Text == "AGUARDANDO")
                {
                    Item.ForeColor = Classe_Tema.Linha_OSAguardando;
                }
            }
        }


        // LST_Itens da OS
        public void Criar_LST_ItensOS(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("ID Veículo", 0);
            LST.Columns.Add("Código", 70);
            LST.Columns.Add("Categoria", 0);
            LST.Columns.Add("Descrição", 350);
            LST.Columns.Add("Quantidade", 80, HorizontalAlignment.Right);
            LST.Columns.Add("Unitário", 80,HorizontalAlignment.Right);
            LST.Columns.Add("Total", 80, HorizontalAlignment.Right);
        }

        //LST_Produtos
        public void Criar_LST_Produtos(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("Código", 90);
            LST.Columns.Add("Código de Fábrica", 90);
            LST.Columns.Add("Fornecedor", 100);
            LST.Columns.Add("Grupo", 170);
            LST.Columns.Add("Descrição", 335);
            LST.Columns.Add("Quantidade", 100, HorizontalAlignment.Right);
            LST.Columns.Add("Valor de Custo", 150,HorizontalAlignment.Right);
            LST.Columns.Add("Valor de Venda", 150, HorizontalAlignment.Right);
        }
        public void Criar_CamposPesquisaProdutos(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Código");
            TipoPesquisa.Items.Add("Código de Fábrica");
            TipoPesquisa.Items.Add("Grupo");
            TipoPesquisa.Items.Add("Fornecedor");
            TipoPesquisa.Items.Add("Descrição");
            TipoPesquisa.SelectedIndex = 4;
        }
    }
}
