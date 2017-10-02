package testeavaliaçãomodulo3;

import java.util.Scanner;


public class TesteAvaliaçãoModulo3 {
    Scanner key = new Scanner(System.in);
    int A=0, B=0;
    
    public static void main(String[] args) {
        TesteAvaliaçãoModulo3 prg = new TesteAvaliaçãoModulo3();
        prg.start();
    }
    
    private void start(){
        do{
            mostraMenu();
            recebeQuantidades();
            mostrarDiscriminativo();
        }while(desejaContinuar());
    }
    
    private boolean desejaContinuar(){
        key.nextLine();
        
        boolean continua = true;
        
        System.out.println("Deseja continuar? [S/N]");
        
        if(key.nextLine().toLowerCase().startsWith("n"))
            continua = false;
        
        return continua;
    }
    
    private void mostraMenu(){
        System.out.println("Produto A - 10€\nProduto B - 20€");
    }
    
    private void recebeQuantidades(){
        System.out.println("Insira a quantidade de produto A que deseja comprar:");
        A=key.nextInt();
        System.out.println("Insira a quantidade de produto B que deseja comprar:");
        B=key.nextInt();
        
    }
    
    private double devolveTaxaDesconto(){
        double desconto = 10;
        
        if(A>0 && B>0)
            desconto=15;
        
        return desconto;
    }
    
    private double devolveDesconto(double taxa, double valor){
        return valor/100*taxa;
    }
    
    private void mostrarDiscriminativo(){
        double total=A*10+B*20;
        double taxaDesconto = devolveTaxaDesconto();
        double desconto = devolveDesconto(taxaDesconto, total);
        
        System.out.println("----------------------------------------\n"
                         + "             Nota De Compra             \n"
                         + "----------------------------------------\n"
                         + "Produto A:                              \n"
                         + "\tQuantidade: " + A + " \tValor: " + A*10 + "€\n"
                         + "Produto B:                              \n"
                         + "\tQuantidade: " + B + " \tValor: " + B*20 + "€\n"
                         + "\n"
                         + "Desconto:                                \n"
                         + "\tTaxa: " + taxaDesconto + "% \tValor: " + desconto + "€\n"
                         + "----------------------------------------\n"
                         + "\tTOTAL A PAGAR: " + (total-desconto) + "€\n"
                         + "----------------------------------------\n");
    }
    
    
    
}
