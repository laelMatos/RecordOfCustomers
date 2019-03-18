using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer.Infra;
using Customer.Service;


namespace Customer.Window.UI
{
    public partial class Form1 : Form
    {
        private int Id = 0;
        private bool busca = true;
        private CustomerService _Db;
        private Customer _Customer;

        public Form1()
        {
            
            try
            {
                _Db = new CustomerService();
                InitializeComponent();

                Txt_Search.KeyUp += Txt_Search_KeyUp;//Search

                Btn_Salvar.Click += Btn_Salvar_Click;//Save
                Btn_Novo.Click += Btn_Novo_Click;//New
                Btn_Buscar.Click += Btn_Buscar_Click;//Search
                Btn_Atualizar.Click += Btn_Atualizar_Click;//update
                Btn_Deletar.Click += Btn_Deletar_Click;//Delete

                rbt_Nome.CheckedChanged += rbt_Nome_CheckedChanged;
                rbt_CPF.CheckedChanged += rbt_CPF_CheckedChanged;

                dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;

                Btn_Atualizar.Enabled = false;
                Btn_Deletar.Enabled = false;
                Btn_Salvar.Enabled = false;
                pnl_Dados_Clientes.Enabled = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        //
        //ChecBox Nome
        private void rbt_Nome_CheckedChanged(object sender, EventArgs e)
        {
            this.busca = true;
        }
        //
        //ChecBox CPF
        private void rbt_CPF_CheckedChanged(object sender, EventArgs e)
        {
            this.busca = false;
        }
        //Delete
        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            DialogResult MsgDel = MessageBox.Show("Tem certeza que deseja DELETAR?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MsgDel == DialogResult.Yes)
            {
                try
                {
                    this.Btn_Atualizar.Enabled = false;
                    this.Btn_Deletar.Enabled = false;
                    this.Btn_Salvar.Enabled = false;
                    _Db.Delete(InsertAllValues());
                    MessageBox.Show("Deletado com sucesso.");
                    ViewIn_DataGrid();
                    ClearTXT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Deletar cancelado."); }

        }
        //Update
        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult MsgAtua = MessageBox.Show("Tem certeza que deseja ALTERAR?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (MsgAtua == DialogResult.Yes)
                {
                    _Db.Update(InsertAllValues());
                    this.Btn_Atualizar.Enabled = false;
                    this.Btn_Deletar.Enabled = false;
                    this.pnl_Dados_Clientes.Enabled = false;
                    MessageBox.Show("Alterado com sucesso");
                    ViewIn_DataGrid();
                    ClearTXT();                   
                }
                else { MessageBox.Show("Atualização cancelada."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Alterar:", ex.Message);
            }
        }
        //
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Btn_Atualizar.Enabled = true;
            this.Btn_Deletar.Enabled = true;
            this.Btn_Salvar.Enabled = false;
            this.pnl_Dados_Clientes.Enabled = true;
            this.pnl_Search.Enabled = false;

            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            GetAllValues(_Db.GetCustomerByID(Id));
        }
        //Search
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Btn_Atualizar.Enabled = false;
            Btn_Deletar.Enabled = false;
            pnl_Search.Enabled = true;
            ClearTXT();

            if (pnl_Dados_Clientes.Enabled)
            {
                pnl_Dados_Clientes.Enabled = false;
            }
            if (Btn_Salvar.Enabled)
            {
                Btn_Salvar.Enabled = false;
            }
        }
        //New
        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Btn_Atualizar.Enabled = false;
            Btn_Deletar.Enabled = false;
            Btn_Salvar.Enabled = true;
            pnl_Dados_Clientes.Enabled = true;

            ViewIn_DataGrid();
            ClearTXT();

            if (pnl_Search.Enabled)
            {
                pnl_Search.Enabled = false;
            }
        }
        //Save
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                _Db.Add(InsertAllValues());
                ViewIn_DataGrid();
                ClearTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }             
        }
        //
        private void ViewIn_DataGrid()
        {
            this.dataGridView1.DataSource = _Db.GetCustomers();
            dataGridView1.Columns[0].Visible = false;//Hide ID in DataGridView
            //Not edit columns DataGridView---
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
        }
        //
        //Search Txt
        private void Txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            IEnumerable<Customer> listar;
            if (busca)
            {//Busca em tempo real para Nome, ao digitar no Txt_Search.
                listar = _Db.GetCustomers().Where(x => x.Name.Contains(Txt_Search.Text));
                lb_AuantityFound.Text = "Encontrado: " + listar.Count();
                dataGridView1.DataSource = listar.ToList();

            } else
            {//Busca em tempo real para CPF, ao digitar no Txt_Search.
                listar = _Db.GetCustomers().Where(x => x.Cpf.Contains(Txt_Search.Text));
                lb_AuantityFound.Text = "Encontrado: " + listar.Count();
                dataGridView1.DataSource = listar.ToList();
            }
        }
        //
        //Controllers
        private void ClearTXT()
        {
            Txt_Nome.Clear();
            Txt_Email.Clear();
            txt_Cpf.Clear();
            txt_Cel.Clear();
            chk_WhatsApp.Checked = false;
            txt_Telefone.Clear();
            txt_Ramal.Clear();
            txt_Endereco.Clear();
            txt_Numero.Clear();
            txt_Bairro.Clear();
            lb_AuantityFound.Text = "-";
        }
        //Insert All Values in customer
        private Customer InsertAllValues()
        {
                _Customer = new Customer(Txt_Nome.Text)
                {
                    Id = this.Id,
                    Email = Txt_Email.Text,
                    Cpf = txt_Cpf.Text.Replace(".","").Replace("-","").Replace(",","").Replace(" ",""),
                    Cel = txt_Cel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                    Whats = chk_WhatsApp.Checked,
                    Tel = txt_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                    Ramal = txt_Ramal.Text,
                    Endereco = txt_Endereco.Text,
                    Numero = txt_Numero.Text,
                    Bairro = txt_Bairro.Text,
            };
            return _Customer;
        }
        //
        private void GetAllValues(Customer customer)
        {
            Txt_Nome.Text = customer.Name;
            Txt_Email.Text = customer.Email;
            txt_Cpf.Text = customer.Cpf;
            txt_Cel.Text = customer.Cel;
            chk_WhatsApp.Checked = customer.Whats;
            txt_Telefone.Text = customer.Tel;
            txt_Ramal.Text = customer.Ramal;
            txt_Endereco.Text = customer.Endereco;
            txt_Numero.Text = customer.Numero;
            txt_Bairro.Text = customer.Bairro;
        }
    }
}
