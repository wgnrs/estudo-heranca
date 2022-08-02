using System;

public class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salario { get; set; }

        public double getBonificacao()
        {
            return salario*0.1;
        }
    }