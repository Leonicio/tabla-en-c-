using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Notas
{
    public partial class Form1 : Form
    {
        static int a = 0;
        static int b = 0;
        static int c = 0;
        static int f = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            float nParticipacion = float.Parse(TXTP.Text);
            float nAsistencia = float.Parse(TXTA.Text);
            float nTrabajo = float.Parse(TXTTF.Text);
            float nExamen = float.Parse(TXTEF.Text);
            string resultado = "";

            float nCalificacion = nParticipacion + nAsistencia + nTrabajo + nExamen;
            float nPuntuacion = nCalificacion;

            Color notacolor = Color.Brown;
                        
            if (nPuntuacion >= 90)
            {
                resultado = "A";
                notacolor = Color.Blue;
                                
                a++;

            }
            else if (nCalificacion >= 80)
            {
                resultado = "B";
                notacolor = Color.Green;
                b++;

                
            }
            else if (nCalificacion >= 70)
            {
                resultado = "C";
                notacolor = Color.Lime;
                c++;

            }
            else if (nCalificacion < 70)
            {
                resultado = "F";
                notacolor = Color.Red;
                f++;

            }
                txtCantidadA.Text = a.ToString();
                txtCantidadB.Text = b.ToString();
                txtCantidadC.Text = c.ToString();
                


            dgNotas.Rows.Add(TXTNOMBRE.Text,
                                nParticipacion,
                                nAsistencia,
                                nTrabajo,
                                nExamen,
                                nCalificacion,
                                resultado);

            dgNotas[6, dgNotas.Rows.Count-1].Style.ForeColor = notacolor;

            {
                TXTNOMBRE.Text = "";
                TXTP.Text = "";
                TXTEF.Text = "";
                TXTTF.Text = "";
                TXTA.Text = "";

                TXTNOMBRE.Focus();
                
            }
            

        }

        private void TXTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTP_VisibleChanged(object sender, EventArgs e)
        {
                        
        }

        private void TXTP_Validating(object sender, CancelEventArgs e)
        {
            if (TXTP.Text == "")
            {
                TXTP.Text = "0";
            }
 
            float nTXT = float.Parse(TXTP.Text);


            if (nTXT < 0 | nTXT > 15)
            {
                MessageBox.Show("Este valor debe estar entre 0-15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTP.Focus();
                return;
            }
            else
            {
            }
        }

        private void TXTA_Validating(object sender, CancelEventArgs e)
        {
            if (TXTA.Text == "")
            {
                TXTA.Text = "0";
            }
            float nTXTA = float.Parse(TXTA.Text);


            if (nTXTA < 0 | nTXTA > 15)
            {
                MessageBox.Show("Este valor debe estar entre 0-15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTA.Focus();
                return;
            }
            else
            {
            }
        }

        private void TXTTF_Validating(object sender, CancelEventArgs e)
        {
            if (TXTTF.Text == "")
            {
                TXTTF.Text = "0";
            }
            float nTXTTF = float.Parse(TXTTF.Text);


            if (nTXTTF < 0 | nTXTTF > 20)
            {
                MessageBox.Show("Este valor debe estar entre 0-20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTTF.Focus();
                return;
            }
            else
            {
            }
        }

        private void TXTEF_Validating(object sender, CancelEventArgs e)
        {
            if (TXTEF.Text == "")
            {
                TXTEF.Text = "0";
            }
            float nTXTEF = float.Parse(TXTEF.Text);


            if (nTXTEF < 0 | nTXTEF > 50)
            {
                MessageBox.Show("Este valor debe estar entre 0-50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTEF.Focus();
                return;
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            /*string resultado;

            if (dgNotas.Rows[0].Cells[6].Value = A);
            {
            resultado = "1";
            }
            */
        }

        private void TXTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
        }

        private void TXTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
        }

        private void TXTTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
        }

        private void TXTEF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
        }

        private void dgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

