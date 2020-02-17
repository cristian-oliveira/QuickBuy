import { Component } from "@angular/core" //importacao do componente

@Component({ // fazer com que o produto funcione como componente
  selector: "produto", //onde o componente sera renderizado
  templateUrl: '/produto.component.html'
})
export class ProdutoCompenent { //semelhante ao public no c#; precisa ter export para que seja possivel realizar a importacao em app.module
  nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";

  }
  

}
