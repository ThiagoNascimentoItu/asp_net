using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using mvc_bo.Services;

namespace mvc_bo.Models
{
    public class AlunoBLL : IAlunoBLL
    {
        public void AtualizarAluno(Aluno aluno)
        {
            var configuration = ConfigurationHelpers.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuration.GetConnectionString("DefaultConnection");

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(aluno);
            //try
            //{
            //    using (SqlConnection con = new SqlConnection("IncluirAluno"))
            //    {
            //        SqlCommand cmd = new SqlCommand("AtualizarAluno", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        SqlParameter paramNome = new SqlParameter();
            //        paramNome.ParameterName = "@Nome";
            //        paramNome.Value = aluno.Nome;
            //        cmd.Parameters.Add(paramNome);

            //        SqlParameter paramEmail = new SqlParameter();
            //        paramEmail.ParameterName = "@Email";
            //        paramEmail.Value = aluno.Email;
            //        cmd.Parameters.Add(paramEmail);

            //        SqlParameter paramSexo = new SqlParameter();
            //        paramSexo.ParameterName = "@Sexo";
            //        paramSexo.Value = aluno.Sexo;
            //        cmd.Parameters.Add(paramSexo);

            //        SqlParameter paramNascimento = new SqlParameter();
            //        paramNascimento.ParameterName = "@Nascimento";
            //        paramNascimento.Value = aluno.Nascimento;
            //        cmd.Parameters.Add(paramNascimento);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
        public List<Aluno> GetAlunos()
        {
            var configuration = ConfigurationHelpers.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuration.GetConnectionString("DefaultConnection");

            List<Aluno> alunos = new List<Aluno>();

            Aluno aluno = new Aluno();
            aluno.Id = 1;
            aluno.Nome = "Thiago";
            aluno.Sexo = "Masculino";
            aluno.Email = "thiago@email.com";
            aluno.Nascimento = DateTime.Now;
            alunos.Add(aluno);
            return alunos;

            //try
            //{
            //    using (SqlConnection con = new SqlConnection(conexaoString))
            //    {
            //        SqlCommand cmd = new SqlCommand("GetAlunos", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        SqlDataReader rdr = cmd.ExecuteReader();
            //        while (rdr.Read())
            //        {
            //            Aluno aluno = new Aluno();
            //            aluno.Id = Convert.ToInt32(rdr["Id"]);
            //            aluno.Nome = rdr["Nome"].ToString();
            //            aluno.Sexo = rdr["Sexo"].ToString();
            //            aluno.Nascimento = Convert.ToDateTime(rdr["Nascimento"]);
            //            alunos.Add(aluno);
            //        }
            //    }
            //    return alunos;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
        public void IncluirAluno(Aluno aluno)
        {
            var configuration = ConfigurationHelpers.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuration.GetConnectionString("DefaultConnection");

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(aluno);
            //try
            //{
            //    using (SqlConnection con = new SqlConnection("IncluirAluno"))
            //    {
            //        SqlCommand cmd = new SqlCommand("IncluirAluno", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        SqlParameter paramNome = new SqlParameter();
            //        paramNome.ParameterName = "@Nome";
            //        paramNome.Value = aluno.Nome;
            //        cmd.Parameters.Add(paramNome);

            //        SqlParameter paramEmail = new SqlParameter();
            //        paramEmail.ParameterName = "@Email";
            //        paramEmail.Value = aluno.Email;
            //        cmd.Parameters.Add(paramEmail);

            //        SqlParameter paramSexo = new SqlParameter();
            //        paramSexo.ParameterName = "@Sexo";
            //        paramSexo.Value = aluno.Sexo;
            //        cmd.Parameters.Add(paramSexo);

            //        SqlParameter paramNascimento = new SqlParameter();
            //        paramNascimento.ParameterName = "@Nascimento";
            //        paramNascimento.Value = aluno.Nascimento;
            //        cmd.Parameters.Add(paramNascimento);
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        public void DeletaAluno(int id)
        {
            var configuration = ConfigurationHelpers.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuration.GetConnectionString("DefaultConnection");

            //try
            //{
            //    using (SqlConnection con = new SqlConnection(conexaoString))
            //    {
            //        SqlCommand cmd = new SqlCommand("DeletarAluno", con);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        SqlParameter paramId = new SqlParameter();
            //        paramId.ParameterName = "@Id";
            //        paramId.Value = id
            //        cmd.Parameters.Add(paramId);
            //con.Open();
            //cmd.ExecuteNonQuery();

        }
    }
}
