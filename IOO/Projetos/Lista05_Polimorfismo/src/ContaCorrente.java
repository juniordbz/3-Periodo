/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 11161103810
 */
public class ContaCorrente extends Conta {
    private double taxaExtrato = 0.5;
    
    public ContaCorrente (String nome, double saldo){
        super(nome, saldo);
        this.taxaExtrato = taxaExtrato;
    }
    
    public void setTaxaExtrato (double taxaExtrato){
        this.taxaExtrato = saldo;
    }
   
    
    
    
    
}
