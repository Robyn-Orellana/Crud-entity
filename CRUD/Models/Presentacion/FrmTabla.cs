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

namespace CRUD.Models.Presentacion
{
    public partial class FrmTabla : Form
    {
        public int? id;
        Musica oTabla = null;
        public FrmTabla(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            using (Programacion1Entities db = new Programacion1Entities())
            {
                oTabla = db.Musica.Find(id);
                textBoxNombre.Text = oTabla.Nombre;
                textBoxArtista.Text = oTabla.Artista;
                dateTimePickerlanzamiento.Value = ((DateTime)oTabla.Lanzamiento);
                textBoxAlbum.Text = oTabla.Album;
                textBoxDuracion.Text = Convert.ToString(oTabla.Duracion);

            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (Programacion1Entities db = new Programacion1Entities())
            {
                Musica musica = new Musica();

                if (id == null)
                {
                
                    musica.Nombre = textBoxNombre.Text;
                    musica.Artista = textBoxArtista.Text;
                    musica.Lanzamiento = dateTimePickerlanzamiento.Value;
                    musica.Album = textBoxAlbum.Text;
                    musica.Duracion = float.Parse(textBoxDuracion.Text);
                    Math.Round(musica.Duracion, 2);
               

                    db.Musica.Add(musica);
                }
                else
                {
                    db.Entry(musica).State = System.Data.Entity.EntityState.Modified;     
                }

                db.SaveChanges();
               
                this.Close();


            }

        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
