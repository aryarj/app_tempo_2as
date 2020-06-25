using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Data.SqlClient;



namespace app_tempo_2as
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city;

            city = txtcity.Text;
            //Verificar se o txtcity não está vazio
            if (!string.IsNullOrWhiteSpace(txtcity.Text))
            {

                string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=2cbf04e16d944f40827145503201306&q={0}&days=1", city);
                // using(SqlConnection uri2 = new SqlConnection(uri))
                /*using (uri)
                {
                    //connection.Open();
                    try
                    {*/
                        XDocument doc = XDocument.Load(uri);


                        string pais = (string)doc.Descendants("country").FirstOrDefault();
                        string lasttemp = (string)doc.Descendants("temp_c").FirstOrDefault();
                        string lastup = (string)doc.Descendants("last_updated").FirstOrDefault();
                        string maxtemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
                        string mintemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();
                        string umidade = (string)doc.Descendants("avghumidity").FirstOrDefault();
                        string uv = (string)doc.Descendants("uv").FirstOrDefault();
                        string speedwind = (string)doc.Descendants("wind_kph").FirstOrDefault();

                        txtcountry.Text = pais;
                        txttemp.Text = lasttemp;
                        txtdata.Text = lastup;
                        txttmax.Text = maxtemp;
                        txttmin.Text = mintemp;
                        txtumd.Text = umidade;
                        txtuv.Text = uv;
                        txtwsp.Text = speedwind;
                   /*}
                    catch (Exception ex)
                    {
                        //Tratamento da exceção caso haja algum erro de retorno
                        MessageBox.Show("Cidade inexistente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                    //connection.Close();
               // }       

            }
            else 
            {
                MessageBox.Show("Informe a cidade!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            txtcity.Text = string.Empty;
            txtcountry.Text = string.Empty;
            txttemp.Text = string.Empty;
            txtdata.Text = string.Empty;
            txttmax.Text = string.Empty;
            txttmin.Text = string.Empty;
            txtumd.Text = string.Empty;
            txtuv.Text = string.Empty;
            txtwsp.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
