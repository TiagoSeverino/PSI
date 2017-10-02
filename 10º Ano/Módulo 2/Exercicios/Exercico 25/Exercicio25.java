package exercicio25;

import java.util.Scanner;

public class Exercicio25 {

public static void main(String[] args){
        int n;
        long c=1, r=0;
        
        Scanner key = new Scanner(System.in);
        
        for(int i=1;i<=10;i++){
            System.out.print("Inserir número nº" + i + ": ");
            n=key.nextInt();
            
            for(int ii=1;ii<=n;ii++){
                c*=ii;
            }
            r+=c;
            c=1;
        }
        System.out.print("A média é de: " + (r/10));
    }
    
}