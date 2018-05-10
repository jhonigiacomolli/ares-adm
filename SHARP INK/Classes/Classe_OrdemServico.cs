using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using SHARP_INK.Classes;


namespace SHARP_INK.Classes
{
    class Classe_OrdemServico
    {
        public void Incluir_OrdemServico(string Proprietario, string Veiculo, string Placa, string Cor, string Tamanho, DateTime DataCadastro, string Situacao)
        {


            SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

            
            string comandoSQL = "INSERT INTO Veiculos(Proprietario,Veiculo,Placa,Cor,Tamanho,Data_Cadastro,Situacao)" +
                        " VALUES ('" + Proprietario + "','" + Veiculo + "','" + Placa + "','" + Cor + "','" + Tamanho + "','" + DataCadastro + "','" + Situacao + "')";

            SqlCeCommand CMD = new SqlCeCommand(comandoSQL,CONN);
            
            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
        }
    }
}
