/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package p2actv2;

import java.util.Random;
import java.util.Stack;
import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.ListModel;
import javax.swing.event.ListDataListener;

/**
 *
 * @author glas1
 */
public class Tarea8 extends javax.swing.JFrame {

    /**
     * Creates new form Tarea8
     */
    public Tarea8() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane2 = new javax.swing.JScrollPane();
        filteredList = new javax.swing.JList<>();
        filterButton = new javax.swing.JButton();
        searchField = new javax.swing.JFormattedTextField();
        jLabel1 = new javax.swing.JLabel();
        replaceField = new javax.swing.JFormattedTextField();
        jLabel2 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        unfilteredList = new javax.swing.JList<>();
        generateButton = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jScrollPane2.setViewportView(filteredList);

        getContentPane().add(jScrollPane2, new org.netbeans.lib.awtextra.AbsoluteConstraints(470, 50, 170, 540));

        filterButton.setFont(new java.awt.Font("sansserif", 1, 24)); // NOI18N
        filterButton.setText("Filtrar ");
        filterButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filterButtonActionPerformed(evt);
            }
        });
        getContentPane().add(filterButton, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 320, 130, 70));

        searchField.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.NumberFormatter(java.text.NumberFormat.getIntegerInstance())));
        searchField.setText("5");
        searchField.setToolTipText("");
        searchField.setFont(new java.awt.Font("sansserif", 0, 24)); // NOI18N
        searchField.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                searchFieldActionPerformed(evt);
            }
        });
        getContentPane().add(searchField, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 120, 130, -1));

        jLabel1.setFont(new java.awt.Font("sansserif", 1, 24)); // NOI18N
        jLabel1.setText("Buscar");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 80, 140, -1));

        replaceField.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.NumberFormatter(java.text.NumberFormat.getIntegerInstance())));
        replaceField.setText("7");
        replaceField.setToolTipText("");
        replaceField.setFont(new java.awt.Font("sansserif", 0, 24)); // NOI18N
        getContentPane().add(replaceField, new org.netbeans.lib.awtextra.AbsoluteConstraints(260, 250, 130, -1));

        jLabel2.setFont(new java.awt.Font("sansserif", 1, 24)); // NOI18N
        jLabel2.setText("Reemplazar por");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 190, -1, -1));

        jScrollPane3.setViewportView(unfilteredList);

        getContentPane().add(jScrollPane3, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 50, 170, 530));

        generateButton.setFont(new java.awt.Font("sansserif", 1, 24)); // NOI18N
        generateButton.setText("Generar");
        generateButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                generateButtonActionPerformed(evt);
            }
        });
        getContentPane().add(generateButton, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 430, 170, 100));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void filterButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filterButtonActionPerformed
        // TODO add your handling code here:
        int valorBuscar = Integer.parseInt(searchField.getText());
        int valorReemplazar = Integer.parseInt(replaceField.getText());
        Reemplazar(unfilteredList, filteredList, valorBuscar, valorReemplazar);
    }//GEN-LAST:event_filterButtonActionPerformed

    private void searchFieldActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_searchFieldActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_searchFieldActionPerformed

    private void generateButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_generateButtonActionPerformed
        GenerateRandomNumbersInListWhatALongNameGoddammit(unfilteredList);
    }//GEN-LAST:event_generateButtonActionPerformed

    private void Reemplazar(JList lista1, JList lista2, int search, int replace){
        ListModel lista1Model = lista1.getModel();
        lista2.removeAll();
        DefaultListModel lista2Model = new DefaultListModel();
        
        Stack<Integer> stak = new Stack<>();
        
        for (int i = 0; i < lista1Model.getSize(); i++) {
            stak.push((Integer) lista1Model.getElementAt(i));
        }
        
        for (Integer integer : stak) {
            if (integer == search) {
                integer = replace;
            }
            lista2Model.addElement(integer);
        }
        lista2.setModel(lista2Model);
        
    }
    private void GenerateRandomNumbersInListWhatALongNameGoddammit(JList lista){
        Random rnd = new Random();
        DefaultListModel listaModel = new DefaultListModel();
        listaModel.removeAllElements();
        
        for (int i = 0; i < 30; i++) {
            listaModel.addElement(rnd.nextInt(11));
        }
        lista.setModel(listaModel);
        
    }
    
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
            java.util.logging.Logger.getLogger(Tarea8.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Tarea8.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Tarea8.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Tarea8.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Tarea8().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton filterButton;
    private javax.swing.JList<String> filteredList;
    private javax.swing.JButton generateButton;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JFormattedTextField replaceField;
    private javax.swing.JFormattedTextField searchField;
    private javax.swing.JList<String> unfilteredList;
    // End of variables declaration//GEN-END:variables
}
