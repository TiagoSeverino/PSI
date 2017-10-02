package m3;

import java.util.Scanner;

public class Exercicio26 {
    
    //Vars
    Scanner key = new Scanner(System.in);        
    
    public static void main(String[] args) {
        Exercicio26 prg = new Exercicio26();
        prg.start();
    }
    
    public void start(){
        System.out.print("Insira o lado do quadrado\n");
        int lado=key.nextInt();
        int ar[][]=new int[lado][lado];
        int arT[][]=new int[lado][lado];
        int arR[][]=new int[lado][lado];
        
        escreverVector(ar);
        escreverVector1(ar, arT);
        escreverVector2(ar, arT, arR);
        mostarVector(ar);
        mostarVector1(arT);
        mostarVector1(arR);
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
        for(int l=0;l<arT.length;l++){
            for(int c=0;c<arT[0].length;c++){
                arT[l][c]=(int)(Math.random()*10); 
            }
        }
    }
    
    //Escreve No Vector2
    public void escreverVector2(int ar[][], int arT[][], int arR[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length;c++){
                arR[l][c]=ar[l][c]+arT[l][c];
            }
        }
    }

    //Mostra Vector Original
    public void mostarVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
    }
    
    //Mostra Vector 2
    public void mostarVector1(int arT[][]){
        System.out.println("Matriz 2");
        for(int l=0;l<arT.length;l++){
            System.out.println();
            for(int c=0;c<arT[0].length;c++){
                System.out.print(arT[l][c] + ", ");
            }
        }
    }
    
    //Mostra Vector Soma
    public void mostarVector2(int arR[][]){
        System.out.println("Soma das matrizes");
        for(int l=0;l<arR.length;l++){
            System.out.println();
            for(int c=0;c<arR[0].length;c++){
                System.out.print(arR[l][c] + ", ");
            }
        }
    }
}
