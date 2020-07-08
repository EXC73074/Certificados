using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace RookieDC
{
    public partial class Certificados_Digitales : Form
    {
        X509Store Certificados = null;
                    
        public Certificados_Digitales()
        {
            InitializeComponent();       
            CargarComboAlmacen();
            Inicializar();

        }

        private void CargarComboAlmacen()
        {
            ddlAlmacen.Items.Clear();
            ddlAlmacen.Items.Add("Seleccione");
            ddlAlmacen.Items.Add("AddressBook");
            ddlAlmacen.Items.Add("AuthRoot");
            ddlAlmacen.Items.Add("CertificateAuthority");
            ddlAlmacen.Items.Add("Disallowed");
            ddlAlmacen.Items.Add("My");
            ddlAlmacen.Items.Add("Root");
            ddlAlmacen.Items.Add("TrustedPeople");
            ddlAlmacen.Items.Add("TrustedPublisher");
        }

        private void Inicializar()
        {
            btnVerInfo.Visible = false;
            rtxtVerInfo.Visible = false;
            btnOcultarInfo.Visible = false;
            ddlAlmacen.SelectedIndex = 0;
        }

        private void btnObtenerCertificados_Click(object sender, EventArgs e)
        {
            if(ddlAlmacen.SelectedIndex == 0 )
            {
                DialogResult = MessageBox.Show("Debe seleccionar un Almacen","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                if(DialogResult == DialogResult.OK)
                {
                    return;
                }
            }
            
            Certificados = new X509Store(ddlAlmacen.SelectedItem.ToString());
            lstCertificadosInstalados.Items.Clear();
            Certificados.Open(OpenFlags.ReadOnly);

            lstCertificadosInstalados.HorizontalScrollbar = true;
            foreach(X509Certificate2 Certificado in Certificados.Certificates)
            {
                lstCertificadosInstalados.Items.Add(Certificado.FriendlyName);
            }

            btnVerInfo.Visible = true; 
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            rtxtVerInfo.Visible = true;
            btnOcultarInfo.Visible = true;
            rtxtVerInfo.ScrollBars = RichTextBoxScrollBars.Horizontal;
            rtxtVerInfo.ScrollBars = RichTextBoxScrollBars.Vertical;

            string certificadoSeleccionado = lstCertificadosInstalados.SelectedItem.ToString();

            foreach(X509Certificate2 Certificado in Certificados.Certificates)
            {
                if(certificadoSeleccionado == Certificado.FriendlyName)
                {
                    rtxtVerInfo.Text = Certificado.ToString();
                }
            }


        }

        private void btnOcultarInfo_Click(object sender, EventArgs e)
        {
            rtxtVerInfo.Visible = false;
            btnOcultarInfo.Visible = false;
        }


    }
}
