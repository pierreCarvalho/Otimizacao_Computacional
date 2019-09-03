/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aula01;

import java.util.Scanner;

/**
 *
 * @author prof Mirkos
 */
public class Aula01 {
    
    int[] v = {1,2,3,5,7,9};
    /**
     * Método que imprime na console o vetor resultante
     * @param lista - vetor a ser mostrado
     */
    public void mostra(int[] lista){
        for(int index=0;index<lista.length;index++)
            System.out.print("\t"+lista[index]);
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Aula01 programa = new Aula01();
        Scanner console = new Scanner(System.in);
        System.out.println("Digite o valor a aplicar no vetor:");
        int valor = console.nextInt();
        System.out.println("Digite o sinal a aplicar: (+ ou -):");
        String sinal = console.next();
        
        for(int x=0;x<programa.v.length;x++){
            if(sinal.equals("+")){
                programa.v[x] = programa.v[x]+valor;
            }else{
                programa.v[x] = programa.v[x]-valor;
            }
        }//fim do for
        
        programa.mostra(programa.v);
        console.next();
    }
    
}