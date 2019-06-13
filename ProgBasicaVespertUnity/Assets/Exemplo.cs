using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Esse metodo eh executado na inicializacao desse objeto");

        print("vou criar umas variaveis");
        bool booleana = true;
        int inteiro = 42;
        float numeroComVirgula = 0.016666f;
        string texto = "um texto legal";

        print("agora vou usar essas variaveis");
        print(inteiro + numeroComVirgula);

        //exemplo de condicional
        if (booleana) {
            print("imprimindo variavel texto: "+texto);
        } else {
            print("a variavel 'booleana' tem valor 'false'");
        }

        //revisando laços de repetição
        int i =5;
        while (i > 0) {
            print("nessa repetição do while, i vale: "+i);
            i--; // equivalente a i = i - 1;
        }
        print("o codigo saiu do laço!!");

        print("em Python tambem estudamos classes e funções.");

        print("vamos tentar chamar a função criada abaixo");
        MaeEuFizUmaFuncao();

        print("Funções podem retornar coisas, lembra?");
        print(EssaFuncaoRetornaUmTexto());

        print("Funcoes tambem podem usar argumentos");
        print(Some2Numeros(3 , 4));
    }

    void MaeEuFizUmaFuncao () {
        print("Mãe, eu chamei a função que eu fiz!!");
    }

    string EssaFuncaoRetornaUmTexto() {
        return "um texto";
    }

    int Some2Numeros(int a, int b) {
        return a + b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
