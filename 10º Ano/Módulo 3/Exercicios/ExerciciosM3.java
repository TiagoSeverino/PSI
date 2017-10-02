/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exerciciosm3;

import java.util.Scanner;

/**
 *
 * @author tiago
 */
public class ExerciciosM3 {
    Scanner key = new Scanner(System.in);
    
    //Vars Ex3
    int duracao, horas, mins, secs;
    
    //Vars Ex8
    double mFinal;
    
    //Vars Ex19
    int valorInt;
    

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ExerciciosM3 prg = new ExerciciosM3();
        prg.start();
    }
    
    public void start(){
        char opcao='s';
        do{
            System.out.println("Indique o número do exercicio a executar");
            iniciarVars();
            String ex = key.nextLine();
            
            switch(ex){
                case "3":
                    exercicio3();
                    break;
                case "4":
                    exercicio4();
                    break;
                case "8":
                    exercicio8();
                    break;
                case "9":
                    exercicio9();
                    break;
                case "11":
                    exercicio11();
                    break;
                case "13":
                    exercicio13();
                    break;
                case "v1":
                    exerciciov1();
                    break;
                case "19":
                    exercicio19();
                    break;
                case "help":
                    System.out.println("Lista de exercicios:\n Exercícios sobre procedimentos e funções\n 3\n 4\n 8\n 9\n 11\n 13\n Vetores e Matrizes c/ Procedimentos e Funções\n v1");
                    break;
                default:
                    System.out.println("Exercicio Inválido!");
                    break;
            }
        
            System.out.println("Deseja continuar? [S/N]");
            opcao=key.nextLine().toLowerCase().charAt(0);
            
        }while(opcao!='n');
    }
    
    public void iniciarVars(){
        //Vars Ex3
        duracao=0;
        horas=0;
        mins=0;
        secs=0;
    }
    
    /*##### ExercicioV1#####*/
    public void exerciciov1(){
        String[][] tabela = new String[2][4];
        recolheDados(tabela);
        mostraTabela(tabela);
    }
    
    public void mostraTabela(String[][] ar){
        
        for(int i=0;i<ar.length-1;i++)
            for(int j=i+1;j<ar.length;j++)
                if(Integer.parseInt(ar[j][0])<Integer.parseInt(ar[i][0])){
                    for(int c=0;c<ar[0].length;c++){
                        String aux=ar[i][c];
                        ar[i][c]=ar[j][c];
                        ar[j][c]=aux;
                    }
                }
        
        for(int i=0;i<ar.length;i++){
            for(int c=0;c<ar[i].length;c++)
                System.out.print(ar[i][c] + " ");
            System.out.println();
        }
    }
    
    public void recolheDados(String[][] ar){
        for(int i=0;i<ar.length;i++){
            
            ar[i][0]=recolheIdade();
            ar[i][1]=recolheSexo();
            ar[i][2]=recolheOlhos();
            ar[i][3]=recolheCabelos();
        }
    }
    
    public String recolheIdade(){
        System.out.println("Insira a idade:");
        int idade = key.nextInt();key.nextLine();
        
        return Integer.toString(idade);
    }
    
    public String recolheSexo(){
        String result;
        
        System.out.println("Insira o sexo:");
        char s = key.nextLine().toLowerCase().charAt(0);
        
        if(s=='m'){
            result="Masculino";
        }else{
            result="Femenino";
        }
        
        return result;
    }
    
    public String recolheOlhos(){
        String result="";
        
        System.out.println("Insira a cor dos olhos:");
        char o = key.nextLine().toLowerCase().charAt(0);
        
        if(o=='c'){
            result="Castanhos";
        }else{
            if(o=='a'){
                result="Azuis";
            }else{
                if(o=='v'){
                    result="Verdes";
                }
            }
        }
        
        return result;
    }
    
    public String recolheCabelos(){
        String result="";
        
        System.out.println("Insira a cor do cabelo:");
        char c = key.nextLine().toLowerCase().charAt(0);
        
        if(c=='c'){
            result="Castanho";
        }else{
            if(c=='l'){
                result="Loiro";
            }else{
                if(c=='p'){
                    result="Preto";
                }else{
                    if(c=='r'){
                        result="Ruivo";
                    }
                }
            }
        }
        
        return result;
    }
    
    /*##### Exercicio14#####*/
    public void exercicio19(){
        System.out.println("Insira um número inteiro: ");
        valorInt=key.nextInt();
        key.nextLine();
        System.out.println("S = " + calcSequencia());
    }
    
    public String calcSequencia(){
        String devolve="1";
        
        for(int i=2;i<=valorInt;i++){
            devolve+=" + 1/" + i;
        }
        
        
        return devolve;
    }
    
    /*##### Exercicio13#####*/
    public void exercicio13(){
        double media = getMedia();
        
        System.out.println("A média é de: " + media);
    }
    
    public double getMedia(){
        char cont='s';
        double media=0;
        double i=0;
        
        for(i=0;cont!='n';i++){
            System.out.println("Insira um numero:");
            media+=key.nextDouble();
            key.nextLine();
            System.out.println("Deseja Continuar? [S/N]:");
            cont=key.nextLine().toLowerCase().charAt(0);
        }
        return media/=i;
    }
    
    /*##### Exercicio11#####*/
    public void exercicio11(){
        System.out.println("Insira o X, Y, Z:");
        double x=key.nextDouble();
        key.nextLine();
        double y=key.nextDouble();
        key.nextLine();
        double z=key.nextDouble();
        key.nextLine();
        
        System.out.println("A priedade do triângulo é de: " + propriedadeTriangulo(x, y, z));
    }
    
    public String propriedadeTriangulo(double x, double y, double z){
        String prop="Triângulo Inválido!";
        
        if(x==y){
            if(x==z){
                prop="Triângulo Equilátero";
            }else{
                prop="Triângulo Isósceles";
            }
        }else{
            if(y==z){
                prop="Triângulo Isósceles";
            }else{
                prop="Triângulo Escaleno:";
            }
        }
        
        if(z>(x+y)){
            prop="Triângulo Inválido!";
        }
        if(y>(x+z)){
            prop="Triângulo Inválido!";
        }
        if(x>(z+y)){
            prop="Triângulo Inválido!";
        }
        
        return prop;
    }
    
    /*##### Exercicio9 #####*/
    public void exercicio9(){
        System.out.println("Insira a altura:");
        double alt = key.nextDouble();
        key.nextLine();
        System.out.println("Insira o sexo [M/F]:");
        char sexo=key.nextLine().toLowerCase().charAt(0);
        
        System.out.println("O seu peso ideal, é de: " + pesoIdeal(alt, sexo));
    }
    
    public double pesoIdeal(double altura, char sexo){
        double pesoIdeal=0;
        
        if(sexo=='m'){
            pesoIdeal=72.7*altura-58;
        }
        
        if(sexo=='f'){
            pesoIdeal=62.1*altura-44.7;

        }
        
        return pesoIdeal;
    }
    
    /*##### Exercicio8 #####*/
    public void exercicio8(){
        System.out.println("Insira média final:");
        mFinal = key.nextDouble();
        key.nextLine();
        System.out.println("Conseito: " + conceito());
    }
    
    public String conceito(){
        String resultado="Média Inválida";;

        if(mFinal>=0){
            if(mFinal<5){
                resultado="D";
            }else{
                if(mFinal<7){
                    resultado="C";
                }else{
                    if(mFinal<9){
                        resultado="B";
                    }else{
                        if(mFinal<=10){
                            resultado="A";
                        }
                    }
                }
            }
        }
        
        return resultado;
    }
    
    /*##### Exercicio4 #####*/
    public void exercicio4(){
        System.out.println("Insira diade em Anos, Meses e Dias");
        int anos = key.nextInt();
        key.nextLine();
        int meses = key.nextInt();
        key.nextLine();
        int dias = key.nextInt();
        key.nextLine();
        System.out.println("A sua idade em dias é de " + getDias(anos, meses, dias));
    }
    
    public int getDias(int anos, int meses, int dias){
        return (anos*365)+(meses*30)+dias;
    }
    
    /*##### Exercicio3 #####*/
    public void exercicio3(){
        System.out.println("Insira o tempo da duração da fábrica em segundos:");
        duracao = key.nextInt();
        key.nextLine();
        calcularDuracao();
        System.out.println("Horas: " + horas + " Minutos: " + mins + " Segundos: " + secs);
    }
    
    public void calcularDuracao(){
        horas=duracao/3600;
        mins=(duracao-horas*3600)/60;
        secs=duracao-horas*3600-mins*60;
    }
    
}
