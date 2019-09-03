
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author usrlab09
 */
public class Principal {

    public static void main(String[] args) {
        int[][][] matriz = new int[100][100][100];
        long tempoFim,tempoInicio,total = 0;
        Random random = new Random();
        
        tempoInicio = System.currentTimeMillis();
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                for (int k = 0; k < matriz.length; k++) {
                    matriz[i][j][k] = random.nextInt(10);
                }
            }
        }
        tempoFim = System.currentTimeMillis();
        total += tempoFim-tempoInicio;
        System.out.println("O tempo de gerar valores foi de: "+((tempoFim-tempoInicio))+" nanosegundos");
        
        tempoInicio = 0;
        tempoFim = 0;
        tempoInicio = System.currentTimeMillis();
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                for (int k = 0; k < matriz.length; k++) {
                    System.out.print(matriz[i][j][k]+"\t");
                }
                System.out.print("\n");
            }
        }
        tempoFim = System.currentTimeMillis();
        total += tempoFim-tempoInicio;
        System.out.println("O tempo de gerar valores foi de: "+((tempoFim-tempoInicio))+" nanosegundos");
        System.out.println("O total é: "+total);
    }
    
}
