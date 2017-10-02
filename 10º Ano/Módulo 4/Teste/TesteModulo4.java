package testemodulo4;

import java.util.Scanner;

public class TesteModulo4 {
    
    String[][] ar = new String[3][13];

    public static void main(String[] args) {
        TesteModulo4 prg = new TesteModulo4();
        prg.start();
    }
    
    public void start(){
        preencherArray();
        int sair=0;
        do{
            mostarMenu();
            switch(opcao()){
                case 1:
                    inserirLucro();
                    break;
                case 2:
                    mostrarLucro();
                    break;
                case 3:
                    sair=1;
                    break;
                default:
                    start();
                    break;
            }
        }while(sair==0);
    }
    
    public void preencherArray(){
        String[] mes = {"Janeiro  ", "Fevereiro", "Março    ", "Abril    ", "Maio   	 ", "Junho ", "Julho ", "Agosto   ", "Setembro ", "Outubro  ", "Novembro ", "Dezembro "};
        ar[0][0]="Mês ";
        
        for(int c=0;c<ar[0].length; c++){
            switch (c){
                case 0:
                    for(int i=1;i<ar[0].length;i++){
                        ar[c][i]=mes[i-1];
                    }
                break;
                case 1:
                    System.out.println("Insira o nome da loja 1:");
                    ar[1][0] = String.format("Loja de " + getString());
                    for(int i=1;i<ar[0].length;i++){
                        ar[c][i]="0";
                    }
                break;
                case 2:
                    System.out.println("Insira o nome da loja 2:");
                    ar[2][0] = "Loja de " + getString();
                    for(int i=1;i<ar[0].length;i++){
                        ar[c][i]="0";
                    }
                break;
            }
        }
    }
    
    public String getString(){
        Scanner key = new Scanner(System.in);
        
        return key.nextLine();
    }
    
    public void mostarMenu(){
        System.out.println("\n\nMenu\n\t1.Inserir Lucro\n\t2.Mostar Lista Dos Lucros\n\t3.Sair");
    }
    
    public int opcao(){
        Scanner key = new Scanner(System.in);
        
        return key.nextInt();
    }
    
    public void inserirLucro(){
        System.out.println("\nInsira a loja (1/2):");
        int loja = opcao();
        System.out.println("\nInsira o mês:");
        int mes = opcao();
        System.out.println("\nInsira a quantia:");
        int quantia = opcao();

        quantia += Integer.parseInt(ar[loja][mes]);

        ar[loja][mes]=Integer.toString(quantia);
    }
    
    public void mostrarLucro(){
        int total = 0;
        int[] maior = {1, 0};
        for(int i = 0;i<ar[0].length; i++){
            System.out.println();
            for(int l = 0;l<ar.length;l++){
                if (i==0 || l==0){
                    System.out.print(String.format("%-14S", ar[l][i]));
                }else{
                    System.out.print(String.format("%10S", ar[l][i] + "€"));
                }
                if (i>0 && l>0){
                    total += Integer.parseInt(ar[l][i]);
                    
                    if(Integer.parseInt(ar[l][i])>=maior[1]){
                        maior[1] = Integer.parseInt(ar[l][i]);
                        maior[0] = l;
                    }
                }
            }
        }
        System.out.println("\n\nTotal dos lucros: " + total + "€");
        System.out.println("Média Mensal: " + (total/24) + "€");
        System.out.println("Maior Lucro na " + ar[(maior[0])][0] + ": " + maior[1] + "€");
    }
}
