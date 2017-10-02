
import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author tiago
 */
public class BatalhaNaval extends javax.swing.JFrame {
    
    //Gameplay
    String Submarine = "1";
    String Destroyer = "2";
    String Cruiser = "3";
    String BattleShip = "4";
    String AircraftCarrier = "5";


    int largura = 10;
    int altura = 10;
    
    int[] nrBarcos={5, 4, 3, 2, 1};
    
    int x, y, random;
    
    String[][] tabela = new String[altura][largura];
    JButton[][] buttons = new JButton[altura][largura];
    
    String totalTiros = "Total Tiros - ";
    String tirosAcertados = "Tiros Acertados - ";
    
    int tirosTotal = 0;
    int acertadosTiros = 0;
    
    
    
    //Non GUI Functions

    
    

    /**
     * Creates new form BatalhaNaval
     */

    public BatalhaNaval() {
        initComponents();
        criarButoes();
        reiniciar();
    }    
    
    private void novoMapa(){
        for(int s=5;s>0;s--)
            for(int i=0;i<nrBarcos[(s-1)];i++){
                do{
                    x = (int) (Math.random()*10);
                    y = (int) (Math.random()*10);
                    random = (int) (Math.random()*2);

                }while(!podeBarco(x, y, random, s));
                meteBarco(x, y, random, s);
            }
    }
    
    private void meteBarco(int x, int y, int rnd, int size){
        String desenha;
        
        switch(size){
            case 1:
                desenha=Submarine;
                break;
            case 2:
                desenha=Destroyer;
                break;
            case 3:
                desenha=Cruiser;
                break;
            case 4:
                desenha=BattleShip;
                break;
            case 5:
                desenha=AircraftCarrier;
                break;
            default:
                desenha=null;
                break;
        }
        
        if(rnd==0){
            for(int x1=x;x1<x+size;x1++){
                tabela[y][x1]=desenha;
            }
        }else{
            for(int y1=y;y1<y+size;y1++){
                tabela[y1][x]=desenha;
            }
        }
    }
    
    private boolean podeBarco(int x, int y, int rnd, int size){
        boolean devolve=true;
            
        if(rnd==0){
            //Desenha Horizontal
            if(x+size>largura){
                devolve=false;
            }else{
                for(int x1=x;x1<x+size;x1++){
                    if(tabela[y][x1]!=null){
                        devolve=false;
                    }
                    if(x1!=0){
                        if(tabela[y][x1-1]!=null){
                            devolve=false;
                        }
                    }
                    if(x1!=9){
                        if(tabela[y][x1+1]!=null){
                            devolve=false;
                        }
                    }
                    
                    //Cima e Baixo
                    if(y==0){
                        if(tabela[y+1][x1]!=null){
                            devolve=false;
                        }
                    }else{
                        if(y==9){
                            if(tabela[y-1][x1]!=null){
                                devolve=false;
                            }
                        }else{
                            if(tabela[y-1][x1]!=null || tabela[y+1][x1]!=null){
                                devolve=false;
                            }
                        }
                    }
                    
                }
            }
        }else{
            //Desenha Vertical
            if(y+size>altura){
                devolve=false;
            }else{
                for(int y1=y;y1<y+size;y1++){
                    if(tabela[y1][x]!=null){
                        devolve=false;
                    }
                    if(y1!=0){
                        if(tabela[y1-1][x]!=null){
                            devolve=false;
                        }
                    }
                    if(y1!=9){
                        if(tabela[y1+1][x]!=null){
                            devolve=false;
                        }
                    }
                    //Cima e Baixo
                    if(x==0){
                        if(tabela[y1][x+1]!=null){
                            devolve=false;
                        }
                    }else{
                        if(x==9){
                            if(tabela[y1][x-1]!=null){
                                devolve=false;
                            }
                        }else{
                            if(tabela[y1][x-1]!=null || tabela[y1][x+1]!=null){
                                devolve=false;
                            }
                        }
                    }
                    
                }
            }
            
            //Esquerda e Direita
            if(y==0){
                if(tabela[y+size][y]!=null){
                    devolve=false;
                }
            }else{
                if(y+size>=9){
                    if(tabela[y-1][x]!=null){
                        devolve=false;
                    }
                }else{
                    if(tabela[y-1][x]!=null || tabela[y+size][x]!=null){
                        devolve=false;
                    }
                }
            } 
        }
        
        return devolve;
    }
    
