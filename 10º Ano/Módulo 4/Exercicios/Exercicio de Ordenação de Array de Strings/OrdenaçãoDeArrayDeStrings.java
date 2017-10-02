package ordenaçãodearraydestrings;

import java.util.Scanner;

public class OrdenaçãoDeArrayDeStrings {

    public static void main(String[] args) {
        //Vars
        int c=0, o;
        String nome[]=new String[9999];
        Scanner key = new Scanner(System.in);
        do{
            System.out.print("\n1. Inserir nome\n2. Mostrar lista de nomes\n3. Ordenar lista de nomes\n4. Sair\n\tOpção: ");
            o = key.nextInt();

            //Menu
            switch (o){
                case 1:
                    System.out.print("Insira o nome: ");
                    key.nextLine();
                    nome[c]=key.nextLine();
                    c++;
                    break;
                case 2:
                    //Mostrar Array
                    System.out.println("\nLista de nomes: ");
                    for(int i=0;(i<nome.length && nome[i]!=null);i++){
                        System.out.println(nome[i]);
                    }
                    break;
                case 3:
                    //Selection Sort
                    for(int i=0;i<nome.length-1;i++){
                        for(int j=i+1;j<nome.length;j++){
                            if(nome[i]!=null && nome[j]!=null && (nome[j].toLowerCase().compareTo(nome[i].toLowerCase()))<0){
                                String aux=nome[i];
                                nome[i]=nome[j];
                                nome[j]=aux;
                            }
                        }
                    }
                    break;
            }
        }while(o!=4);
    }
    
}
