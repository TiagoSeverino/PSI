package exercicio12mod2;

import java.util.Scanner;

/**
 *
 * @author Tiago Severino e André Belchior
 */
public class Exercicio12Mod2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //Vars
        Scanner key = new Scanner(System.in);
        double n1, n2, m, n;
        boolean passou=false;
        
        System.out.print("Insira a 1ª nota:\n");
        n1 = key.nextDouble();
        System.out.print("Insira a 2ª nota:\n");
        n2 = key.nextDouble();
        
        m = (n1+n2)/2;
        
        if (m>=16.5){
            System.out.print("Aprovado, com a nota Muito Bom, e com as notas de: " + n1 + " e " + n2 + " resultando numa média de " + m + "\n");
        }else{
            if (m>=13.5){
                System.out.print("Aprovado, com a nota Bom, e com as notas de: " + n1 + " e " + n2 + " resultando numa média de " + m + "\n");
            }else{
                if (m>=9.5){
                    System.out.print("Aprovado, com a nota Suficiente, e com as notas de: " + n1 + " e " + n2 + " resultando numa média de " + m + "\n");
                }else{
                    if (m>=6.5){
                        System.out.print("Reprovado, com a nota Insuficiente, e com as notas de: " + n1 + "  e " + n2 + " resultando numa média de " + m + "\n");
                    }else{
                        System.out.print("Reprovado, com a nota Mediocre, e com as notas de: " + n1 + " e " + n2 + " resultando numa média de " + m + "\n");
                    }
                }
            }
        }
    }
}
