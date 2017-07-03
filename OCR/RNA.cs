using System;
using System.Collections.Generic;
using System.Text;
using AForge.Neuro;
using AForge.Neuro.Learning;
using System.Drawing;
using System.Windows.Forms;

namespace OCR
{
    class RNA
    {
        #region Atributos e Poperties
        private ActivationNetwork neuralNet;
        private BackPropagationLearning teacher;
        private double error;

        public double Error
        {
            get { return error; }
        }
        private int epoch;
        public int Epoch
        {
            get { return epoch; }
        }
        #endregion

        #region Suporte ao Treinamento
        /// <summary>
        /// Converte uma imagem bin�ria em um vetor, onde branco fica com -0.5 e preto com 0.5
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private double[] ImgToVector(Bitmap b)
        {
            int k = 0;
            double[] result = new double[b.Height * b.Width];
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    result[k++] = (c.A == 0 ? -0.5f : 0.5f);
                }
            }
            return result;
        }


        /// <summary>
        /// Contr�i um exemplo de sa�da da rede
        /// </summary>
        /// <param name="PatternNumber"> O n�mero do padr�o </param>
        /// <returns> Um vetor onde todos os elementos s�o -0.5 exceto na posi��o indicada pelo n�mero do padr�o</returns>
        private double[] BuildOutput(int PatternNumber, int PatternSize)
        {
            double[] result = new double[PatternSize];
            for (int i = 0; i < PatternSize; i++)
            {
                result[i] = (i == PatternNumber ? 0.5f : -0.5f);
            }
            return result;
        }

        #endregion

        #region M�todos da RNA

        // Construtor - cria e treina a rede
        public RNA(int patternSize, int patternCount, Bitmap [] patternImages)
        {
            neuralNet =
                new ActivationNetwork(
                new BipolarSigmoidFunction(2.0f),
                    patternSize, // Bits na entrada da rede 
                    10,10,
                    patternCount); // N�mero de padr�es

            neuralNet.Randomize();
            
            teacher = new BackPropagationLearning(neuralNet);
            teacher.LearningRate = 0.2;
            teacher.Momentum = 0.4;

            double [][] entrada = new double[patternCount][];



            for (int i = 0; i < patternCount; i++)
            {
                entrada[i] = ImgToVector(patternImages[i]);
            }

            double[][] saida = new double[patternCount][];
            for (int i = 0; i < patternCount; i++)
            {
                saida[i] = BuildOutput(i, patternCount);
            }

            epoch = 0;

            do
            {
                error = teacher.RunEpoch(entrada, saida) / patternCount;
                epoch++;
                Application.DoEvents();
            } while (error > 0.001 && epoch < 1000000);
            

        }

        // Reconhece um padr�o informado e retorna o n�mero do padr�o reconhecido
        public int Recognize(Bitmap patternImage)
        {
            double[] entrada = ImgToVector(patternImage);

            double [] saida = neuralNet.Compute(entrada);

            int max = 0;
            for (int i = 0; i < saida.Length; i++)
            {
                if (saida[i] > saida[max])
                    max = i;
            }

            return max;
        }

        #endregion

    }
}
