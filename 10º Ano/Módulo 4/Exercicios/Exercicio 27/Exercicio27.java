
package exercicio27;

import java.util.Scanner;

public class Exercicio27 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira o lado e a altura quadrado e de seguida o lado da 2ª matriz\n");
        int altura=key.nextInt();
        int lado=key.nextInt();
        int altura1=key.nextInt();
        
        int ar[][]=new int[altura][lado];
        int arT[][]=new int[lado][altura1];
        int arR[][]=new int[altura][altura1];
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10); 
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<arT.length;l++){
            for(int c=0;c<arT[0].length;c++){
                arT[l][c]=(int)(Math.random()*5); 
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<arR.length;l++){
            for(int c=0;c<arR[0].length;c++){
                for(int i=0;i<ar[0].length;i++){
                    arR[l][c]+=ar[l][i]*arT[i][c];
                }
            }
            
        }
        
        //Matriz 1
        System.out.println("\nMatriz 1");
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(String.format("%4d", ar[l][c]));
            }
        }
        
        //Matriz 2
        System.out.println("\n\nMatriz 2");
        for(int l=0;l<arT.length;l++){
            System.out.println();
            for(int c=0;c<arT[0].length;c++){
                System.out.print(String.format("%4d",arT[l][c]));
            }
        }
        
        //Matriz 3
        System.out.println("\n\nMultiplicação das matrizes");
        for(int l=0;l<arR.length;l++){
            System.out.println();
            for(int c=0;c<arR[0].length;c++){
                System.out.print(String.format("%4d",arR[l][c]));
            }
        }
    }
}
