/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 11161103810
 */
public class Conta {
    
    // atributos da classe CONTA
    private String nome;
    protected double saldo;
    private double valorSaque;
    private boolean saque;
  
    public Conta (String nome, double saldo){
        this.nome = nome;
        this.saldo = saldo;  
    }
     
    //SET GET
    public void setNome (String nome){
        this.nome = nome;
    }
    public String getNome (){
        return nome;
    }
    public void setSaldo (double saldo){
        this.saldo = saldo;
    }
    public double getSaldo (){
        return saldo;
    }
    
     //SAQUE
    public boolean saque (double valorSaque){
       if (saldo >= valorSaque){
           saldo -= valorSaque;
           return true;
        }
       return false;
    }
    
    //IMPRESSÃO EXTRATO
    public void imprimirExtrato(){
        saldo -= 0.5;
    }
    
    
    
    
    
    
    
      
    
}
