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
    public partial class Question_Dichotomique : Form
    {
        public Question_Dichotomique()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtbox_numero_question.Text = "";
            txtbox_question_dicho.Text = "";
           
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RG3QUVA\MSSQLSERVER01;Initial Catalog=exam;Integrated Security=True");
        private void Question_Dichotomique_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_confirmer_Click(object sender, EventArgs e)
        {

            if (txtbox_numero_question.Text == "" || txtbox_question.Text == "")
            {
                MessageBox.Show("Compléter les données!!");
            }
            else
            {
                try
                {
                    cnx.Open();
                    if (radio_vrai.Checked)
                    {
                        radio_vrai. Text = "true";
                    }
                    else
                        radio_faux.Text= "false";
                    SqlCommand cmd = new SqlCommand("insert into Question_dicho(Numero,Question,Proposition_v,Proposition_f) values" +
                        "('" + txtbox_numero_question.Text + "','" + txtbox_question_dicho.Text + "','"
                        + radio_vrai.Text + "','" + radio_faux.Text + "')", cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question bien enregistré ");
                    cnx.Close();
                    Reset();
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
