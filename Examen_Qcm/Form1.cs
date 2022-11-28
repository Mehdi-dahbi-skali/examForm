using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Qcm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtbox_title.Text = "";
            txtbox_numero.Text = "";
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmer_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_examen_Click(object sender, EventArgs e)
        {
                if (txtbox_numero.Text == "" || txtbox_title.Text == "")
                {
                    MessageBox.Show("Compléter les données!!");
                }
                else
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("insert into Evaluation (Numero, Titre) values ('" + txtbox_numero.Text + "','" + txtbox_title.Text + "')" ,cnx);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Examen bien enregistré ");
                        cnx.Close();
                        Reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
        }

        private void radio_qcm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_question_Click(object sender, EventArgs e)
        {
            if (txtbox_numero.Text == "" || txtbox_title.Text == "")
            {
                MessageBox.Show("Ajouter un examen!!");
            }
            else
            {
                try
                {
                    if (radio_qcm.Checked)
                    {
                        QCM qcm = new QCM();
                        qcm.Show();
                        btn_ajouter_examen_Click(sender,e);
                    }
                    if (radio_dicho.Checked)
                    {
                        Question_Dichotomique qcm = new Question_Dichotomique();
                        qcm.Show();
                        btn_ajouter_examen_Click(sender, e);
                    }
                    if (radio_question.Checked)
                    {
                        Question_simple qcm = new Question_simple();
                        qcm.Show();
                        btn_ajouter_examen_Click(sender, e);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
