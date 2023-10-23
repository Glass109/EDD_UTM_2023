/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package p2actv2;

import java.time.LocalDateTime;

/**
 *
 * @author glas1
 */
public class Cliente {
    
    String Nombre;
    String tipoDeOperacion;
    int numTurno;
    LocalDateTime fechaTiempo;

    public Cliente(String name, String operation, int turno, LocalDateTime tiempo ) {
        Nombre = name;
        tipoDeOperacion = operation;
        numTurno = turno;
        fechaTiempo = tiempo;
    }
    
}



