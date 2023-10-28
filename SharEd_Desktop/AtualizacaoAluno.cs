﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharEd_Desktop
{
    public partial class AtualizacaoAluno : Form
    {
        int opcao = 0;
        public AtualizacaoAluno(int op)
        {
            InitializeComponent();
            if(op == 1)
            {
                opcao = 1;
            }
            if(op == 2)
            {
                btnAtualizar.Visible = false;
                opcao = 2;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int ra = int.Parse(txtRa.Text);
            int serie = int.Parse(txtSerie.Text);
            Aluno aluno = new Aluno(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, serie);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                Aluno aluno = new Aluno(int.Parse(txtRa.Text));
                MySqlDataReader dr = aluno.consultarAluno02();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRg.Text = dr["rg"].ToString();
                    txtSerie.Text = dr["classe"].ToString();
                    txtNascimento.Text = dr["dataNascimento"].ToString();
                    txtTelefone.Text = dr["celular"].ToString();
                    txtEmail.Text = dr["emailInstitucional"].ToString();
                    txtRg.Enabled = false;
                    txtRa.Enabled = false;
                    if(opcao==1)
                    {
                        txtNome.Enabled = true;
                        txtRg.Enabled = true;
                        txtSerie.Enabled = true;
                        txtNascimento.Enabled = true;
                        txtTelefone.Enabled = true;
                        txtEmail.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não cadastrado!");
                    txtRa.Text = "";
                }
                DAO_Conexao.con.Close();
                /*int n = aluno.verificaAtivo();
                if (n == 1)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }*/

            }
        }
    }
}
