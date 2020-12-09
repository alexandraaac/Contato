using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatosBDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contatosBDDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.contatosBDDataSet.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'contatosBDDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.contatosBDDataSet.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'contatosBDDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.contatosBDDataSet.Pessoa);

        }

        private void pessoaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
