/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author wolley
 */
public class Diretor extends Funcionario{
    private String unidade;
    
    public Diretor(String nome, int registro, double salario, String unidade){
        super(nome, registro, salario);
        this.unidade = unidade;
    }
    
    public void setUnidade(String unidade){
        this.unidade = unidade;
    }
    
    
    public String getUnidade(){
        return unidade;
    }
    
    public double calcularBonificacao(){
        return salario * 0.3;
    }
    
}
