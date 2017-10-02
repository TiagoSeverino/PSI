
import javax.swing.JOptionPane;

public class GestãoLivrariaForm extends javax.swing.JFrame {

    String[][] tabela = new String[1000][6];
    
    /**
     * Creates new form GestãoLivrariaForm
     */
    public GestãoLivrariaForm() {
        initComponents();
    }
    
    /*#######################################################*/
    private void registar(){
        String titulo = tfTitulo.getText();
        String autor = tfAutor.getText();
        String ISBN = tfISBN.getText();
        String ano = tfAno.getText();
        String editora = tfEditora.getText();
        String preco = Double.toString((double) spPreco.getValue());
                
        if(titulo.length()>1 && autor.length()>1 && ISBN.length()>1 && ano.length()>1 && editora.length()>1 && preco != "0.0"){
            adiciona(titulo, autor, ISBN, ano, editora, preco);
        }
    }
    
    private void adiciona(String titulo, String autor, String ISBN, String ano, String editora, String preco){
        int i=0;

        while(i<tabela.length && tabela[i][0]!=null)
            i++;
        
        tabela[i][0] = titulo;
        tabela[i][1] = autor;
        tabela[i][2] = ISBN;
        tabela[i][3] = ano;
        tabela[i][4] = editora;
        tabela[i][5] = preco;
        
        mostrarRelatorio(tabela);
    }
    
    private void mostrarRelatorio(String[][] ar){
        String output="";
        
        for(int i=0; ar[i][0]!=null;i++){
            for (String item : ar[i]) {
                output += item + " ";
            }
            output+="\n";
        }
            
        
        taRelatorio.setText(output);
    }
    
    private void acimaMedia(){
        clear();
        
        for(int i=0;i<tabela.length && tabela[i][5]!=null;i++)
            if(Double.parseDouble(tabela[i][5])>=media())
                add(tabela[i][0], tabela[i][1], tabela[i][2], tabela[i][3], tabela[i][4], tabela[i][5]);
    }
    
    private void abaixoMedia(){
        clear();
        
        for(int i=0;i<tabela.length && tabela[i][5]!=null;i++)
            if(Double.parseDouble(tabela[i][5])<=media())
                add(tabela[i][0], tabela[i][1], tabela[i][2], tabela[i][3], tabela[i][4], tabela[i][5]);
    }
    
    private void add(String titulo, String autor, String ISBN, String ano, String editora, String preco){
        String output= taRelatorio.getText();

        taRelatorio.setText(output + titulo + " " + autor + " " + ISBN + " " + ano + " " + editora + " " + preco + "\n");
    }
    
    private void remove(String titulo){
        for(int i=0; i<tabela.length;i++)
            if(tabela[i][0]!=null && tabela[i][0].equals(titulo)){
                for(int c=0;c<6;c++)
                    tabela[i][c]=null;
                reordenarTabela();
            }
    }
    
    private void reordenarTabela(){
        for(int i=0; i<tabela.length-1;i++)
            if(tabela[i][0]==null && tabela[i+1][0]!=null){
                for(int c=0;c<6;c++){
                    tabela[i][c]=tabela[i+1][c];
                    tabela[i+1][c]=null;
                }
            }
        mostrarRelatorio(tabela);
    }
    
    private void clear(){
        taRelatorio.setText("");
    }
    
    private double media(){
        double media=0;
        int i;
        for(i=0;i<tabela.length && tabela[i][5]!=null;i++)
            media+=Double.parseDouble(tabela[i][5]);
        return media/=i;
    }
    
    private void reset(){
        tfTitulo.setText("");
        tfAutor.setText("");
        tfISBN.setText("");
        tfAno.setText("");
        tfEditora.setText("");
        spPreco.setValue(0);
    }
    
    private void ordenarNome(){
        clear();
        
        for(int i=0;i<tabela.length-1 && tabela[i][0]!=null;i++){
            
            for(int j=i+1;j<tabela.length && tabela[j][0]!=null;j++){
                
                if(0>(tabela[j][0].compareTo(tabela[i][0]))){
                    
                    for(int c=0; c<tabela[i].length;c++){
                        
                        String aux=tabela[i][c];
                        tabela[i][c]=tabela[j][c];
                        tabela[j][c]=aux;
                    }
                }
            }
        }
        
        mostrarRelatorio(tabela);
    }
    
