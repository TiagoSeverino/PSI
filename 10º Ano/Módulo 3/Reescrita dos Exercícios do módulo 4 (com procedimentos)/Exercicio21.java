package m3;

import java.util.Scanner;

public class Exercicio21 {
    
    //Vars
    Scanner key = new Scanner(System.in);        
    
    public static void main(String[] args) {
        Exercicio21 prg = new Exercicio21();
        prg.start();
    }
    
    public void start(){
        System.out.print("Insira o número de linhas e de seguida o número de colunas\n");
        int ar[][]=new int[(key.nextInt()+1)][(key.nextInt())];
        
        escreverVector(ar);
        defenirMaior(ar);
        mostarVector(ar);
    }

    //Escreve No Vector
    public void escreverVector(int ar[][]){
        for(int l=0;l<ar.length-1;l++){
            for(int c=0;c<ar[0].length;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
    }

    //Escreve Soma
    public void defenirMaior(int ar[][]){
        for(int c=0;c<ar[0].length;c++){
            int cont=ar[c][0];
            for(int l=0;l<ar.length-1;l++){
                if(ar[l][c]>cont){
                    cont=ar[l][c];
                }
            }
            ar[ar.length-1][c]=cont;
        }
    }

    //Mostra Vector
    public void mostarVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + " ");
            }
        }
    }
}
