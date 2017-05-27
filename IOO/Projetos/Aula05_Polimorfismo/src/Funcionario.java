/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author wolley
 */
public class Funcionario {
    private String nome;
    private int registro;
    protected double salario; 
    
    public Funcionario(String nome, int registro, double salario){
        this.nome = nome;
        this.registro = registro;
        this.salario = salario;
    } 
    
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setRegistro(int registro){
        this.registro = registro;
    }
    public int getRegistro(){
        return registro;
       
    }
    
    
    public void setSalario(double salario){
        this.salario = salario;
    }
    
    public double getSalario(){
        return salario;
    }
    
    
    
    public double calcularBonificacao(){
        return salario * 0.1;
    }
}
