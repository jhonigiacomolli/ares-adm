using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHARP_INK.Classes
{
    class Classe_Listviews
    {
        public void Criar_LST_Veiculos(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("Numero OS", 100);
            LST.Columns.Add("Proprietário", 200);
            LST.Columns.Add("Veículo", 150);
            LST.Columns.Add("Placa", 100);
            LST.Columns.Add("Cor",200);
            LST.Columns.Add("Tamanho", 100);
            LST.Columns.Add("Data Cadastro", 100);
            LST.Columns.Add("Data Entrega", 100);
            LST.Columns.Add("Situação", 100);    
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

        
    }
}