    private void updateScore(){
        lbTotal.setText(totalTiros + tirosTotal);
        lbAcertados.setText(tirosAcertados + acertadosTiros);
    }
    
    private void reiniciar(){

        tirosTotal=0;
        acertadosTiros=0;
        updateScore();
        for (int l=0;l<buttons.length; l++)
            for(int c=0; c<buttons[l].length; c++){
                buttons[l][c].setText(null);
                buttons[l][c].setBackground(Color.LIGHT_GRAY);
                tabela[l][c] = null;
            }
        novoMapa();
    }
    
    private void jogada(int l, int c){
        //Butão Não Carregado
        if (buttons[l][c].getText()==null){
            tirosTotal++;
            buttons[l][c].setText("");
            if (tabela[l][c]!=null){
                acertadosTiros++;
                switch(tabela[l][c]){
                    case "1":
                        //buttons[l][c].setText(Submarine);
                        buttons[l][c].setBackground(Color.RED);
                        break;
                    case "2":
                        //buttons[l][c].setText(Destroyer);
                        buttons[l][c].setBackground(Color.GREEN);
                        break;
                    case "3":
                        //buttons[l][c].setText(Cruiser);
                        buttons[l][c].setBackground(Color.BLUE);
                        break;
                    case "4":
                        //buttons[l][c].setText(BattleShip);
                        buttons[l][c].setBackground(Color.YELLOW);
                        break;
                    case "5":
                        //buttons[l][c].setText(AircraftCarrier);
                        buttons[l][c].setBackground(Color.ORANGE);
                        break;
                }
            }else{
                //buttons[l][c].setText("0");
                buttons[l][c].setBackground(Color.BLACK);
            }
        }
        updateScore();
        
        if(acertadosTiros==35){
            JOptionPane.showMessageDialog(null, "Parabéns Ganhou!");
            reiniciar();
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnSair = new javax.swing.JButton();
        btnReinicia = new javax.swing.JButton();
        lbTotal = new javax.swing.JLabel();
        lbAcertados = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Batalha Naval by Tiago Severino");
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setResizable(false);

        jPanel1.setLayout(new java.awt.GridLayout(10, 10));

        btnSair.setText("Sair");
        btnSair.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSairActionPerformed(evt);
            }
        });

        btnReinicia.setText("Reiniciar");
        btnReinicia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnReiniciaActionPerformed(evt);
            }
        });

        lbTotal.setText("Total Tiros - 0");

        lbAcertados.setText("Tiros Acertados - 0");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lbTotal)
                        .addGap(44, 44, 44)
                        .addComponent(lbAcertados)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 79, Short.MAX_VALUE)
                        .addComponent(btnReinicia)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnSair)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, 410, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnSair)
                    .addComponent(btnReinicia)
                    .addComponent(lbTotal)
                    .addComponent(lbAcertados))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    
    //<editor-fold defaultstate="collapsed" desc="Butões">
    private void criarButoes(){
        for (int l = 0;l<buttons.length;l++){
            for (int i = 0;i<buttons[0].length;i++)
            {
                buttons[l][i] = new JButton(" ");
                jPanel1.add(buttons[l][i]);
                
                buttons[l][i].addActionListener(new ActionListener() {
                    @Override
                    public void actionPerformed(ActionEvent e) {
                        JButton button = (JButton) e.getSource();

                        for(int l = 0; l < buttons.length; l++){
                            for(int i = 0; i< buttons[l].length; i++){
                                if(buttons[l][i] == button)
                                    jogada(l, i);
                            }
                        }
                    }
                });
            }
        }
    }
    
    private void btnReiniciaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnReiniciaActionPerformed
        reiniciar();
    }//GEN-LAST:event_btnReiniciaActionPerformed

    private void btnSairActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSairActionPerformed
        System.exit(0);
    }//GEN-LAST:event_btnSairActionPerformed

    //</editor-fold>
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(BatalhaNaval.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(BatalhaNaval.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(BatalhaNaval.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(BatalhaNaval.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new BatalhaNaval().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnReinicia;
    private javax.swing.JButton btnSair;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel lbAcertados;
    private javax.swing.JLabel lbTotal;
    // End of variables declaration//GEN-END:variables
}
