using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        protected double SalarioBase { get; set; }
        public Colaborador(int id, string nome, double salarioBase)
        {
            Id = id;
            Nome = nome;
            SalarioBase = salarioBase;
        }
        public abstract double CalcularVencimento();
        public double GetSalarioBase() => SalarioBase;
    }
}

// Essa classe ta garantindo os 3 pilares da POO, deixamos ela abstract pelo fato dela estar imcompleta
// e nao podermos instanciar ela diretamente. Não podemos criar um novo colaborador, essa classe serve apenas
// para ser herdada. O colaborador necessita ser ou um efetivo ou um freelancer nesse caso.
//O abstract aqui serve para dizer que ela esta imcompleta e precisa de atributos das filhas.
//Ao usar o abstract no metodo de calcular o vencimento, estamos dizendo que todas suas filhas 
// vão herdar esse metodo e que é obrigatorio ter o seu proprio metodo de calcular. Êstamos obrigado
// as suas filhas a terem q calcular com esse metodo, proprio para cada filha.
// por isso usamos o override nas filhas e definimos o metodo proprio em cada filha
// O Protected é o ENCAPSULAMENTO, usei no salario base pq quero que as filhas consigam usam esse valor nos seus metodos e dados, mas nao quero
// que consigam alterar esse valor usando alguma coisa do tipo colab.SalarioBase = 0
// Ja o metodo publico do GetSalarioBase, foi criado para que eu conseguisse mostrar os valor do SalarioBase nas labels, por ele estar protected, so consigo
// mostrar assim. Tipo uma janela de leitura, consigo mostrar, mas nao alterar