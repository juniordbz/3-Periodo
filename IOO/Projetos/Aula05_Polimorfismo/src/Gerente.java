/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author wolley
 */
public class Gerente extends Funcionario{
    private String setor;
    
    
    //declarar construtor
    public Gerente(String nome, int registro, double salario, String setor){
        super(nome, registro, salario); // construtor da super classe - Funcionario
        this.setor = setor;
    }
    
    public void setSetor(String setor){
        this.setor = setor;
    }
    
    
    public String getSetor(){
        return setor;
    }
    
    
 
    @Override
    public double calcularBonificacao(){
        return salario * 0.2;
    }
    
    
    
}
