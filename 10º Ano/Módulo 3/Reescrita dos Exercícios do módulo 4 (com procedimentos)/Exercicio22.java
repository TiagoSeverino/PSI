package m3;

import java.util.Scanner;

public class Exercicio22 {
    
    //Vars
    Scanner key = new Scanner(System.in);        
    
    public static void main(String[] args) {
        Exercicio22 prg = new Exercicio22();
        prg.start();
    }
    
    public void start(){
        System.out.print("Insira o número de linhas e de seguida o número de colunas\n");
        int ar[][]=new int[(key.nextInt())][(key.nextInt()+1)];
        
        escreverVector(ar);
        defenirMaior(ar);
        mostarVector(ar);
    }

    //Escreve No Vector
    public void escreverVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            for(int c=0;c<ar[0].length-1;c++){
                ar[l][c]=(int)(Math.random()*10);
            }
        }
    }

    //Escreve Soma
    public void defenirMaior(int ar[][]){
        for(int l=0;l<ar.length;l++){
            int cont=ar[l][0];
            for(int c=0;c<ar[0].length-1;c++){
                if(ar[l][c]>cont){
                    cont=ar[l][c];
                }
            }
            ar[l][ar[0].length-1]=cont;
        }
    }

    //Mostra Vector
    public void mostarVector(int ar[][]){
        for(int l=0;l<ar.length;l++){
            System.out.println();
            for(int c=0;c<ar[0].length;c++){
                System.out.print(ar[l][c] + ", ");
            }
        }
    }
}
