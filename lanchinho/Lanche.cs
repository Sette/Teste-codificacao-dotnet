using System;

class Lanche{
    private int id {get;set;}
    private double preco {get;set;}

    private string nome {get;set;}

    public Lanche(int id, string nome, double preco){
        this.nome = nome;
        this.preco = preco;
        this.id = id;
    }

    public override string ToString(){
        return $"{this.id} | {this.nome} | R$ {this.preco}";

    }

    public int getId(){
        return this.id;
    }

    public double getPreco(){
        return this.preco;
    }

}