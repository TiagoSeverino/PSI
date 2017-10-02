package m3;

import java.util.Scanner;

public class Exercicio23 {
    
    //Vars
    Scanner key = new Scanner(System.in);        
    
    public static void main(String[] args) {
        Exercicio23 prg = new Exercicio23();
        prg.start();
    }
    
    public void start(){
        System.out.print("Insira a largura e a altura do quadrado\n");
        int lado=key.nextInt();
        int altura=key.nextInt();
        int ar[][]=new int[lado][altura];
        int arT[][]=new int[altura][lado];
        
        escreverVector(ar);
        escreverVector1(ar, arT);
        mostarVector(ar);
        mostarVectorT(arT);
    }

    //Escreve No Vector
    public void escreverVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
    }
    
    //Escreve No Vector1
    public void escreverVector1(int ar[][], int arT[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arT[c][l]=ar[l][c];
            }
        }
    }

    //Mostra Vector Original
    public void mostarVector(int ar[][]){
        System.out.println("Matriz Original");
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
    }
    
    //Mostra Vector Transposto
    public void mostarVectorT(int arT[][]){
        System.out.println("Matriz Transposta");
        for(int l=0;l<arT.length;l++){
            System.out.println();
            for(int c=0;c<arT[0].length;c++){
                System.out.print(arT[l][c] + ", ");
            }
        }
    }
}
