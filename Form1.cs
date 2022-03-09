using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercanetCurrency
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();

            txt_codigo.Enabled = false;
            txt_descricao.Enabled = false;
            txt_abreviatura.Enabled = false;
            txt_cotacao.Enabled = false;

            txt_codigo.Clear();
            txt_descricao.Clear();
            txt_abreviatura.Clear();
            txt_cotacao.Clear();
        }        

        SqlConnection sqlconn = null;
        private readonly string stgCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MERCANET_DB;Data Source=(localdb)\MSSQLLocalDB";
        private string stgSql = string.Empty;

        private void Novo_Click(object sender, EventArgs e)
        {
            txt_codigo.Enabled = true;
            txt_descricao.Enabled = true;
            txt_abreviatura.Enabled = true;
            txt_cotacao.Enabled = true;

            txt_codigo.Clear();
            txt_descricao.Clear();
            txt_abreviatura.Clear();
            txt_cotacao.Clear();
        }

        public class AutoClosingMessageBox
        {
            readonly System.Threading.Timer timeoutTimer;
            readonly string caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                this.caption = caption;
                timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }



        private void Salvar_Click(object sender, EventArgs e)
        {
            

            stgSql = "insert into cadastro (codigo, descricao, abreviatura, cotacao) values ('" + txt_codigo.Text + "', '" + txt_descricao.Text + "', '" + txt_abreviatura.Text + "', '" + txt_cotacao.Text + "')";
            sqlconn = new SqlConnection(stgCon);

            SqlCommand comando = new SqlCommand(stgSql, sqlconn);

            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = stgSql;
            comando.Parameters.Add("@descricao", SqlDbType.VarChar).Value = stgSql;
            comando.Parameters.Add("@abreviatura", SqlDbType.VarChar).Value = stgSql;
            comando.Parameters.Add("@cotacao", SqlDbType.VarChar).Value = stgSql;

            if(txt_codigo.Text == String.Empty)
            {
                MessageBox.Show("PREENCHA O CAMPO 'Código'.");
                return;
            } else if(txt_descricao.Text == String.Empty)
            {
                MessageBox.Show("PREENCHA O CAMPO 'Descrição'.");
                return;
            }

            try
            {
                sqlconn.Open();
                comando.ExecuteNonQuery();                
                Form1.AutoClosingMessageBox.Show("MOEDA SALVA COM SUCESSO!", "", 4000);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlconn.Close();
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            stgSql = "delete from Cadastro where codigo=" + txt_codigo.Text;
            sqlconn = new SqlConnection(stgCon);
            SqlCommand comando = new SqlCommand(stgSql, sqlconn);

            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = stgSql;

            try
            {
                sqlconn.Open();
                comando.ExecuteNonQuery();
                AutoClosingMessageBox.Show("MOEDA EXCLUÍDA COM SUCESSO!", "", 4000);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlconn.Close();
            }

            txt_codigo.Enabled = true;
            txt_descricao.Enabled = true;
            txt_abreviatura.Enabled = true;
            txt_cotacao.Enabled = true;

            txt_codigo.Clear();
            txt_descricao.Clear();
            txt_abreviatura.Clear();
            txt_cotacao.Clear();
        }
    }
}