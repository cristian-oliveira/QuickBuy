import { Component } from "@angular/core" //importacao do componente

@Component({ // fazer com que o produto funcione como componente
  selector: "produto", //onde o componente sera renderizado
  template:"<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoCompenent { //semelhante ao public no c#
  nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";

  }
  

}
