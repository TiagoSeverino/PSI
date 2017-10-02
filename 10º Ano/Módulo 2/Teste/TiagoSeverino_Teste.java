package tiagoseverino_teste;

import java.util.Scanner;

public class TiagoSeverino_Teste {

    public static void main(String[] args) {
        // Vars
        Scanner key = new Scanner(System.in);
        double c, f, m, m_ac=0, m_r=0, m_rc;
        int ceu, m_c=0;
        String s_ceu, cidade, s_tempo, bol="---------------------------------------------\n----------Boletim Metereológico--------------\n---------------------------------------------";
        char cont='s';
        
        do{
        m_c++;
        ceu=0;
        cidade="";
        s_ceu="";
        f=-999;
        c=-999;
        s_tempo="";
            
        System.out.print("Insira a temperatura em ªF: ");
        f = key.nextDouble();
        while(f<-50 || f>150){
            System.out.print("Insira entre -50 e 150ºF: ");
            f = key.nextDouble();
        }
        m_ac+=f;
        c=(f-32)*5/9;
        
        do{
        System.out.print("Insira a condição do céu (1. ensolarado, 2. neve, 3. nublado e 4. chuvoso): ");
        ceu = key.nextInt();
        }while(ceu<1 || ceu>4);
        
        switch (ceu){
            case 1:
                s_ceu="ensolarado";
                break;
            case 2:
                s_ceu="neve";
                break;
            case 3:
                s_ceu="nublado";
                break;
            case 4:
                s_ceu="chuvoso";
                break;
        }
        
        if ((ceu==2 && f<32) || (ceu==1 && f>100)){
            s_tempo="Inconsistente";
        }else{
            s_tempo="Consistente";
        }
        
        
        System.out.print("Insira a cidade: ");
        key.nextLine();
        cidade = key.nextLine();
        
        bol+="\n" + cidade + ":\n\tTemperatura: " + f + "ºF = " + c + "ºC\n\tCondição do céu: " + s_ceu + "\n\tEstado tempo: " + s_tempo + "\n";
        
        System.out.print("Quer inserir mais temperaturas? (s/n): ");
        cont = key.nextLine().charAt(0);
        
        System.out.print("\n");
        }while(cont=='s' || cont=='S');
        
        m_r=m_ac/m_c;
        
        m_rc=(m_r-32)*5/9;
        
        bol+="\n---------------------------------------------\nMédia das temperaturas: " + m_r + "ºF = " + m_rc + "ºC";
        
        System.out.print("\n" + bol);
    }
    
}
