using System;
using System.Collections.Generic;
class Lanchonete{
    private string nome {get;set;}
    private Dictionary<int, Lanche> lanches;

    public Dictionary<int, Lanche> getLanches(){
        return this.lanches;
    }

    public Lanchonete(string nome){
        lanches = new Dictionary<int, Lanche>();
        this.nome = nome;
    }

    public void inserirLanche(Lanche lanche){
        this.lanches.Add(lanche.getId(),lanche);   
    }

    public Lanche getLanche(int id){
        return this.lanches[id];
    }
}