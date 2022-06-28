using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + " $ " 
                + Preco.ToString("f2" ,CultureInfo.InvariantCulture) 
                + " , "
                + Quantidade
                + " unidade, Total : $ "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