    private void ordenarPreco(){
        clear();
        
        for(int i=0;i<tabela.length-1 && tabela[i][0]!=null;i++){
            
            for(int j=i+1;j<tabela.length && tabela[j][0]!=null;j++){
                
                if(0>(tabela[j][5].compareTo(tabela[i][5]))){
                    
                    for(int c=0; c<tabela[i].length;c++){
                        
                        String aux=tabela[i][c];
                        tabela[i][c]=tabela[j][c];
                        tabela[j][c]=aux;
                    }
                }
            }
        }
        
        mostrarRelatorio(tabela);
    }
    
    private void pesquisar(String o1){
        clear();
        
        int max=0;
        
        for(int i=0;i<tabela.length && tabela[i][0]!=null;i++)
            max++;
        
        int min=0;
        int ii=(min+max)/2;
        while(!tabela[ii][0].toLowerCase().equals(o1.toLowerCase())){  
            if(tabela[ii][0].toLowerCase().compareTo(o1.toLowerCase())<0){
                min=ii;
            }
            if(tabela[ii][0].toLowerCase().compareTo(o1.toLowerCase())>0){
                max=ii;
            }
            ii=(min+max)/2;
        }
        
        add(tabela[ii][0], tabela[ii][1], tabela[ii][2], tabela[ii][3], tabela[ii][04], tabela[ii][5]);
    }
    
