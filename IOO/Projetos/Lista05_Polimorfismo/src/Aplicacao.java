/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.util.Scanner;
/**
 *
 * @author 11161103810
 */
public class Aplicacao {
    
    public static void main (String [] args){
        
        Scanner sc = new Scanner (System.in);
        
        //CONTA PRINCIPAL    
        Conta c = new Conta("João",200);
        System.out.println("----- Conta -----");
        System.out.println("Saldo: " + c.getSaldo());
       // System.out.println("Extrato: " + c.imprimirExtrato());

        //CONTA CORRENTE
        ContaCorrente cc = new ContaCorrente("José",100);
        System.out.println("----- Conta Corrente -----");
        System.out.println("Saldo: " + cc.getSaldo());
        cc.imprimirExtrato();
        System.out.println("Extrato: " + cc.getSaldo());
        System.out.println("Saque: ");
        cc.saque(sc.nextByte());
        if (cc.saque(60)){
            System.out.println("Saque realizado com sucesso!");
        } else {
            System.out.println("Não foi possível realizar saque.");
        }
        cc.imprimirExtrato();
        System.out.println("Novo saldo " + cc.getSaldo());
         
        //CONTA UNIVERSITARIA
        ContaUniversitaria u = new ContaUniversitaria("Pedro",10);
        System.out.println("----- Conta Universitária -----");
        System.out.println("Saldo: " + u.getCredito());
        u.imprimirExtrato();    
        
    }
    
}
