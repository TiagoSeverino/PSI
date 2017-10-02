package exercicio8;

import java.util.Scanner;

public class Exercicio8 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner (System.in);
        int n[] = new int[(int) (50/Math.random()*2)];
        int p;
        Boolean q=false;
        
        //Gerar Vector
        for(int i=0;i<n.length;i++){
            n[i]=(int) (50/Math.random()*2);
        }
        
        System.out.print("Insira o número que desaja procurar: ");
        p = key.nextInt();
        
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
