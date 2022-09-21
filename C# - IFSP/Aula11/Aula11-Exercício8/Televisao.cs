using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exercício8
{
    internal class Televisao
    {
        private string marca, modelo;
        private DateTime data;
        private decimal preco, polegadas;
        private bool LCD;

        public void setMarca (string marca)
        {
            this.marca = marca;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void setData(DateTime data)
        {
            this.data = data;
        }
        public void setPreco(decimal preco)
        {
            this.preco = preco;
        }
        public void setPolegadas(decimal polegadas)
        {
            this.polegadas = polegadas;
        }
        public void setLCD(bool LCD)
        {
            this.LCD = LCD;
        }

        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }
        public DateTime getData()
        {
            return data;
        }
        public decimal getPreco()
        {
            return preco;
        }
        public decimal getPolegadas()
        {
            return polegadas;
        }
        public bool getLCD()
        {
            return LCD;
        }

        public float getPrecoPlus()
        {
            float p = (float)preco;
            float plus = (float)(p * 0.1);

            return p + plus;
            //???????????????? tive que usar float porque não consigo usar * com decimal
        }
    }
}
