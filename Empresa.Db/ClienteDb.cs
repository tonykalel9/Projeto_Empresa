﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 using Empresa.Models;
using System.Net.Http.Headers;

namespace Empresa.Db
{
    public   class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            //codigo para incluir cliente
            string sql = "INSERT INTO Cliente(Id, Nome, Email, Telefone) VALUES (@Id, @Nome, @Email, @Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();          
        }

        public void Alterar(Cliente cliente)
        {
            //codigo para alterar cliente
            string sql = "UPDATE Cliente SET Nome = @Nome, Telefone = @Telefone, Email = @Email  WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Excluir(int Id)
        {
            //Codigo para deletar cliente
            string sql = "DELETE FROM Cliente WHERE Id=@Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", Id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public Cliente ObterPorId (int id)
        {
            string sql = @"SELECT   Id, Nome, Telefone, Email 
                            FROM    Cliente 
                            WHERE   Id=@Id";

            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", id);

            Cliente cliente = null;

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();
                cliente.Email = reader["Email"].ToString();
            }

            reader.Close();
            cn.Close();
            return cliente;
            
        }
        
        public List<Cliente> Listar ()
        {
            string sql = "SELECT Id, Nome, Telefone, Email FROM Cliente";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            List<Cliente> lista = new List<Cliente>();

            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();
                cliente.Email = reader["Email"].ToString();

                lista.Add(cliente);
            }
            reader.Close();
            cn.Close();
            return lista;

        }
    }
}
