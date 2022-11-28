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
    public partial class QCM : Form
    {
        public QCM()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtbox_numero_question.Text = "";
            txtbox_question_qcm.Text = "";
            txtbox_p1.Text = "";
            txtbox_p2.Text = "";
            txtbox_p3.Text = "";
            txtbox_p4.Text = "";
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
    
        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            if(txtbox_numero_question.Text == "" || txtbox_question_qcm.Text == "" || txtbox_p1.Text == "" || txtbox_p2.Text == "" || txtbox_p3.Text == "")
            {
                MessageBox.Show("Compléter les données!!");
            }
            else
            {
                try
                {   
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("insert into Question_qcm(Numero,Question,Proposition_1,Proposition_2,Proposition_3,Proposition_4) values" +
                        "('" + txtbox_numero_question.Text + "','" + txtbox_question_qcm.Text + "','"
                        + txtbox_p1.Text + "','" + txtbox_p2.Text + "','" + txtbox_p3.Text + "','" + txtbox_p4.Text + "')",cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question bien enregistré ");
                    cnx.Close();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void proposition3_qcm_Click(object sender, EventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txtbox_numero_question.Text == "" || txtbox_question_qcm.Text == "" || txtbox_p1.Text == "" || txtbox_p2.Text == "" || txtbox_p3.Text == "")
            {
                MessageBox.Show("Formations incomplète!!");
            }
            else
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update  Question_qcm set Question='"+ txtbox_question_qcm+"',"+"Proposition_1='"+txtbox_p1 + "'," + "Proposition_2='"+txtbox_p2 + "'," + "Proposition_3='"+txtbox_p3 + "'," + "Proposition_4='"+txtbox_p4+"'" +"'where Numero='"+ txtbox_numero_question + "'", cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question bien Modifié ");
                    cnx.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
