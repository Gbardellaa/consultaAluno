using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consultaAluno.Relatorios
{
    public partial class frmRelAlunos: Form
    {
        public frmRelAlunos()
        {
            InitializeComponent();
        }

        private void frmRelAlunos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