    private void mostrarEstatistica(){
        int c=0;
        double t=0.0;
        for(int i=0;i<tabela.length && tabela[i][0]!=null;i++){
            c++;
            t+=Double.parseDouble(tabela[i][5]);
        }
        JOptionPane.showMessageDialog(rootPane, "Total Livros: " + c + "\nMédia de Preços: " + (t/c));
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        tfTitulo = new javax.swing.JTextField();
        btnPesquisar = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        tfAutor = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        tfISBN = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        tfAno = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        tfEditora = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        spPreco = new javax.swing.JSpinner();
        btnRegistar = new javax.swing.JButton();
        btnReset = new javax.swing.JButton();
        btnApagar = new javax.swing.JButton();
        btnEstatistica = new javax.swing.JButton();
        btnOrdenarTitulo = new javax.swing.JButton();
        btnOrdenarPreço = new javax.swing.JButton();
        btnAcima = new javax.swing.JButton();
        btnAbaixo = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        taRelatorio = new javax.swing.JTextArea();
        btnSair = new javax.swing.JButton();

        jButton1.setText("jButton1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Gestão Livraria by Tiago Severino");
        setResizable(false);

        jLabel1.setText("Titulo:");

        btnPesquisar.setText("Pesquisar");
        btnPesquisar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPesquisarActionPerformed(evt);
            }
        });

        jLabel2.setText("Autor:");

        jLabel3.setText("ISBN:");

        jLabel4.setText("Ano Edição:");

        jLabel5.setText("Editora:");

        jLabel6.setText("Preço:");

        spPreco.setModel(new javax.swing.SpinnerNumberModel(0.0d, null, null, 1.0d));

        btnRegistar.setText("Registar");
        btnRegistar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRegistarActionPerformed(evt);
            }
        });

        btnReset.setText("Novo");
        btnReset.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnResetActionPerformed(evt);
            }
        });

        btnApagar.setText("Apagar");
        btnApagar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnApagarActionPerformed(evt);
            }
        });

        btnEstatistica.setText("Mostar Estatistica");
        btnEstatistica.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEstatisticaActionPerformed(evt);
            }
        });

        btnOrdenarTitulo.setText("Ordenar Por Titulo");
        btnOrdenarTitulo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOrdenarTituloActionPerformed(evt);
            }
        });

        btnOrdenarPreço.setText("Ordenar Por Preço");
        btnOrdenarPreço.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOrdenarPreçoActionPerformed(evt);
            }
        });

        btnAcima.setText("Preços Acima Da Média");
        btnAcima.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAcimaActionPerformed(evt);
            }
        });

        btnAbaixo.setText("Preços Abaixo Da Média");
        btnAbaixo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAbaixoActionPerformed(evt);
            }
        });

        taRelatorio.setEditable(false);
        taRelatorio.setColumns(20);
        taRelatorio.setRows(5);
        jScrollPane1.setViewportView(taRelatorio);

        btnSair.setText("Sair");
        btnSair.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSairActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(btnEstatistica)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnOrdenarPreço)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnOrdenarTitulo))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(btnReset)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnApagar)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnAcima)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnAbaixo)))
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel1)
                                    .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(tfTitulo, javax.swing.GroupLayout.PREFERRED_SIZE, 319, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(btnPesquisar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                    .addComponent(tfAutor)))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel3)
                                    .addComponent(jLabel5)
                                    .addComponent(jLabel6))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(spPreco, javax.swing.GroupLayout.PREFERRED_SIZE, 311, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(btnRegistar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addComponent(tfISBN)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jLabel4)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(tfAno, javax.swing.GroupLayout.PREFERRED_SIZE, 43, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addComponent(tfEditora))))
                        .addContainerGap())))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnSair)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(tfTitulo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnPesquisar))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(tfAutor, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(tfISBN, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4)
                    .addComponent(tfAno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(tfEditora, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(spPreco, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnRegistar))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnReset)
                    .addComponent(btnApagar)
                    .addComponent(btnAcima)
                    .addComponent(btnAbaixo))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnOrdenarTitulo)
                    .addComponent(btnEstatistica)
                    .addComponent(btnOrdenarPreço))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 294, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnSair)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnSairActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSairActionPerformed
        System.exit(0);
    }//GEN-LAST:event_btnSairActionPerformed

    private void btnPesquisarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPesquisarActionPerformed
        pesquisar(tfTitulo.getText());
    }//GEN-LAST:event_btnPesquisarActionPerformed

    private void btnRegistarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegistarActionPerformed
        registar();
    }//GEN-LAST:event_btnRegistarActionPerformed

    private void btnResetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnResetActionPerformed
        reset();
    }//GEN-LAST:event_btnResetActionPerformed

    private void btnApagarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnApagarActionPerformed
        remove(tfTitulo.getText());
    }//GEN-LAST:event_btnApagarActionPerformed

    private void btnAcimaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAcimaActionPerformed
        acimaMedia();
    }//GEN-LAST:event_btnAcimaActionPerformed

    private void btnAbaixoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAbaixoActionPerformed
        abaixoMedia();
    }//GEN-LAST:event_btnAbaixoActionPerformed

    private void btnEstatisticaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEstatisticaActionPerformed
        mostrarEstatistica();
    }//GEN-LAST:event_btnEstatisticaActionPerformed

    private void btnOrdenarPreçoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOrdenarPreçoActionPerformed
        ordenarPreco();
    }//GEN-LAST:event_btnOrdenarPreçoActionPerformed

    private void btnOrdenarTituloActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOrdenarTituloActionPerformed
        ordenarNome();
    }//GEN-LAST:event_btnOrdenarTituloActionPerformed

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
            java.util.logging.Logger.getLogger(GestãoLivrariaForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(GestãoLivrariaForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(GestãoLivrariaForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(GestãoLivrariaForm.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new GestãoLivrariaForm().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAbaixo;
    private javax.swing.JButton btnAcima;
    private javax.swing.JButton btnApagar;
    private javax.swing.JButton btnEstatistica;
    private javax.swing.JButton btnOrdenarPreço;
    private javax.swing.JButton btnOrdenarTitulo;
    private javax.swing.JButton btnPesquisar;
    private javax.swing.JButton btnRegistar;
    private javax.swing.JButton btnReset;
    private javax.swing.JButton btnSair;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSpinner spPreco;
    private javax.swing.JTextArea taRelatorio;
    private javax.swing.JTextField tfAno;
    private javax.swing.JTextField tfAutor;
    private javax.swing.JTextField tfEditora;
    private javax.swing.JTextField tfISBN;
    private javax.swing.JTextField tfTitulo;
    // End of variables declaration//GEN-END:variables
}
