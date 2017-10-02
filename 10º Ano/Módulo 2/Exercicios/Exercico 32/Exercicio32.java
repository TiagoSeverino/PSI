package exercicio32;

import java.util.Calendar;
import java.util.Scanner;

public class Exercicio32 {

    public static void main(String[] args) {
        Scanner key = new Scanner(System.in);
        Calendar now = Calendar.getInstance();
        //vars
        String movimentos="", util, serv;
        double saldo, lev, dep;
        int r;
        
        System.out.print("Inserir depósito inicial: ");
        saldo=key.nextDouble();
        movimentos+="[" + now.get(Calendar.HOUR_OF_DAY) + ":" + now.get(Calendar.MINUTE) + "] Depósito inicial: " + saldo + "€\n";
        
        do{
            System.out.print("\nSelecionar opção:\n1. Levantamento\n2. Depósito\n3. Pagamento de serviços\n4. Consulta de saldo\n5. Consulta de movimentos\n6. Sair\n");
            System.out.print("Opção: ");
            r=key.nextInt();
            
            switch (r) {
                case 1:
                    //Levantamento
                    System.out.print("\nInsira a quantia a levantar: ");
                    lev=key.nextDouble();
                    if (lev<=saldo){
                        System.out.print("\nInsira a utilizaçã do levantamento: ");
                        key.nextLine();
                        util=key.nextLine();
                        saldo-=lev;
                        movimentos+="[" + now.get(Calendar.HOUR_OF_DAY) + ":" + now.get(Calendar.MINUTE) + "] Levantamento: " + lev + "€ Utilidade: " + util + "\n";
                    }else{
                        System.out.print("\nNão possui essa quantia");
                    }
                    break;
                case 2:
                    //Depósito
                    System.out.print("\nInserir valor a depóitar: ");
                    dep=key.nextDouble();
                    saldo+=dep;
                    movimentos+="[" + now.get(Calendar.HOUR_OF_DAY) + ":" + now.get(Calendar.MINUTE) + "] Depósito " + dep + "€\n";
                    break;
                case 3:
                    //Pagamento de Serviços
                    System.out.print("\nInsira o serviço a pagar: ");
                    key.nextLine();
                    serv=key.nextLine();
                    System.out.print("Insira a quantia a pagar: ");
                    lev=key.nextDouble();
                    if (lev<=saldo){
                        System.out.print("Insira a entidade credora: ");
                        key.nextLine();
                        util=key.nextLine();
                        saldo-=lev;
                        movimentos+="[" + now.get(Calendar.HOUR_OF_DAY) + ":" + now.get(Calendar.MINUTE) + "] Pagamento de Serviços: " + lev + "€ Serviço: " + serv + " Entidade Credora: " + util + "\n";
                    }else{
                        System.out.print("Não possui essa quantia\n");
                    }
                    break;
                case 4:
                    //Consulta de saldo
                    System.out.println("\nSaldo atual: " + saldo + "€");
                    break;
                case 5:
                    //Consulta de movimentos
                    System.out.println(movimentos);
                    break;
                case 6:
                    //Sair
                    break;
                default:
                    //Opção Inválida
                    System.out.print("\nInsira uma opção válida\n");
                    break;
                            }
        }while(r!=6);
        
    }
    
}
