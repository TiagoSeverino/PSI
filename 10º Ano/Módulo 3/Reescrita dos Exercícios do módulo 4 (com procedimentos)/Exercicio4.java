package m3;

import java.util.Scanner;

public class Exercicio4 {
    
    //Vars
    int nr[]=new int[((int)(Math.random()*100))];
    int m, m2;
    
    public static void main(String[] args) {
        Exercicio4 prg = new Exercicio4();
        prg.start();
    }
    
    public void start(){
        escreverArray();
        maior();
        mostrarArray();
    }
    
    //Escreve No Vector
    public void escreverArray(){
        for(int i=0;i<nr.length;i++){
            nr[i]=(int)(Math.random()*101);
        }
        m=m2=nr[0];
    }
    
    //Ver Maior
    public void maior(){
        for(int i=1;i<nr.length;i++){
            if (nr[i]>m){
                m2=m;
                m=nr[i];
            }else{
                if (nr[i]>m2){
                    m2=nr[i];
                }
            }
        }
    }
    
    //Mostrar Array
    public void mostrarArray(){
        System.out.println("Maior número: " + m + ", 2º maior número: " + m2);
        
        for(int i=0;i<nr.length;i++){
            System.out.println(nr[i]);
        }
    }
}
