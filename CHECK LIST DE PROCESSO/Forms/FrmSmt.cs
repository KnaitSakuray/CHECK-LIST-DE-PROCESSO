using CHECK_LIST_DE_PROCESSO.Class;
using LED_EPL.RJcontrols;
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

namespace CHECK_LIST_DE_PROCESSO.Forms
{
    public partial class FrmSmt : Form
    {
        // digita a matricula e aparece o nome da pessoa.
        private void rjMatricula_keyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                // consulta no banco de tados a matricula para mostra a pessoa que ele pertence.
                SqlConnection conecta = new SqlConnection(Conexao.ROTA);
                SqlCommand comande = new SqlCommand("SELECT [nome] FROM [ROTA].[dbo].[USUARIO] where usuario=@U", conecta);
                comande.Parameters.Add("@U", SqlDbType.VarChar).Value = rjMatricula.Text.ToString().PadLeft(4, '0');
                conecta.Open();
                SqlDataReader dr = comande.ExecuteReader();
                DataTable dt = new DataTable();

                // mostra o nome da pessoa.
                while (dr.Read())
                {
                    txtName.Text = (dr["nome"]).ToString().Trim();
                }
                conecta.Close();
            }
        }

        //consulta op e mostra no check list QtdOp e Codigo.
        private void LoadCodigo_OP()
        {
            SqlConnection cn = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd = new SqlCommand("select CKD, COUNT(*) from [ROTA].[dbo].CKD  WHERE STATUS = 'PENDENTE' group by CKD order by ckd desc", cn);


            cn.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            cbOp.DisplayMember = "CKD";
            cbOp.DataSource = dt1;
            cn.Close();

            cbOp.SelectedIndex = -1;
        }
        private void FrmCheckList_Load(object sender, EventArgs e)
        {
            rjTextBox21.Text = DateTime.Now.ToString("dd/MM/yyyyy HH:mm:ss");
            rjMenuIcon1.ForeColor = Color.Green;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
        }
        // escolher o turno 
        private void LoadTurno()
        {

            if (rjTurno1.Checked.Equals(true)) check_turno_ok = 1;
            else check_turno_ok = 2;

        }
        // cor/visibilidade do Botão para proxima tela
        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
            
        }
        //--------------------------------------------------------------------------------------------
        //check liste de processo

        private int check_turno_ok, check1_ok = 0, check2_ok = 0, check3_ok = 0,
        check4_ok = 0, check5_ok = 0, check6_ok = 0,
        check7_ok = 0;
        private int check1_nok = 0, check2_nok = 0, check3_nok = 0,
        check4_nok = 0, check5_nok = 0, check6_nok = 0,
        check7_nok = 0;
        private int check1_type = 0, check2_type = 0, check3_type = 0,
        check4_type = 0, check5_type = 0, check6_type = 0,
        check7_type = 0;



        private void rjOK7_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK6_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK5_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK4_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK3_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK2_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK1_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }
        private void CheckValues()
        {
           ClealVar();

            //OK
            if (rjOK1.Checked.Equals(true)) { check1_ok = 1; check1_type = 1; }
            if (rjOK2.Checked.Equals(true)) { check2_ok = 1; check2_type = 1; }
            if (rjOK3.Checked.Equals(true)) { check3_ok = 1; check3_type = 1; }
            if (rjOK4.Checked.Equals(true)) { check4_ok = 1; check4_type = 1; }
            if (rjOK5.Checked.Equals(true)) { check5_ok = 1; check5_type = 1; }
            if (rjOK6.Checked.Equals(true)) { check6_ok = 1; check6_type = 1; }
            if (rjOK7.Checked.Equals(true)) { check7_ok = 1; check7_type = 1; }

            // NOK
            if (rjN_OK1.Checked.Equals(true)) { check1_nok = 1; check1_type = 2; }
            if (rjN_OK2.Checked.Equals(true)) { check2_nok = 1; check2_type = 2; }
            if (rjN_OK3.Checked.Equals(true)) { check3_nok = 1; check3_type = 2; }
            if (rjN_OK4.Checked.Equals(true)) { check4_nok = 1; check4_type = 2; }
            if (rjN_OK5.Checked.Equals(true)) { check5_nok = 1; check5_type = 2; }
            if (rjN_OK6.Checked.Equals(true)) { check6_nok = 1; check6_type = 2; }
            if (rjN_OK7.Checked.Equals(true)) { check7_nok = 1; check7_type = 2; }
        }
        private void ClealVar()
        {
            check1_ok = 0; check2_ok = 0; check3_ok = 0;
            check4_ok = 0; check5_ok = 0; check6_ok = 0;
            check7_ok = 0;
            check1_nok = 0; check2_nok = 0; check3_nok = 0;
            check4_nok = 0; check5_nok = 0; check6_nok = 0;
            check7_nok = 0;

            check1_type = 0; check2_type = 0; check3_type = 0;
            check4_type = 0; check5_type = 0; check6_type = 0;
            check7_type = 0;

        }
        // cor/visibilidade do Botão para proxima tela
        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
        }

        //--------------------------------------------------------------------------
        // controle de temperatura


        private void rjMenuIcon3_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

        }
        public FrmSmt()
        {
            InitializeComponent();
            LoadCodigo_OP();
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;
        }
        //---------------------------------------------------------------
        /*
        private void DateServer()
        {
            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("SELECT GETDATE()", con);

            con.Open();
            DATET = Convert.ToDateTime(comande.ExecuteScalar());
            con.Close();
        }*/
        //---------------------------------------------------------------
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjN_A1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjN_A2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //---------------------------------------------------------------
    }
}
