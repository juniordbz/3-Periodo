/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio3;

/**
 *
 * @author Jóta
 */
public class Pessoas {
    
    //atributos da classe
    private String nome;
    private int cpf;
    private String rg;
    private int telefone;
    
    public void setNome (String nome){
        this.nome = nome;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setCpf(int cpf){
        this.cpf = cpf;
    }
    
    public int getCpf (){
        return cpf;
    }
    
    public void setRg (String rg){
        this.rg = rg;
    }
    
    public String getRg(){
        return rg;
    }
    
    public void setTelefone(int telefone){
        this.telefone = telefone;
    }
    
    public int getTelefone(){
        return telefone;
    }
}
