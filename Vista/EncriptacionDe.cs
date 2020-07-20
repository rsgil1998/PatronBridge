using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Encriptacion;
using Vista.Mensaje;

namespace Vista
{
    public partial class EncriptacionDe : Form
    {
        public EncriptacionDe()
        {
            InitializeComponent();
        }

        private DefaultMessageEncrypt Encriptador;

        private void EncriptacionDe_Load(object sender, EventArgs e)
        {
            this.Encriptador = new DefaultMessageEncrypt();
        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            if (txt_msg.TextLength == 0 && txt_psw.TextLength == 0)
            {
                //mesnaje de error validando campos vacios
                MessageBox.Show("Verifica que no dejes campos vacíos sin llenar en el la sección de Detalles", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //primero muestro la encriptacion con NO como deffault
                txt_NA.Text = Encriptador.encryptMessage(txt_msg.Text, txt_psw.Text);
                //mediante el constructor modifico el atributo de la clase abstracta para poder encriptar con DES
                Encriptador = new DefaultMessageEncrypt(new DESEncryptAlgorithm());
                txt_DES.Text = Encriptador.encryptMessage(txt_msg.Text, txt_psw.Text);
                //mediante el constructor modifico el atributo de la clase abstracta para poder encriptar con AES
                Encriptador = new DefaultMessageEncrypt(new AESEncryptAlgorithm());
                txt_AES.Text = Encriptador.encryptMessage(txt_msg.Text, txt_psw.Text);
            }
        }
    }
}
