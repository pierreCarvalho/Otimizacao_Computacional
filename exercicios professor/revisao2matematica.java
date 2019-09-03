/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vetorvetor;

import java.util.Scanner;

/**
 *
 * @author usrlab09
 */
public class Principal {

    int[] vetor = {1,2,3,4,5,6};
    
    public void mostraVetor(int[] vet){
        for(int index=0;index<vet.length;index++){
            System.out.print("\t"+vet[index]);
        }
        System.out.println("");
    }
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
            //Instancia objeto Principal
            Principal programa = new Principal();
            Scanner teclado = new Scanner(System.in);
            int[] vetorUsuario = new int[programa.vetor.length];
            
            for(int x=0;x<programa.vetor.length;x++){
                System.out.println("Digite um valor inteiro:");
                vetorUsuario[x] = teclado.nextInt();
            }
            System.out.println("Digite a operação: (soma,sub,mult,div):");
            String op = teclado.nextLine();
            
            for(int y=0;y<programa.vetor.length;y++){
                if(op.equals("soma")){programa.vetor[y]= programa.vetor[y]+vetorUsuario[y];}
                if(op.equals("sub")){programa.vetor[y]= programa.vetor[y]-vetorUsuario[y];}
                if(op.equals("mult")){programa.vetor[y]= programa.vetor[y]*vetorUsuario[y];}
                if(op.equals("div")){programa.vetor[y]= programa.vetor[y]/vetorUsuario[y];}
            }
            
            programa.mostraVetor(programa.vetor);
    }
    
}