using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int nilaiKali=10;
        int hasilNilaiKali = 0;
        int cetakText = 0;
        int angkaGanjil = 0;

        List<string> listNilai = new List<string>();
        
       
        public Form1()
        {

            InitializeComponent();
            
        }

        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            listNilai.Clear();

            var angka = txtAngka.Text.Select(t => int.Parse(t.ToString())).ToArray();
            string txtHasilNilai = string.Empty.ToString();
            string txtHasilNilaiFinal = string.Empty.ToString();

            foreach(var angka1 in angka)
            {
                string angkaFinal = angka1.ToString();
                

                if(angka1 > 0 )
                {
                    hasilNilaiKali = angka1 * nilaiKali;
                    txtHasilNilai = hasilNilaiKali.ToString();
                    txtHasilNilaiFinal = txtHasilNilai;

                } else
                {
                    hasilNilaiKali = 10 * nilaiKali;
                    txtHasilNilai = hasilNilaiKali.ToString();
                    txtHasilNilaiFinal = txtHasilNilai.Substring(1, txtHasilNilai.Length - 1);
                }

                listNilai.Add(txtHasilNilaiFinal);
                nilaiKali = nilaiKali * 10;
            }

            var text = String.Join(Environment.NewLine, listNilai);


            lblHasil.Text = text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listNilai.Clear();
            var angka = txtAngka.Text.Select(t => int.Parse(t.ToString())).ToArray();
            foreach (var angka1 in angka)
            {
                int angkaFinal = angka1;
                int angkaFinalAkhir = 0;
               


               if(angkaFinal % 2 != 0)
               {
                    angkaFinalAkhir = angkaFinal;
               }

                listNilai.Add(angkaFinalAkhir.ToString());
            }

            string listString = string.Join(",", listNilai).Replace(",0","");

            lblHasil.Text = listString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var angka = txtAngka.Text.Select(t => int.Parse(t.ToString())).ToArray();
            foreach (var angka1 in angka)
            {
                string angkaFinal = angka1.ToString();


            }
        }
    }
}
