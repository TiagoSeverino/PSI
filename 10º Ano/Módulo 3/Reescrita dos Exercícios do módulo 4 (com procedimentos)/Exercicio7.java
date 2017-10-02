package m3;

import java.util.Scanner;

public class Exercicio7 {
    
    //Vars
    Scanner key = new Scanner (System.in);
    String continua="s";
    String table[][] = new String[13][2];

    public static void main(String[] args) {
        Exercicio7 prg = new Exercicio7();
        prg.start();
    }
    
    public void start(){
        defenirMes();
        menu();
    }
    
    public void defenirMes(){
        table[0][0] = "Mês";
        table[0][1] = "Quantidade";

        table[1][0] = "Janeiro";
        table[2][0] = "Fevereiro";
        table[3][0] = "Março";
        table[4][0] = "Abril";
        table[5][0] = "Maio";
        table[6][0] = "Junho";
        table[7][0] = "Julho";
        table[8][0] = "Agosto";
        table[9][0] = "Setembro";
        table[10][0] = "Outubro";
        table[11][0] = "Novembro";
        table[12][0] = "Dezembro";
    }
    
    public void menu(){
        inicializarPreco();
        do{
            switch(desenharMenu()){
                case 1:
                    adicionarVenda();
                    break;
                case 2:
                    verRelatorio();
                    break;
                case 3:
                    continua = "n";
                    break;
                default:
                    System.out.println("Selecione uma opção válida");
                    break;
            }  
        }while(!continua.startsWith("n"));
    }
    
    public void verRelatorio(){
        for(int l=0;l<table.length;l++){
            System.out.println();
            System.out.print("| ");
            for(int c=0;c<table[0].length;c++){
                System.out.print(table[l][c] + " | ");
            }
        }
        System.out.println();
    }
    
    public void adicionarVenda(){
        System.out.println("\nInsira o mês:");
        int mes = key.nextInt();
        System.out.println("\nInsira a quantia:");
        int quantia = key.nextInt();

        quantia += Integer.parseInt(table[mes][1]);

        table[mes][1]=Integer.toString(quantia);
    }
    
    public int desenharMenu(){
        System.out.println("\nVer Relatório de vendas:");
        System.out.println("\t1- Adicionar venda\n\t2- Ver Relatório\n\t3- Sair");
        System.out.print("\t");
        return key.nextInt();
    }
    
    public void inicializarPreco(){
        for(int c=1;c<table.length;c++){
            table[c][1]="0";
        }
    }
}
