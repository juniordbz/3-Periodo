/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author wolley
 */
public class Aplicacao {
    
    public static void main(String[] args){
        Funcionario funcionario =  new Funcionario("Paulo", 456, 1500.0);
        /*
        funcionario.setNome("Paulo");
        funcionario.setRegistro(456);
        funcionario.setSalario(1500.0);
        */
        System.out.println("Bonificação Funcionario: "
                                 + funcionario.calcularBonificacao());
        
        //objeto da subclasse 
        funcionario = new Gerente("Andrea", 123, 5500.0, "TI");
        /*
        gerente.setNome("Andrea");
        gerente.setRegistro(123);
        gerente.setSalario(5500.0);
        gerente.setSetor("TI");
        */
        System.out.println("Bonificação Gerente: "
                                + funcionario.calcularBonificacao());
        
        //objeto da subclasse
        funcionario = new Diretor("Mario", 963, 10000.0, "SP");
        /*
        diretor.setNome("Mario");
        diretor.setRegistro(963);
        diretor.setSalario(10000.0);
        diretor.setUnidade("SP");*/
        
        System.out.println("Bonificação Diretor: "
                            + funcionario.calcularBonificacao());
        
       
        
    }
    
    
    
}
