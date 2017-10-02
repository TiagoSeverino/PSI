package exercicio23;

import java.util.Scanner;

public class Exercicio23 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira a largura e a altura do quadrado\n");
        int lado=key.nextInt();
        int altura=key.nextInt();
        int ar[][]=new int[lado][altura];
        int arT[][]=new int[altura][lado];
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arT[c][l]=ar[l][c];
            }
        }
        
        //Matriz Original
        System.out.println("Matriz Original");
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
        
        //Matriz Transposta
        System.out.println("Matriz Transposta");
        for(int l=0;l<arT.length;l++){
            System.out.println();
            for(int c=0;c<arT[0].length;c++){
                System.out.print(arT[l][c] + ", ");
            }
        }
    }
    
}
