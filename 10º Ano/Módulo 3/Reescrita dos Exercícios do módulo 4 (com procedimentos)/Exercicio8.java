package m3;

import java.util.Scanner;

public class Exercicio8 {
    
    //Vars
    Scanner key = new Scanner (System.in);
    int n[] = new int[1000];
    int p;
    Boolean q=false;

    public static void main(String[] args) {
        Exercicio8 prg = new Exercicio8();
        prg.start();
    }
    
    public void start(){
        gerarVector();
        pedirNum();
        procurar();
    }

    //Gerar Vector
    public void gerarVector(){
        for(int i=0;i<n.length;i++){
            n[i]=(int) (Math.random()*51);
        }
    }

    //Numero a procurar
    public void pedirNum(){
        System.out.print("Insira o número que desaja procurar: ");
        p = key.nextInt();
    }
    
    //Procura
    public void procurar(){
        for(int i=0;i<n.length;i++){
            if (n[i]==p){
                q=true;
                System.out.println("O número " + p + ", foi encontrado na posição " + (i+1) + " do vector");
            }
        }
        if (!q){
            System.out.println("Não foi encontrado o valor " + p + " no vector");
        }
    }
}
