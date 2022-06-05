using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Models;
using CRUD.Models.Presentacion;


namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            using (Programacion1Entities db = new Programacion1Entities())
            {
                var lst = from d in db.Musica
                          select d;
                dataGridView1.DataSource = lst.ToList();

            }
        }

        private int? Getid()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;    
            }
        }


        private void buttonNueva_Click(object sender, EventArgs e)
        {
            
            FrmTabla oFrmTabla = new FrmTabla();
            oFrmTabla.Visible = true;
            Refrescar();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int? id = Getid();
            if (id != null)
            {
                FrmTabla frmTabla = new FrmTabla(id);
                frmTabla.Visible = true;

                Refrescar();

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int? id = Getid();
            if(id!= null)
            {
                using (Programacion1Entities db = new Programacion1Entities())
                {
                   Musica Otabla = db.Musica.Find(id);
                    db.Musica.Remove(Otabla);
                    db.SaveChanges();
                }
                Refrescar();
            }
           

        }
    }
}
