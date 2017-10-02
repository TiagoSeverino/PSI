
package exercicio26;

import java.util.Scanner;

public class Exercicio26 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira o lado do quadrado\n");
        int lado=key.nextInt();
        int ar[][]=new int[lado][lado];
        int arT[][]=new int[lado][lado];
        int arR[][]=new int[lado][lado];
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10); 
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<arT.length;l++){
            for(int c=0;c<arT[0].length;c++){
                arT[l][c]=(int)(Math.random()*10); 
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arR[l][c]=ar[l][c]+arT[l][c];
            }
        }
        
        //Matriz 1
        System.out.println("Matriz 1");
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
        
        //Matriz 2
        System.out.println("Matriz 2");
        for(int l=0;l<arT.length;l++){
            System.out.println();
            for(int c=0;c<arT[0].length;c++){
                System.out.print(arT[l][c] + ", ");
            }
        }
        
        //Matriz 3
        System.out.println("Soma das matrizes");
        for(int l=0;l<arR.length;l++){
            System.out.println();
            for(int c=0;c<arR[0].length;c++){
                System.out.print(arR[l][c] + ", ");
            }
        }
    }
    
}
