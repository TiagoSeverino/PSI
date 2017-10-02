package exercicio24;

import java.util.Scanner;

public class Exercicio24 {

    public static void main(String[] args) {
        //Vars
        Scanner key = new Scanner(System.in);        
        
        System.out.print("Insira o lado do quadrado\n");
        int lado=key.nextInt();
        int ar[][]=new int[lado][lado];
        int arT[][]=new int[lado][lado];
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                if(c<=l){
                   ar[l][c]=(int)(Math.random()*10); 
                }
            }
        }
        
        //Escreve No Vector
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arT[c][l]=ar[l][c];
                arT[l][c]=ar[l][c];
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
