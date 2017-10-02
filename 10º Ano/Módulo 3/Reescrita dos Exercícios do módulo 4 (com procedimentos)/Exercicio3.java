package m3;

import java.util.Scanner;

public class Exercicio3 {
    //Vars
    Scanner key = new Scanner(System.in);

    double [] nrs;
    int n;
    
    double somatorio, media;
    
    public static void main(String[] args) {
        Exercicio3 prg = new Exercicio3();
        prg.start();
    }
    
    public void start(){
        pedirDimensao();
        preencherVetor();
        calcularSomatorioMedia();
        mostrarResultado();
    }
    
    public void pedirDimensao(){    
        System.out.println(" Somatório e média de N reais");
        
        // pedir a dimensão do vetor
        System.out.print("Quantos números? ");
        n = key.nextInt();
        
        // dimensionar o vetor
        nrs = new double[n];
    }

    public void preencherVetor(){
        // Preencher o vetor
        for(int i = 0; i < n; i++){
            nrs[i] = Math.random() * 51;
        }
    }

    public void calcularSomatorioMedia(){
        // calcular o somatório e a média
        somatorio = 0.0;
        for(int i = 0; i < n; i++)
            somatorio += nrs[i];
        
        media = somatorio / n;
    }

    public void mostrarResultado(){
        //Mostrar o vetor, somatório e média
        System.out.println("VETOR:");
        for(int i = 0; i < n; i++)
            System.out.println(nrs[i]);
        
        System.out.println("Somatório: " + somatorio);
        System.out.println("Média: " + media);
    }
}
