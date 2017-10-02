package exercicio4;

public class Exercicio4 {

    public static void main(String[] args) {
        //Vars
        int nr[]=new int[((int)(Math.random()*100))];
        int m, m2;
        
        //Escreve No Vector
        for(int i=0;i<nr.length;i++){
            nr[i]=(int)(Math.random()*101);
        }
        
        //Inicializar Variavel
        m=m2=nr[0];
        
        //Ver Maior
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
        
        System.out.println("Maior número: " + m + ", 2º maior número: " + m2);
        
        //Mostrar Array
        for(int i=0;i<nr.length;i++){
            System.out.println(nr[i]);
        }
    }
    
}
