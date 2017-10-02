package exercicio.pkg24;

import java.util.Scanner;

public class Exercicio24 {


    public static void main(String[] args){
        int n;
        long c=1, r=0;
        
        Scanner key = new Scanner(System.in);
        
        for(int i=1;i<=15;i++){
            System.out.print("Inserir número nº" + i + ": ");
            n=key.nextInt();
            
            for(int ii=1;ii<=n;ii++){
                c*=ii;
            }
            r+=c;
            c=1;
        }
        System.out.print("A soma dos fatoriais é de: " + r);
    }
    
}
