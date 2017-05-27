/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 11161103810
 */
public class ContaUniversitaria extends CaixaEletronico {
    private double credito = 200;
    
    
    
    //método de entrada e saída
    public void setCredito(double credito){
        this.credito = saldo;
    }
    public double getCredito(){
        return credito;
    }
    
   
    public void imprimirExtrato(){
        this.saldo = credito;
    }
    
    //sobreescrita 
    @Override
    public boolean saque (double valorSaque){
        if(super.saque(valorSaque)== false){
            credito -= valorSaque;
        return true;          
    }   
        return false;
    }
    
}
