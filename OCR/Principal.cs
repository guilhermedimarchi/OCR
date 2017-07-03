using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Neuro;
using AForge.Neuro.Learning;


namespace OCR
{
    public partial class Principal : Form
    {
        #region Atributos 
        private bool drawing;
        private RNA rnaOCR;
        #endregion

        #region Inicialização
        public Principal()
        {
            InitializeComponent();

            // Cria a imagem padrão
            pbScratch.Image = new Bitmap(200,200);

            // Inicialização de variáveis
            drawing = false;
        }
        #endregion

        #region Rotinas de Desenho 
        
        // Limpando Imagem
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbScratch.Image = new Bitmap(200, 200);
        }

        // Adicionando imagem na lista
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bitmap b = pbScratch.Image as Bitmap;
            ilSamples.Images.Add(b);
            lvInputs.Items.Add(txtName.Text);
            lvInputs.Items[lvInputs.Items.Count - 1].ImageIndex = ilSamples.Images.Count - 1;
        }

        // Começa a desenhar
        private void pbScratch_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        // Pára de desenhar
        private void pbScratch_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        // Desenha pois o mouse está apertado
        private void pbScratch_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pbScratch.Image);
                g.FillRectangle(Brushes.Black, e.X-20, e.Y-20, 40, 40);
                pbScratch.Refresh();
            }
        }
        #endregion

        #region Operação da Rede
        // Treinamento da rede
        private void btnTreinar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            // Vetor de imagens para a rede
            Bitmap [] lstBM = new Bitmap[ilSamples.Images.Count];
            int i = 0;
            foreach (Bitmap b in ilSamples.Images)
            {
                lstBM[i++] = b;
            }
            
            // Criando e treinando a rede
            rnaOCR = new RNA(ilSamples.ImageSize.Height * ilSamples.ImageSize.Width,
                lvInputs.Items.Count, 
                lstBM);
            
            // Mostrando resultado do treinamento
            lblErro.Text = rnaOCR.Error.ToString("#0.#000");
            lblEpoch.Text = rnaOCR.Epoch.ToString();
            
            timer1.Enabled = false;
        }

        // Chamando a rotina para classificar um padrão
        private void btnTestar_Click(object sender, EventArgs e)
        {
            ilSamples.Images.Add(pbScratch.Image);
            Bitmap b = ilSamples.Images[ilSamples.Images.Count - 1] as Bitmap;

            int result = rnaOCR.Recognize(b);
            lblResult.Text = lvInputs.Items[result].Text;

            ilSamples.Images.RemoveAt(ilSamples.Images.Count - 1);

        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rnaOCR != null)
            {
                lblErro.Text = rnaOCR.Error.ToString("#0.#000");
                lblEpoch.Text = rnaOCR.Epoch.ToString();
            }
        }


    }
}