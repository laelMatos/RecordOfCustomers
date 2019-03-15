namespace Customer.Window.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.rbt_CPF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.rbt_Nome = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.pnl_Dados_Clientes = new System.Windows.Forms.Panel();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ramal = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_WhatsApp = new System.Windows.Forms.CheckBox();
            this.txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_AuantityFound = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_Dados_Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1034, 385);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 379);
            this.dataGridView1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.09091F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Dados_Clientes, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 176);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_Search);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btn_Novo);
            this.panel2.Controls.Add(this.Btn_Salvar);
            this.panel2.Controls.Add(this.Btn_Atualizar);
            this.panel2.Controls.Add(this.Btn_Deletar);
            this.panel2.Controls.Add(this.Btn_Buscar);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 170);
            this.panel2.TabIndex = 0;
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.rbt_CPF);
            this.pnl_Search.Controls.Add(this.lb_AuantityFound);
            this.pnl_Search.Controls.Add(this.label2);
            this.pnl_Search.Controls.Add(this.Txt_Search);
            this.pnl_Search.Controls.Add(this.rbt_Nome);
            this.pnl_Search.Location = new System.Drawing.Point(9, 63);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(402, 62);
            this.pnl_Search.TabIndex = 37;
            // 
            // rbt_CPF
            // 
            this.rbt_CPF.AutoSize = true;
            this.rbt_CPF.Location = new System.Drawing.Point(351, 33);
            this.rbt_CPF.Name = "rbt_CPF";
            this.rbt_CPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbt_CPF.Size = new System.Drawing.Size(45, 17);
            this.rbt_CPF.TabIndex = 13;
            this.rbt_CPF.Text = "CPF";
            this.rbt_CPF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Escreva o que quer buscar.";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Search.Location = new System.Drawing.Point(6, 3);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(390, 21);
            this.Txt_Search.TabIndex = 11;
            // 
            // rbt_Nome
            // 
            this.rbt_Nome.AutoSize = true;
            this.rbt_Nome.BackColor = System.Drawing.SystemColors.Control;
            this.rbt_Nome.Checked = true;
            this.rbt_Nome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbt_Nome.Location = new System.Drawing.Point(292, 33);
            this.rbt_Nome.Name = "rbt_Nome";
            this.rbt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbt_Nome.Size = new System.Drawing.Size(53, 17);
            this.rbt_Nome.TabIndex = 12;
            this.rbt_Nome.TabStop = true;
            this.rbt_Nome.Text = "Nome";
            this.rbt_Nome.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(8, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 41);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Click duas vezes para: Atualizar/Deletar";
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Location = new System.Drawing.Point(4, 3);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 40);
            this.Btn_Novo.TabIndex = 15;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(168, 3);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 40);
            this.Btn_Salvar.TabIndex = 17;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(249, 3);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(75, 40);
            this.Btn_Atualizar.TabIndex = 18;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.Location = new System.Drawing.Point(330, 3);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(75, 40);
            this.Btn_Deletar.TabIndex = 19;
            this.Btn_Deletar.Text = "Deletar";
            this.Btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(87, 3);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 40);
            this.Btn_Buscar.TabIndex = 16;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // pnl_Dados_Clientes
            // 
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Bairro);
            this.pnl_Dados_Clientes.Controls.Add(this.label3);
            this.pnl_Dados_Clientes.Controls.Add(this.label9);
            this.pnl_Dados_Clientes.Controls.Add(this.label4);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Ramal);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Numero);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Telefone);
            this.pnl_Dados_Clientes.Controls.Add(this.label8);
            this.pnl_Dados_Clientes.Controls.Add(this.Txt_Email);
            this.pnl_Dados_Clientes.Controls.Add(this.label5);
            this.pnl_Dados_Clientes.Controls.Add(this.Txt_Nome);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Cel);
            this.pnl_Dados_Clientes.Controls.Add(this.label7);
            this.pnl_Dados_Clientes.Controls.Add(this.chk_WhatsApp);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Cpf);
            this.pnl_Dados_Clientes.Controls.Add(this.label6);
            this.pnl_Dados_Clientes.Controls.Add(this.label10);
            this.pnl_Dados_Clientes.Controls.Add(this.txt_Endereco);
            this.pnl_Dados_Clientes.Controls.Add(this.label11);
            this.pnl_Dados_Clientes.Location = new System.Drawing.Point(425, 3);
            this.pnl_Dados_Clientes.Name = "pnl_Dados_Clientes";
            this.pnl_Dados_Clientes.Size = new System.Drawing.Size(603, 163);
            this.pnl_Dados_Clientes.TabIndex = 36;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(219, 131);
            this.txt_Bairro.MaxLength = 120;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(374, 21);
            this.txt_Bairro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(166, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // txt_Ramal
            // 
            this.txt_Ramal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ramal.Location = new System.Drawing.Point(547, 56);
            this.txt_Ramal.MaxLength = 6;
            this.txt_Ramal.Name = "txt_Ramal";
            this.txt_Ramal.Size = new System.Drawing.Size(46, 21);
            this.txt_Ramal.TabIndex = 7;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(86, 131);
            this.txt_Numero.MaxLength = 6;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(66, 21);
            this.txt_Numero.TabIndex = 9;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(368, 56);
            this.txt_Telefone.Mask = "(99) 0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(121, 21);
            this.txt_Telefone.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nº:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(86, 30);
            this.Txt_Email.MaxLength = 120;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(234, 20);
            this.Txt_Email.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Celular:";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(86, 3);
            this.Txt_Nome.MaxLength = 140;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(507, 20);
            this.Txt_Nome.TabIndex = 1;
            // 
            // txt_Cel
            // 
            this.txt_Cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cel.Location = new System.Drawing.Point(86, 56);
            this.txt_Cel.Mask = "(99) 00000-0000";
            this.txt_Cel.Name = "txt_Cel";
            this.txt_Cel.Size = new System.Drawing.Size(121, 21);
            this.txt_Cel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ramal:";
            // 
            // chk_WhatsApp
            // 
            this.chk_WhatsApp.AutoSize = true;
            this.chk_WhatsApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chk_WhatsApp.Location = new System.Drawing.Point(213, 58);
            this.chk_WhatsApp.Name = "chk_WhatsApp";
            this.chk_WhatsApp.Size = new System.Drawing.Size(78, 17);
            this.chk_WhatsApp.TabIndex = 5;
            this.chk_WhatsApp.Text = "Whats app";
            this.chk_WhatsApp.UseVisualStyleBackColor = true;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cpf.Location = new System.Drawing.Point(368, 29);
            this.txt_Cpf.Mask = "999.999.999-99";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(225, 21);
            this.txt_Cpf.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "CPF:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(86, 104);
            this.txt_Endereco.MaxLength = 140;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(507, 21);
            this.txt_Endereco.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Endereço:";
            // 
            // lb_AuantityFound
            // 
            this.lb_AuantityFound.AutoSize = true;
            this.lb_AuantityFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AuantityFound.Location = new System.Drawing.Point(156, 27);
            this.lb_AuantityFound.Name = "lb_AuantityFound";
            this.lb_AuantityFound.Size = new System.Drawing.Size(11, 15);
            this.lb_AuantityFound.TabIndex = 40;
            this.lb_AuantityFound.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.pnl_Dados_Clientes.ResumeLayout(false);
            this.pnl_Dados_Clientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.RadioButton rbt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.RadioButton rbt_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Panel pnl_Dados_Clientes;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ramal;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.MaskedTextBox txt_Cel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_WhatsApp;
        private System.Windows.Forms.MaskedTextBox txt_Cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_AuantityFound;
    }
}

