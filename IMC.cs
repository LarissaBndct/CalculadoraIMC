using System;

class IMC
{
    //atributos
    public double peso, altura;


public double imc()
{
    return peso/(altura*altura);
} 
public string situacao(double imc)
    {
    //variável
    string retorno;

    //condicional
    if(imc <= 18.5)
    {
        retorno = "Abaixo do peso";
    }
    else if(imc < 25)
    {
        retorno = "Peso normal";
    }
    else if(imc < 30)
    {
        retorno = "Acima do peso";
    }
    else if(imc < 35)
    {
        retorno = "Obesidade I";
    }
    else if(imc < 40)
    {
        retorno = "Obesidade II";
    }
    else
    {
        retorno = "Obesidade III";
    }
    //retornar mensagem
    return retorno;
    }
    // mensagem 
    public void mensagem()
    {
        //obter calculo
        double obterimc = imc();
        //obtersituaçao
        string obterSituacao = situacao(obterimc);
        //exibir mensagem
        Console.WriteLine("Seu IMC é "+obterimc);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }

}