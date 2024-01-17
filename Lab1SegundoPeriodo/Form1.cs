using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1SegundoPeriodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TextBox[] arreglo;
        Label la1 = new Label();
        Label la2 = new Label();
        Label la3 = new Label();
        Label la4 = new Label();
        Label la5 = new Label();

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numero1 = 0, potencia = 1;
                int mayor = 0, comparacion = 0, menor = 0, sumatoria = 0, ultimo = 0, penultimo = 0;
                numero1 = Convert.ToInt32(Txt_numero.Text);
                string nombre = " ";
                if (numero1 < 0)
                {
                    MessageBox.Show("El número ingresado es negativo", "Aviso");
                    this.Close();
                }

                int x = 20, y = 120;
                arreglo = new TextBox[numero1];
                for(int i = 0; i < arreglo.Length; i++)
                {
                    x += 30;
                    nombre = "texto" + i;
                    arreglo[i] = new TextBox();
                    arreglo[i].Name = nombre;
                    arreglo[i].Height = 10;
                    arreglo[i].Width = 20;
                    arreglo[i].Location = new Point(x, y);
                    this.Controls.Add(arreglo[i]);

                }

                int contador = 1;
                for (int j = 0; j < arreglo.Length; j++)
                {
                    arreglo[j].Text = contador.ToString();
                    contador++;
                }

                int multi = 1;
                for (int h = 0; h < arreglo.Length; h++)
                {
                    multi = multi * Convert.ToInt32(arreglo[h].Text);
                    sumatoria = sumatoria + Convert.ToInt32(arreglo[h].Text);
                    ultimo = Convert.ToInt32(arreglo[arreglo.Length - 1].Text);
                    penultimo = Convert.ToInt32(arreglo[arreglo.Length - 2].Text);
                }

                
                for (int g = 0;g  < arreglo.Length; g++)
                {
                    comparacion = Convert.ToInt32(arreglo[g].Text);
                    menor = Convert.ToInt32(arreglo[0].Text);
                    if (comparacion > mayor)
                    {
                        mayor = comparacion;
                    }else if (comparacion < menor)
                    {
                        menor = comparacion;
                    }


                }

                for(int d = 1; d <= penultimo; d++)
                {
                    if (d == 1)
                    {
                        potencia = potencia * ultimo;
                    } else
                    {
                        potencia = potencia * ultimo;
                    }
                   

                }







              
                la1.Width = 200;
                la1.Height = 20;
                la1.Location = new Point(x/2, y+50);
                la1.Text = "El resultado es "+multi.ToString();
                this.Controls.Add(la1);

                
                la2.Width = 200;
                la2.Height = 20;
                la2.Location = new Point(x / 2, y + 75);
                la2.Text = "El mayor es " + mayor.ToString();
                this.Controls.Add(la2);


            
                la3.Width = 200;
                la3.Height = 20;
                la3.Location = new Point(x / 2, y + 100);
                la3.Text = "El menor es " + menor.ToString();
                this.Controls.Add(la3);

            
                la4.Width = 200;
                la4.Height = 20;
                la4.Location = new Point(x / 2, y + 125);
                la4.Text = "La sumatoria es " + sumatoria.ToString();
                this.Controls.Add(la4);


         
                la5.Width = 200;
                la5.Height = 20;
                la5.Location = new Point(x / 2, y + 150);
                la5.Text = "La potencia es " + potencia.ToString();
                this.Controls.Add(la5);




            }
            catch (Exception ex)
            {
                MessageBox.Show("El número ingresado es un carácter o un decimal", "Aviso");
            }
                



           
          
            
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {

            if (arreglo != null)
            {
                for(int i = 0;i < arreglo.Length;i++)
                {

                    this.Controls.Remove(arreglo[i]);

                }

                this.Controls.Remove(la1);
                this.Controls.Remove(la2);
                this.Controls.Remove(la3);
                this.Controls.Remove(la4);
                this.Controls.Remove(la5);
                Txt_numero.Clear();
                Txt_numero.Focus();


            }






        }
    }
}
