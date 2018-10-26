using System;
using System.Collections.Generic;
class Pedido{
    
    private Dictionary<Lanche, int> lanches;


    public void inserirLanche(Lanche lanche, int quantidade){
        this.lanches = new Dictionary<Lanche, int>();
        this.lanches.Add(lanche,quantidade);   
    }

    

    public double getPrecoPedido(){
        double valor = 0.0;

        foreach(KeyValuePair<Lanche, int> entry in this.lanches)
        {
            valor += entry.Key.getPreco() * entry.Value;
        }

        return valor;
    }


}