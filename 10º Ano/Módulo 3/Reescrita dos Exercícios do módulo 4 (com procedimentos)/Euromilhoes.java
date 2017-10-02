package m3;

public class Euromilhoes {
    
    //Vars
    int n[][] = new int[5][5];
    int s[][] = new int[5][2];
    int ver;
    Boolean q=true;

    public static void main(String[] args) {
        Euromilhoes prg = new Euromilhoes();
        prg.start();
    }
   
    public void start(){
        gerarChaves();
        mostrarChaves();
    }
    
    public void gerarChaves(){
        for(int i=0;i<5;i++){
            gerarNum(i);
            gerarEst(i);
        }
    }
    
    public void gerarNum(int i){
        for(int ii=0;ii<5;ii++){
                q=true;
                
                ver=(int) ((Math.random() * 50) + 1);
                
                for(int iii=0;iii<ii;iii++){
                    if (ver == n[i][iii]){
                        q = false;
                    }
                }
                if(q){
                    n[i][ii]=ver;
                }else{
                    ii--;
                }
            }
    }
    
    public void gerarEst(int i){
        for(int ii=0;ii<2;ii++){
                q=true;
                
                ver =(int) ((Math.random() * 11) + 1);
                for(int iii=0;iii<ii;iii++){
                    if (ver == s[i][iii]){
                        q = false;
                    }
                }
                if(q){
                    s[i][ii]=ver;
                }else{
                    ii--;
                }
            }
    }
    
    public void mostrarChaves(){
        for(int i=0;i<5;i++){
            System.out.println("\nChave " + (i+1) + ":");
            System.out.println("\tNúmeros:");
            for(int ii=0;ii<5;ii++){
                System.out.println("\t" + n[i][ii]);
            }
            System.out.println("\n\tEstrelas:");
            for(int ii=0;ii<2;ii++){
                System.out.println("\t" + s[i][ii]);
            }
            
        }
    }
}
