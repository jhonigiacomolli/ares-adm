using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_Listviews
    {
        public string SelecaoAnterior;

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
            LST.Columns.Add("Cor", 200);
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
            LST.Columns.Add("Unitário", 80, HorizontalAlignment.Right);
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
            LST.Columns.Add("Valor de Custo", 150, HorizontalAlignment.Right);
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

        //LST_Funcionarios
        public void Criar_LST_FuncionariosAlocados(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("ID_Funcionario", 0);
            LST.Columns.Add("ID_Veiculo", 0);
            LST.Columns.Add("Funcionário", 150);
            LST.Columns.Add("Função", 100);
            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO") || Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
            {
                LST.Columns.Add("Horario Entrada", 115);
                LST.Columns.Add("Horario Saida", 115);
                LST.Columns.Add("Tempo Trabalho", 85);
                LST.Columns.Add("Custo", 100);
                LST.Columns.Add("MO", 0);
            }
        }

        public void Criar_LST_Funcionarios(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("Nome", 300);
            LST.Columns.Add("Endereço", 260);
            LST.Columns.Add("Telefone", 100);
            LST.Columns.Add("Email", 200);
            LST.Columns.Add("Sexo", 80);
            LST.Columns.Add("Cargo", 150);
            LST.Columns.Add("Salario", 0);
            LST.Columns.Add("Comissão", 0);
            LST.Columns.Add("CargaHoraria", 0);
            LST.Columns.Add("Valor Hora", 0);
        }

        public void Criar_CamposPesquisaFuncionarios(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Nome");
            TipoPesquisa.Items.Add("Endereço");
            TipoPesquisa.Items.Add("Sexo");
            TipoPesquisa.Items.Add("Função");
            TipoPesquisa.SelectedIndex = 0;
        }

        public void Criar_CamposPesquisaPecasReparacao(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Peça");
            TipoPesquisa.SelectedIndex = 0;
        }

        public void Criar_CamposPesquisaPecasComplementares(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Grupo");
            TipoPesquisa.Items.Add("Descrição");
            TipoPesquisa.Items.Add("Aplicação");
            TipoPesquisa.Items.Add("Fornecedor");
            TipoPesquisa.SelectedIndex = 1;
        }

        //LST_PecasPrincipais
        public void Criar_LST_Pecas(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("Código", 90);
            LST.Columns.Add("Grupo", 90);
            LST.Columns.Add("Descrição", 350);
            LST.Columns.Add("Aplicação", 170);
            LST.Columns.Add("Estoque", 100);
            LST.Columns.Add("Valor de Custo", 100, HorizontalAlignment.Right);
            LST.Columns.Add("Valor de Venda", 150, HorizontalAlignment.Right);
            LST.Columns.Add("Fornecedor", 105, HorizontalAlignment.Right);
        }

        public void Criar_LST_PecasReparacao(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("Código", 50);
            LST.Columns.Add("Peca", 200);
        }

        public void Criar_LST_PecasPrincipais(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("ID Veiculo", 0);
            LST.Columns.Add("ID Peça", 0);
            LST.Columns.Add("Peça Principal", 140);
            LST.Columns.Add("% Dano", 45);
            LST.Columns.Add("Tipo Peça", 140);
        }

        public void Criar_LST_PecasComplementares(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("ID Veiculo", 0);
            LST.Columns.Add("ID Peça", 0);
            LST.Columns.Add("Peça Complementar", 145);
            LST.Columns.Add("Aplicação", 60);
            LST.Columns.Add("QNT", 40);
            LST.Columns.Add("Unitário", 50);
            LST.Columns.Add("Total", 50);
        }

        public void Criar_ComboDano(ComboBox CBO)
        {
            CBO.Items.Add("100");
            CBO.Items.Add("90");
            CBO.Items.Add("80");
            CBO.Items.Add("70");
            CBO.Items.Add("60");
            CBO.Items.Add("50");
            CBO.Items.Add("40");
            CBO.Items.Add("30");
            CBO.Items.Add("20");
            CBO.Items.Add("10");
        }

        public void Criar_ComboTipoPeca(ComboBox CBO)
        {
            CBO.Items.Add("SUBSTITUIÇÃO OEM");
            CBO.Items.Add("SUBSTITUIÇÃO OEM USADA");
            CBO.Items.Add("SUBSTITUIÇÃO PARALELA");
            CBO.Items.Add("RECUPERAÇÃO");
        }

        public void Criar_LST_Catalise(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;

            LST.Columns.Add("ID", 0);
            LST.Columns.Add("Codigo Catalise", 0);
            LST.Columns.Add("Codigo Produto", 0);
            LST.Columns.Add("Produto", 300);
            LST.Columns.Add("Proporção", 70, HorizontalAlignment.Center);
            LST.Columns.Add("Peso Especifico", 0);
            LST.Columns.Add("Quantidade (Gramas)", 115, HorizontalAlignment.Right);
            if (Classe_Configuracoes.ValorCatalises.Equals("TRUE")) { LST.Columns.Add("Valor", 85, HorizontalAlignment.Right); } else { LST.Columns.Add("Valor", 0); }
            LST.Columns.Add("Tipo_BD", 0);
        }

        public void Criar_LST_AditivosCatalise(ListView LST)
        {
            LST.GridLines = true;
            //LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = false;
            LST.CheckBoxes = true;

            LST.Columns.Add("Produto", 180);
            LST.Columns.Add("ID", 0);
            LST.Columns.Add("Codigo Catalise", 0);
            LST.Columns.Add("Codigo Produto", 0);
            LST.Columns.Add("Proporção", 70, HorizontalAlignment.Center);
            LST.Columns.Add("Peso Especifico", 0);
            LST.Columns.Add("Quantidade (Gramas)", 70, HorizontalAlignment.Right);
            if (Classe_Configuracoes.ValorCatalises.Equals("TRUE")) { LST.Columns.Add("Valor", 60, HorizontalAlignment.Right); } else { LST.Columns.Add("Valor", 0); }
            LST.Columns.Add("Tipo_BD", 0);

        }

        public void Criar_LST_ItensOrcamento(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;


            LST.Columns.Add("ID", 0);
            LST.Columns.Add("ID Orçamento", 0);
            LST.Columns.Add("Operação", 130);
            LST.Columns.Add("Código Peça", 95);
            LST.Columns.Add("Descrição", 245);
            LST.Columns.Add("Quantidade", 70, HorizontalAlignment.Right);
            LST.Columns.Add("Valor Bruto", 75, HorizontalAlignment.Right);
            LST.Columns.Add("Desconto (%)", 75, HorizontalAlignment.Center);
            LST.Columns.Add("Valor Liquido", 75, HorizontalAlignment.Right);
            LST.Columns.Add("Valor Total", 75, HorizontalAlignment.Center);
            LST.Columns.Add("Horas", 50, HorizontalAlignment.Center);
            LST.Columns.Add("Pintura", 50, HorizontalAlignment.Center);
        }

        public void Criar_LST_Orcamentos(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;


            LST.Columns.Add("Nº Orçamento", 80);
            LST.Columns.Add("Data Abertura", 80);
            LST.Columns.Add("ID_Proprietario", 0);
            LST.Columns.Add("Proprietário", 280);
            LST.Columns.Add("Montadora", 95);
            LST.Columns.Add("Veiculo", 130);
            LST.Columns.Add("Placa", 95);
            LST.Columns.Add("Seguro", 100);
            LST.Columns.Add("Total", 120);
            LST.Columns.Add("ID_Orçamentista", 0);
            LST.Columns.Add("Orçamentista", 180);
        }

        public void Criar_LST_Clientes(ListView LST)
        {
            LST.GridLines = true;
            LST.FullRowSelect = true;
            LST.AllowColumnReorder = true;
            LST.View = View.Details;
            LST.HideSelection = true;


            LST.Columns.Add("Código", 40);
            LST.Columns.Add("TipoCadastro", 120);
            LST.Columns.Add("Nome/Razão Social", 280);
            LST.Columns.Add("Apelido/Fantasia", 280);
            LST.Columns.Add("CPF/CNPJ", 0);
            LST.Columns.Add("Data Nascimento", 0);
            LST.Columns.Add("Endereço", 0);
            LST.Columns.Add("Numero", 0);
            LST.Columns.Add("Bairro", 0);
            LST.Columns.Add("Cidade", 95);
            LST.Columns.Add("CEP", 0);
            LST.Columns.Add("Estado", 55);
            LST.Columns.Add("Telefone", 0);
            LST.Columns.Add("Email", 0);
        }

        public void AlteraCorSelecao(ListView LST)
        {
            //foreach (ListViewItem item2 in LST.Items)
            //{
            //    item2.BackColor = new Classe_Tema().COR_Background_Listview;
            //    item2.ForeColor = Color.Black;
            //}
            //var item = LST.FocusedItem;

            //item.Selected = false;
            //if (LST.Items[item.Index].Focused)
            //{
            //    LST.Items[item.Index].BackColor = Classe_Tema.TextBox_Destaque;
            //    LST.Items[item.Index].ForeColor = Color.White;
            //}

            //var item = LST.FocusedItem;

            //item.Selected = false;
            //if (LST.Items[item.Index].Focused)
            //{
            //    LST.Items[item.Index].BackColor = Classe_Tema.TextBox_Destaque;
            //    LST.Items[item.Index].ForeColor = Color.White;

            //    if (SelecaoAnterior.Equals(string.Empty))
            //    {
            //        SelecaoAnterior = item.Index.ToString();
            //        LST.Items[int.Parse(SelecaoAnterior)].BackColor = new Classe_Tema().COR_Background_Listview;
            //        LST.Items[int.Parse(SelecaoAnterior)].ForeColor = Color.Black;
            //        return;
            //    }
            //    else
            //    {
            //        LST.Items[int.Parse(SelecaoAnterior)].BackColor = new Classe_Tema().COR_Background_Listview;
            //        LST.Items[int.Parse(SelecaoAnterior)].ForeColor = Color.Black;
            //    }


            //    SelecaoAnterior = item.Index.ToString();
            //}
        }
        public void AlteraCorSelecao(ListView LST, string Tipo)
        {
            //foreach (ListViewItem item2 in LST.Items)
            //{
            //    if (Tipo.Equals("OS"))
            //    {
            //        item2.BackColor = new Classe_Tema().COR_Background_Listview;
            //        ColorirLinhas_veiculos(LST);
            //    }
            //    else
            //    {
            //        item2.BackColor = new Classe_Tema().COR_Background_Listview;
            //        item2.ForeColor = Color.Black;
            //    }

            //}
            //var item = LST.FocusedItem;

            //item.Selected = false;
            //if (LST.Items[item.Index].Focused)
            //{
            //    LST.Items[item.Index].BackColor = Classe_Tema.TextBox_Destaque;
            //    LST.Items[item.Index].ForeColor = Color.White;

            //    if (SelecaoAnterior != null)
            //    {
            //        LST.Items[SelecaoAnterior.Index].BackColor = new Classe_Tema().COR_Background_Listview;
            //        LST.Items[SelecaoAnterior.Index].ForeColor = Color.Black;
            //    }


            //    SelecaoAnterior = item;
            //}
        }
    }
}
