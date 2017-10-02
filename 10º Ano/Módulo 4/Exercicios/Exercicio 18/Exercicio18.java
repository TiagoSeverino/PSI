package exercicio18;

import java.util.Scanner;

public class Exercicio18 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira o número de linhas e de seguida o número de colunas\n");
        int ar[][]=new int[(key.nextInt())][(key.nextInt()+1)];
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length-1;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            int cont=0;
            for(int c=0;c<ar[0].length-1;c++){
                cont+=ar[l][c];
            }
            ar[l][ar[0].length-1]=cont;
        }
        
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
    }
    
}
