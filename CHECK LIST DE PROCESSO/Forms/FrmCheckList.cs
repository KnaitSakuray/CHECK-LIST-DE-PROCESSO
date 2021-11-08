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
    public partial class FrmCheckList : Form
    {
        private int check_1_ok = 0, check_2_ok = 0, check_3_ok = 0,
        check_4_ok = 0, check_5_ok = 0, check_6_ok = 0,
        check_7_ok = 0, check_8_ok = 0, check_9_ok = 0,
        check_10_ok = 0, check_11_ok = 0, check_12_ok = 0,
        check_13_ok = 0, check_14_ok = 0, check_15_ok = 0,
        check_16_ok = 0, quant_total_ok = 0;

        private int QTDPAllet;
        private int QtdOp;
        private int NQAtotal;

        DateTime DATET;

        private string CodPa;

        private void rjOK11_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK12_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK13_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK14_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK15_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK16_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK16_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK15_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK14_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK13_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK12_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK11_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK10_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK9_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK8_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK7_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK6_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK5_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK4_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK3_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK2_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjN_OK1_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK10_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK9_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjOK8_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void cbOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conecta = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand(@"
  SELECT C.modelo as MM, [qtdporcaixafinal] as qcf, C.qtd 
  FROM [ROTA].[dbo].[CKD] as C 
  INNER JOIN[ROTA].[dbo].[MODELO] as M ON M.pn = C.modelo
  where C.ckd = @ckd and C.status = 'PENDENTE'", conecta);

            comande.Parameters.Add("@ckd", SqlDbType.VarChar).Value = cbOp.Text;


            conecta.Open();
            SqlDataReader dr = comande.ExecuteReader();
            DataTable dt = new DataTable();

            while (dr.Read())
            {
                TxtCod.Text = (dr["MM"]).ToString().Trim();
                CodPa = (dr["MM"]).ToString().Trim();
                txtQtd.Text = (dr["qtd"]).ToString().Trim();
                QtdOp = Convert.ToInt32((dr["qtd"]).ToString().Trim());
                QTDPAllet = Convert.ToInt32((dr["qcf"]).ToString().Trim());
            }

            ChackListVisible();
        }

        private void LoadCaixa()
        {
            string src = txtScanCaixa.Text.Substring(txtScanCaixa.Text.Length - 10).Replace("'", "-");

            SqlConnection conecta = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand(@"
            SELECT [numero]
            ,[modelo]
            ,[sn1]
            ,[ckd]
            ,[linha]
	        ,modelosn1 as peloL
	        ,modelosn2 as pesoB
	        ,gabinete2 as ean
            
  FROM [ROTA].[dbo].[EMBALAGEM] as E
  INNER JOIN [ROTA].[dbo].[MODELO] as M ON E.modelo=M.pn
  where numero=@num
            ", conecta);

            comande.Parameters.Add("@num", SqlDbType.VarChar).Value = src;


            conecta.Open();
            SqlDataReader dr = comande.ExecuteReader();
            DataTable dt = new DataTable();

            while (dr.Read())
            {
                lblSn.Text = (dr["sn1"]).ToString().Trim();
                lblEan.Text = (dr["ean"]).ToString().Trim();
                lblPl.Text = (dr["peloL"]).ToString().Trim();
                lblPb.Text = (dr["pesoB"]).ToString().Trim();
               
            }
            conecta.Close();
        }

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            InsertV1();
            RJMessageBox.Show("Check List salvo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtScanCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadCaixa();
            }
        }

        private void rjOK7_CheckedChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void rjMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conecta = new SqlConnection(Conexao.ROTA);
                SqlCommand comande = new SqlCommand("SELECT [nome] FROM [ROTA].[dbo].[USUARIO] where usuario=@U", conecta);
                comande.Parameters.Add("@U", SqlDbType.VarChar).Value = rjMatricula.Text.ToString().PadLeft(4,'0');
                conecta.Open();
                SqlDataReader dr = comande.ExecuteReader();
                DataTable dt = new DataTable();
                while (dr.Read())
                {
                    txtName.Text = (dr["nome"]).ToString().Trim();
                }
                conecta.Close();
            }
        }

        private void rjMatricula_KeyUp(object sender, KeyEventArgs e)
        {

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

        private int check_1_nok = 0, check_2_nok = 0, check_3_nok = 0,
            check_4_nok = 0, check_5_nok = 0, check_6_nok = 0,
            check_7_nok = 0, check_8_nok = 0, check_9_nok = 0,
            check_10_nok = 0, check_11_nok = 0, check_12_nok = 0,
            check_13_nok = 0, check_14_nok = 0, check_15_nok = 0,
            check_16_nok = 0, quant_total_nok = 0;
        private int check_1_type = 0, check_2_type = 0, check_3_type = 0,
          check_4_type = 0, check_5_type = 0, check_6_type = 0,
          check_7_type = 0, check_8_type = 0, check_9_type = 0,
          check_10_type = 0, check_11_type = 0, check_12_type = 0,
          check_13_type = 0, check_14_type = 0, check_15_type = 0,
          check_16_type = 0, quant_total_type = 0;

        private void FrmCheckList_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Refresh();
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Refresh();
        }

        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel4.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
            rjMenuIcon4.ForeColor = Color.Green;
        }

        private void rjMenuIcon3_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel5.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
            rjMenuIcon4.ForeColor = Color.Green;

        }

        private void rjMenuIcon4_Click(object sender, EventArgs e)
        {
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;

            panel3.Visible = true;
            panel5.Visible = false;
            panel4.Visible = false;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
            rjMenuIcon4.ForeColor = Color.Green;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private int check_1_na = 0, check_2_na = 0, check_3_na = 0,
            check_4_na = 0, check_5_na = 0, check_6_na = 0,
            check_7_na = 0, check_8_na = 0, check_9_na = 0,
            check_10_na = 0, check_11_na = 0, check_12_na = 0,
            check_13_na = 0, check_14_na = 0, check_15_na = 0,
            check_16_na = 0, quant_total_na = 0, check_turno = 0;

        private int qtd_inspecionadas ;
        private int qtd_pallet ;
        private int pallet_1 ;
        private int pallet_2 ;
        private int pallet_3 ;
        private int pallet_4 ;
        private int pallet_5 ;
        private int pallet_6 ;
        private int pallet_7 ;
        private int pallet_8 ;
        private int pallet_9 ;
        private int pallet_10 ;
        private int pallet_11 ;
        private int pallet_12 ;
        private int pallet_13 ;
        private int pallet_14 ;
        private int pallet_15 ;
        private int pallet_16 ;
        private int pallet_17 ;
        private int pallet_18 ;
        private int pallet_19 ;
        private int pallet_20 ;
        private int pallet_21 ;
        private int pallet_22 ;
        private int pallet_23 ;
        private int pallet_24 ;
        private int pallet_25 ;
        private int pallet_26 ;
        private int pallet_27 ;
        private int pallet_28 ;
        private int pallet_29 ;
        private int pallet_30 ;
        private int pallet_31 ;
        private int pallet_32 ;
        private int ok_pallet ;
        private int nok_pallet ;

        private int NqaUsing;



        public FrmCheckList()
        {
            InitializeComponent();
            LoadCodigo_OP();
            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;
        }

        private void ChackListVisible()
        {
            double NqaArredondamento = 0;
            int validador = 0;
            decimal validador1 = 0;

            NqaArredondamento =Convert.ToDouble(QtdOp) / Convert.ToDouble(QTDPAllet);

            if (Int32.TryParse(NqaArredondamento.ToString(), out validador)) 
            {
                NqaUsing = (int)NqaArredondamento;
            }
            else if (Decimal.TryParse(NqaArredondamento.ToString(), out validador1))
            {
                NqaUsing = (int)NqaArredondamento + 1;
            }
           
            lblQtdPallet.Text = QTDPAllet.ToString();
            labelOPqtd.Text = NqaUsing.ToString();
            if (QTDPAllet <= 1)
            {
                NQAtotal = 1;
                rjCheckBox1.Visible = true;
            }
            else if(QTDPAllet > 1 && QTDPAllet <= 25)
            {
                NQAtotal = 2;
            }
            else if (QTDPAllet > 25 && QTDPAllet <= 50)
            {
                NQAtotal = 3;
            }
            else if (QTDPAllet > 50 && QTDPAllet <= 90)
            {
                NQAtotal = 5;
            }
            else if (QTDPAllet > 90 && QTDPAllet <= 150)
            {
                NQAtotal = 8;
            }
            else if (QTDPAllet > 150 && QTDPAllet <= 280)
            {
                NQAtotal = 13;
            }
            else if (QTDPAllet > 280 && QTDPAllet <= 500)
            {
                NQAtotal = 20;
            }
            else if (QTDPAllet > 500 && QTDPAllet <= 1200)
            {
                NQAtotal = 32;
  
            }

            rjCheckBox1.Visible = true; 
            if (NqaUsing < 2) rjCheckBox2.Visible = false; else rjCheckBox2.Visible = true;
            if (NqaUsing < 3) rjCheckBox3.Visible = false; else rjCheckBox3.Visible = true;
            if (NqaUsing < 4) rjCheckBox4.Visible = false; 
            else rjCheckBox4.Visible = true;
            if (NqaUsing < 5) rjCheckBox5.Visible = false;
            else rjCheckBox5.Visible = true;
            if (NqaUsing < 6) rjCheckBox6.Visible = false; else rjCheckBox6.Visible = true;
            if (NqaUsing < 7) rjCheckBox7.Visible = false; else rjCheckBox7.Visible = true;
            if (NqaUsing < 8) rjCheckBox8.Visible = false; else rjCheckBox8.Visible = true;
            if (NqaUsing < 9) rjCheckBox9.Visible = false; else rjCheckBox9.Visible = true;
            if (NqaUsing < 10) rjCheckBox10.Visible = false; else rjCheckBox10.Visible = true;
            if (NqaUsing < 11) rjCheckBox11.Visible = false; else rjCheckBox11.Visible = true;
            if (NqaUsing < 12) rjCheckBox12.Visible = false; else rjCheckBox12.Visible = true;
            if (NqaUsing < 13) rjCheckBox13.Visible = false; else rjCheckBox13.Visible = true;
            if (NqaUsing < 14) rjCheckBox14.Visible = false; else rjCheckBox14.Visible = true;
            if (NqaUsing < 15) rjCheckBox15.Visible = false; else rjCheckBox15.Visible = true;
            if (NqaUsing < 16) rjCheckBox16.Visible = false; else rjCheckBox16.Visible = true;
            if (NqaUsing < 17) rjCheckBox17.Visible = false; else rjCheckBox17.Visible = true;
            if (NqaUsing < 18) rjCheckBox18.Visible = false; else rjCheckBox18.Visible = true;
            if (NqaUsing < 19) rjCheckBox19.Visible = false; else rjCheckBox19.Visible = true;
            if (NqaUsing < 20) rjCheckBox20.Visible = false; else rjCheckBox20.Visible = true;
            if (NqaUsing < 21) rjCheckBox21.Visible = false; else rjCheckBox21.Visible = true;
            if (NqaUsing < 22) rjCheckBox22.Visible = false; else rjCheckBox22.Visible = true;
            if (NqaUsing < 23) rjCheckBox23.Visible = false; else rjCheckBox23.Visible = true;
            if (NqaUsing < 24) rjCheckBox24.Visible = false; else rjCheckBox24.Visible = true;
            if (NqaUsing < 25) rjCheckBox25.Visible = false; else rjCheckBox25.Visible = true;
            if (NqaUsing < 26) rjCheckBox26.Visible = false; else rjCheckBox26.Visible = true;
            if (NqaUsing < 27) rjCheckBox27.Visible = false; else rjCheckBox27.Visible = true;
            if (NqaUsing < 28) rjCheckBox28.Visible = false; else rjCheckBox28.Visible = true;
            if (NqaUsing < 29) rjCheckBox29.Visible = false; else rjCheckBox29.Visible = true;
            if (NqaUsing < 30) rjCheckBox30.Visible = false; else rjCheckBox30.Visible = true;
            if (NqaUsing < 31) rjCheckBox31.Visible = false; else rjCheckBox31.Visible = true;
            if (NqaUsing < 32) rjCheckBox32.Visible = false; else rjCheckBox32.Visible = true;

            labelPallet.Text = NQAtotal.ToString();
        }

        private void LoadCodigo_OP()
        {

            //carrega combobox modelo x cliente
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
            txtScanCaixa.BorderColor = Color.Green;

            rjMenuIcon1.IconColor = Color.Green;
            rjMenuIcon2.IconColor = Color.Green;
            rjMenuIcon3.IconColor = Color.Green;

            rjMenuIcon1.ForeColor = Color.Green;
            rjMenuIcon2.ForeColor = Color.Green;
            rjMenuIcon3.ForeColor = Color.Green;
        }
        private void ClearAll()
        {

            rjMatricula.Text = "";
            txtName.Text = "";
            txtQtd.Text = "";
            txtObs.Text = "";
            TxtCod.Text = "";
            txtScanCaixa.Text = "";
            cbOp.Text = "";
            CbLinha.Text = "";
            lblEan.Text = "";
            lblSn.Text = "";
            lblPl.Text = "";
            lblPb.Text = "";

            rjCheckBox1.Visible = false;
            rjCheckBox2.Visible = false;
            rjCheckBox3.Visible = false;
            rjCheckBox4.Visible = false;
            rjCheckBox5.Visible = false;
            rjCheckBox6.Visible = false;
            rjCheckBox7.Visible = false;
            rjCheckBox8.Visible = false;
            rjCheckBox9.Visible = false;
            rjCheckBox10.Visible = false;
            rjCheckBox11.Visible = false;
            rjCheckBox12.Visible = false;
            rjCheckBox13.Visible = false;
            rjCheckBox14.Visible = false;
            rjCheckBox15.Visible = false;
            rjCheckBox16.Visible = false;
            rjCheckBox17.Visible = false;
            rjCheckBox18.Visible = false;
            rjCheckBox19.Visible = false;
            rjCheckBox20.Visible = false;
            rjCheckBox21.Visible = false;
            rjCheckBox22.Visible = false;
            rjCheckBox23.Visible = false;
            rjCheckBox24.Visible = false;
            rjCheckBox25.Visible = false;
            rjCheckBox26.Visible = false;
            rjCheckBox27.Visible = false;
            rjCheckBox28.Visible = false;
            rjCheckBox29.Visible = false;
            rjCheckBox30.Visible = false;
            rjCheckBox31.Visible = false;
            rjCheckBox32.Visible = false;

            rjCheckBox1.Checked = false;
            rjCheckBox2.Checked = false;
            rjCheckBox3.Checked = false;
            rjCheckBox4.Checked = false;
            rjCheckBox5.Checked = false;
            rjCheckBox6.Checked = false;
            rjCheckBox7.Checked = false;
            rjCheckBox8.Checked = false;
            rjCheckBox9.Checked = false;
            rjCheckBox10.Checked = false;
            rjCheckBox11.Checked = false;
            rjCheckBox12.Checked = false;
            rjCheckBox13.Checked = false;
            rjCheckBox14.Checked = false;
            rjCheckBox15.Checked = false;
            rjCheckBox16.Checked = false;
            rjCheckBox17.Checked = false;
            rjCheckBox18.Checked = false;
            rjCheckBox19.Checked = false;
            rjCheckBox20.Checked = false;
            rjCheckBox21.Checked = false;
            rjCheckBox22.Checked = false;
            rjCheckBox23.Checked = false;
            rjCheckBox24.Checked = false;
            rjCheckBox25.Checked = false;
            rjCheckBox26.Checked = false;
            rjCheckBox27.Checked = false;
            rjCheckBox28.Checked = false;
            rjCheckBox29.Checked = false;
            rjCheckBox30.Checked = false;
            rjCheckBox31.Checked = false;
            rjCheckBox32.Checked = false;

        }

        private void ClealVar()
        {
               check_1_ok = 0; check_2_ok = 0; check_3_ok = 0;
        check_4_ok = 0; check_5_ok = 0; check_6_ok = 0;
        check_7_ok = 0; check_8_ok = 0; check_9_ok = 0;
        check_10_ok = 0; check_11_ok = 0; check_12_ok = 0;
        check_13_ok = 0; check_14_ok = 0; check_15_ok = 0;
        check_16_ok = 0; quant_total_ok = 0;
        check_1_nok = 0; check_2_nok = 0; check_3_nok = 0;
            check_4_nok = 0; check_5_nok = 0; check_6_nok = 0;
            check_7_nok = 0; check_8_nok = 0; check_9_nok = 0;
            check_10_nok = 0; check_11_nok = 0; check_12_nok = 0;
            check_13_nok = 0; check_14_nok = 0; check_15_nok = 0;
            check_16_nok = 0; quant_total_nok = 0;
         check_1_na = 0; check_2_na = 0; check_3_na = 0;
            check_4_na = 0; check_5_na = 0; check_6_na = 0;
            check_7_na = 0; check_8_na = 0; check_9_na = 0;
            check_10_na = 0; check_11_na = 0; check_12_na = 0;
            check_13_na = 0; check_14_na = 0; check_15_na = 0;
            check_16_na = 0; quant_total_na = 0;

            check_1_type = 0; check_2_type = 0; check_3_type = 0;
            check_4_type = 0; check_5_type = 0; check_6_type = 0;
            check_7_type = 0; check_8_type = 0; check_9_type = 0;
            check_10_type = 0; check_11_type = 0; check_12_type = 0;
            check_13_type = 0; check_14_type = 0; check_15_type = 0;
            check_16_type = 0; quant_total_type = 0;
            

        }
        private void LoadTurno()
        {

            if(rjTurno1.Checked.Equals(true)) check_turno = 1;
            else check_turno = 2;

        }
        private void CheckValues()
        {
            ClealVar();

            if (rjOK1.Checked.Equals(true)) { check_1_ok=1; check_1_type = 1;}
            if (rjOK2.Checked.Equals(true)) { check_2_ok = 1; check_2_type = 1;}
            if (rjOK3.Checked.Equals(true)) { check_3_ok = 1; check_3_type = 1;}
            if (rjOK4.Checked.Equals(true)) { check_4_ok = 1; check_4_type = 1;}
            if (rjOK5.Checked.Equals(true)) { check_5_ok = 1; check_5_type = 1;}
            if (rjOK6.Checked.Equals(true)) { check_6_ok = 1; check_6_type = 1;}
            if (rjOK7.Checked.Equals(true)) { check_7_ok = 1; check_7_type = 1;}
            if (rjOK8.Checked.Equals(true)) { check_8_ok = 1; check_8_type = 1;}
            if (rjOK9.Checked.Equals(true)) { check_9_ok = 1; check_9_type = 1;}
            if (rjOK10.Checked.Equals(true)) { check_10_ok = 1; check_10_type = 1;}
            if (rjOK11.Checked.Equals(true)) { check_11_ok = 1; check_11_type = 1;}
            if (rjOK12.Checked.Equals(true)) { check_12_ok = 1; check_12_type = 1;}
            if (rjOK13.Checked.Equals(true)) { check_13_ok = 1; check_13_type = 1;}
            if (rjOK14.Checked.Equals(true)) { check_14_ok = 1; check_14_type = 1;}
            if (rjOK15.Checked.Equals(true)) { check_15_ok = 1; check_15_type = 1;}
            if (rjOK16.Checked.Equals(true)) { check_16_ok = 1; check_16_type = 1;}

            if (rjN_OK1.Checked.Equals(true)) { check_1_nok = 1; check_1_type = 2;}
            if (rjN_OK2.Checked.Equals(true)) { check_2_nok = 1; check_2_type = 2;}
            if (rjN_OK3.Checked.Equals(true)) { check_3_nok = 1; check_3_type = 2;}
            if (rjN_OK4.Checked.Equals(true)) { check_4_nok = 1; check_4_type = 2;}
            if (rjN_OK5.Checked.Equals(true)) { check_5_nok = 1; check_5_type = 2;}
            if (rjN_OK6.Checked.Equals(true)) { check_6_nok = 1; check_6_type = 2;}
            if (rjN_OK7.Checked.Equals(true)) { check_7_nok = 1; check_7_type = 2;}
            if (rjN_OK8.Checked.Equals(true)) { check_8_nok = 1; check_8_type = 2;}
            if (rjN_OK9.Checked.Equals(true)) { check_9_nok = 1; check_9_type = 2;}
            if (rjN_OK10.Checked.Equals(true)) { check_10_nok = 1; check_10_type = 2;}
            if (rjN_OK11.Checked.Equals(true)) { check_11_nok = 1; check_11_type = 2;}
            if (rjN_OK12.Checked.Equals(true)) { check_12_nok = 1; check_12_type = 2;}
            if (rjN_OK13.Checked.Equals(true)) { check_13_nok = 1; check_13_type = 2;}
            if (rjN_OK14.Checked.Equals(true)) { check_14_nok = 1; check_14_type = 2;}
            if (rjN_OK15.Checked.Equals(true)) { check_15_nok = 1; check_15_type = 2;}
            if (rjN_OK16.Checked.Equals(true)) { check_16_nok = 1; check_16_type = 2;}

            if (rjN_A1.Checked.Equals(true)) { check_1_na = 1; check_1_type = 3;}
            if (rjN_A2.Checked.Equals(true)) { check_2_na = 1; check_2_type = 3;}
            if (rjN_A3.Checked.Equals(true)) { check_3_na = 1; check_3_type = 3;}
            if (rjN_A4.Checked.Equals(true)) { check_4_na = 1; check_4_type = 3;}
            if (rjN_A5.Checked.Equals(true)) { check_5_na = 1; check_5_type = 3;}
            if (rjN_A6.Checked.Equals(true)) { check_6_na = 1; check_6_type = 3;}
            if (rjN_A7.Checked.Equals(true)) { check_7_na = 1; check_7_type = 3;}
            if (rjN_A8.Checked.Equals(true)) { check_8_na = 1; check_8_type = 3;}
            if (rjN_A9.Checked.Equals(true)) { check_9_na = 1; check_9_type = 3;}
            if (rjN_A10.Checked.Equals(true)) { check_10_na = 1; check_10_type = 3;}
            if (rjN_A11.Checked.Equals(true)) { check_11_na = 1; check_11_type = 3;}
            if (rjN_A12.Checked.Equals(true)) { check_12_na = 1; check_12_type = 3;}
            if (rjN_A13.Checked.Equals(true)) { check_13_na = 1; check_13_type = 3;}
            if (rjN_A14.Checked.Equals(true)) { check_14_na = 1; check_14_type = 3;}
            if (rjN_A15.Checked.Equals(true)) { check_15_na = 1; check_15_type = 3;}
            if (rjN_A16.Checked.Equals(true)) { check_16_na = 1; check_16_type = 3;}

            if (rjCheckBox1.Checked.Equals(true)) pallet_1 = 1;
            if (rjCheckBox2.Checked.Equals(true)) pallet_2 = 1;
            if (rjCheckBox3.Checked.Equals(true)) pallet_3 = 1;
            if (rjCheckBox4.Checked.Equals(true)) pallet_4 = 1;
            if (rjCheckBox5.Checked.Equals(true)) pallet_5 = 1;
            if (rjCheckBox6.Checked.Equals(true)) pallet_6 = 1;
            if (rjCheckBox7.Checked.Equals(true)) pallet_7 = 1;
            if (rjCheckBox8.Checked.Equals(true)) pallet_8 = 1;
            if (rjCheckBox9.Checked.Equals(true)) pallet_9 = 1;
            if (rjCheckBox10.Checked.Equals(true)) pallet_10 = 1;
            if (rjCheckBox11.Checked.Equals(true)) pallet_11 = 1;
            if (rjCheckBox12.Checked.Equals(true)) pallet_12 = 1;
            if (rjCheckBox13.Checked.Equals(true)) pallet_13 = 1;
            if (rjCheckBox14.Checked.Equals(true)) pallet_14 = 1;
            if (rjCheckBox15.Checked.Equals(true)) pallet_15 = 1;
            if (rjCheckBox16.Checked.Equals(true)) pallet_16 = 1;
            if (rjCheckBox17.Checked.Equals(true)) pallet_17 = 1;
            if (rjCheckBox18.Checked.Equals(true)) pallet_18 = 1;
            if (rjCheckBox19.Checked.Equals(true)) pallet_19 = 1;
            if (rjCheckBox20.Checked.Equals(true)) pallet_20 = 1;
            if (rjCheckBox21.Checked.Equals(true)) pallet_21 = 1;
            if (rjCheckBox22.Checked.Equals(true)) pallet_22 = 1;
            if (rjCheckBox23.Checked.Equals(true)) pallet_23 = 1;
            if (rjCheckBox24.Checked.Equals(true)) pallet_24 = 1;
            if (rjCheckBox25.Checked.Equals(true)) pallet_25 = 1;
            if (rjCheckBox26.Checked.Equals(true)) pallet_26 = 1;
            if (rjCheckBox27.Checked.Equals(true)) pallet_27 = 1;
            if (rjCheckBox28.Checked.Equals(true)) pallet_28 = 1;
            if (rjCheckBox29.Checked.Equals(true)) pallet_29 = 1;
            if (rjCheckBox30.Checked.Equals(true)) pallet_30 = 1;
            if (rjCheckBox31.Checked.Equals(true)) pallet_31 = 1;
            if (rjCheckBox32.Checked.Equals(true)) pallet_32 = 1;

            qtd_inspecionadas = pallet_1 + pallet_2 + pallet_3 + pallet_4 + pallet_5 + pallet_6 + pallet_7 + pallet_8 + pallet_9 + pallet_10 + pallet_11 + pallet_12 + pallet_13 + pallet_14 + pallet_15 + pallet_16 + pallet_17 + pallet_18 + 
                
            pallet_19 + pallet_20 + pallet_21 + pallet_22 + pallet_23 + pallet_24 + pallet_25 + pallet_26 + pallet_27 + pallet_28 + pallet_29 + pallet_30 + pallet_31 + pallet_32;

            quant_total_ok = check_1_ok + check_2_ok + check_3_ok + check_4_ok + check_5_ok + check_6_ok + check_7_ok + check_8_ok + check_9_ok + check_10_ok + check_11_ok + check_12_ok + check_13_ok + check_14_ok + check_15_ok + check_16_ok;
            // soma de quantidade total "nok"
            quant_total_nok = check_1_nok + check_2_nok + check_3_nok + check_4_nok + check_5_nok + check_6_nok + check_7_nok + check_8_nok + check_9_nok + check_10_nok + check_11_nok + check_12_nok + check_13_nok + check_14_nok + check_15_nok + check_16_nok;
            //soma de quantidade total "n/a"
            quant_total_na = check_1_na + check_2_na + check_3_na + check_4_na + check_5_na + check_6_na + check_7_na + check_8_na + check_9_na + check_10_na + check_11_na + check_12_na + check_13_na + check_14_na + check_15_na + check_16_na;
 
            lblTok.Text = quant_total_ok.ToString();
            lblN_OK.Text = quant_total_nok.ToString();
            lblNa.Text = quant_total_na.ToString();

        }
        private void DateServer()
        {
            SqlConnection con = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("SELECT GETDATE()", con);

            con.Open();
            DATET = Convert.ToDateTime(comande.ExecuteScalar());
            con.Close();
        }
        private void InsertV1()
        {
            LoadTurno();
            CheckValues();
            DateServer();

            

                //DA O INSERT DO NOVO CKD
                SqlConnection conecta1 = new SqlConnection(Conexao.ROTA);
                SqlCommand comande1 = new SqlCommand(@"
            
INSERT INTO [ROTA].[dbo].[CHECK_LIST_Q]
           ([responsavel_q]
           ,[codigo]
           ,[data]
           ,[op]
           ,[quantidade]
           ,[linha]
           ,[turno]
           ,[sn]
           ,[ean]
           ,[pl]
           ,[pb]
           ,[checkliste_1]
           ,[checkliste_2]
           ,[checkliste_3]
           ,[checkliste_4]
           ,[checkliste_5]
           ,[checkliste_6]
           ,[checkliste_7]
           ,[checkliste_8]
           ,[checkliste_9]
           ,[checkliste_10]
           ,[checkliste_11]
           ,[checkliste_12]
           ,[checkliste_13]
           ,[checkliste_14]
           ,[checkliste_15]
           ,[checkliste_16]
           ,[ok]
           ,[nok]
           ,[n_a]
           ,[obs1]
           ,[operador2]
           ,[lider]
           ,[quant_pallet]
           ,[quant_peca_pallet]
           ,[lote]
           ,[vencimento]
           ,[operador]
           ,[hora])
            VALUES
           ( @responsavel_q
           , @codigo
           , @data
           , @op
           , @quantidade
           , @linha
           , @turno 
           , @sn 
           , @ean 
           , @pl 
           , @pb 
           , @checkliste_1 
           , @checkliste_2 
           , @checkliste_3 
           , @checkliste_4 
           , @checkliste_5 
           , @checkliste_6 
           , @checkliste_7 
           , @checkliste_8 
           , @checkliste_9 
           , @checkliste_10 
           , @checkliste_11 
           , @checkliste_12 
           , @checkliste_13 
           , @checkliste_14 
           , @checkliste_15 
           , @checkliste_16 
           , @ok 
           , @nok 
           , @n_a 
           , @obs1 
           , @Operador
           , @Lider
           ,@Nqa
           ,@Inspec
           ,@lote
           ,@vencimento
           ,@operadorLote
           ,@hora
          )
            
            ", conecta1);

                comande1.Parameters.Add("@responsavel_q", SqlDbType.VarChar).Value = rjMatricula.Text;
                comande1.Parameters.Add("@codigo", SqlDbType.VarChar).Value = CodPa;
                comande1.Parameters.Add("@data", SqlDbType.Date).Value = DATET;
                comande1.Parameters.Add("@op", SqlDbType.VarChar).Value = cbOp.Text;
                comande1.Parameters.Add("@quantidade", SqlDbType.VarChar).Value = txtQtd.Text;
                comande1.Parameters.Add("@linha", SqlDbType.VarChar).Value = CbLinha.Text;
                comande1.Parameters.Add("@turno", SqlDbType.VarChar).Value = check_turno;
                comande1.Parameters.Add("@sn", SqlDbType.VarChar).Value = lblSn.Text;
                comande1.Parameters.Add("@ean", SqlDbType.VarChar).Value = lblEan.Text;
                comande1.Parameters.Add("@pl", SqlDbType.Float).Value = lblPl.Text;
                comande1.Parameters.Add("@pb", SqlDbType.Float).Value = lblPb.Text;
                comande1.Parameters.Add("@checkliste_1", SqlDbType.VarChar).Value = check_1_type;
                comande1.Parameters.Add("@checkliste_2", SqlDbType.VarChar).Value = check_2_type;
                comande1.Parameters.Add("@checkliste_3", SqlDbType.VarChar).Value = check_3_type;
                comande1.Parameters.Add("@checkliste_4", SqlDbType.VarChar).Value = check_4_type;
                comande1.Parameters.Add("@checkliste_5", SqlDbType.VarChar).Value = check_5_type;
                comande1.Parameters.Add("@checkliste_6", SqlDbType.VarChar).Value = check_6_type;
                comande1.Parameters.Add("@checkliste_7", SqlDbType.VarChar).Value = check_7_type;
                comande1.Parameters.Add("@checkliste_8", SqlDbType.VarChar).Value = check_8_type;
                comande1.Parameters.Add("@checkliste_9", SqlDbType.VarChar).Value = check_9_type;
                comande1.Parameters.Add("@checkliste_10", SqlDbType.VarChar).Value = check_10_type;
                comande1.Parameters.Add("@checkliste_11", SqlDbType.VarChar).Value = check_11_type;
                comande1.Parameters.Add("@checkliste_12", SqlDbType.VarChar).Value = check_12_type;
                comande1.Parameters.Add("@checkliste_13", SqlDbType.VarChar).Value = check_13_type;
                comande1.Parameters.Add("@checkliste_14", SqlDbType.VarChar).Value = check_14_type;
                comande1.Parameters.Add("@checkliste_15", SqlDbType.VarChar).Value = check_15_type;
                comande1.Parameters.Add("@checkliste_16", SqlDbType.VarChar).Value = check_16_type;
                comande1.Parameters.Add("@ok", SqlDbType.VarChar).Value = lblTok.Text;
                comande1.Parameters.Add("@nok", SqlDbType.VarChar).Value = lblN_OK.Text;
                comande1.Parameters.Add("@n_a", SqlDbType.VarChar).Value = lblNa.Text;
                comande1.Parameters.Add("@obs1 ", SqlDbType.VarChar).Value = txtObs.Text;
                comande1.Parameters.Add("@Operador ", SqlDbType.VarChar).Value = txtOpProd.Text;
                comande1.Parameters.Add("@Lider ", SqlDbType.VarChar).Value = txtLprod.Text;
                comande1.Parameters.Add("@Nqa ", SqlDbType.VarChar).Value = NQAtotal;
                comande1.Parameters.Add("@Inspec ", SqlDbType.VarChar).Value = qtd_inspecionadas;
            comande1.Parameters.Add("@lote ", SqlDbType.VarChar).Value = TxtLote.Text;
            comande1.Parameters.Add("@vencimento ", SqlDbType.Date).Value = dthDataVenc.Text;
            comande1.Parameters.Add("@operadorLote ", SqlDbType.VarChar).Value = txtPastaOperador.Text;
            comande1.Parameters.Add("@hora ", SqlDbType.VarChar).Value = txtHoraVenc.Text;

            conecta1.Open();
                comande1.ExecuteReader();
                conecta1.Close();
                ClearAll();
            }
        
    }
}
