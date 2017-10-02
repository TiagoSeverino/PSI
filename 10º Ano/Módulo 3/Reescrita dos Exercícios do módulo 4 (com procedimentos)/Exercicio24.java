package m3;

import java.util.Scanner;

public class Exercicio24 {
    
    //Vars
    Scanner key = new Scanner(System.in);        
    
    public static void main(String[] args) {
        Exercicio24 prg = new Exercicio24();
        prg.start();
    }
    
    public void start(){
        System.out.print("Insira o lado do quadrado\n");
        int lado=key.nextInt();
        int ar[][]=new int[lado][lado];
        int arT[][]=new int[lado][lado];
        
        escreverVector(ar);
        escreverVector1(ar, arT);
        mostarVector(ar);
        mostarVectorT(arT);
    }

    //Escreve No Vector
    public void escreverVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                if(c<=l){
                   ar[l][c]=(int)(Math.random()*10); 
                }
            }
        }
    }
    
    //Escreve No Vector1
    public void escreverVector1(int ar[][], int arT[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arT[c][l]=ar[l][c];
                arT[l][c]=ar[l][c];
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
