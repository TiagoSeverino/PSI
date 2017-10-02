package exercicio19;

import java.util.Scanner;

public class Exercicio19 {

    public static void main(String[] args) {
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira o número de linhas e de seguida o número de colunas\n");
        int ar[][]=new int[(key.nextInt()+1)][(key.nextInt())];
        
        //Escreve No Vector
        for(int l=0;l<ar.length-1;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
        
        //Escreve No Vector
        for(int c=0;c<ar[0].length;c++){
            int cont=0;
                for(int l=0;l<ar.length-1;l++){
                cont+=ar[l][c];
            }
            ar[ar.length-1][c]=cont;
        }
        
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + " ");
            }
        }
    }
    
}
