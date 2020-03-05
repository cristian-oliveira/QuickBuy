import { Component, OnInit } from "@angular/core" //importacao do componente
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Produto } from "../modelo/produto";

@Component({ // fazer com que o produto funcione como componente
  selector: "produto", //onde o componente sera renderizado
  templateUrl: '/produto.component.html',
  styleUrls: ["/produto.component.scss"]

})
export class ProdutoCompenent implements OnInit{
  public produto: Produto; 
  arquivoSelecionado: File;
  public mensagem: string;
  constructor(private produtoServico: ProdutoServico) {
   
  }  

  ngOnInit(){
    this.produto = new Produto();
  }
  public inputChange(files: FileList){
      this.arquivoSelecionado = files.item(0);
      this.produtoServico.enviarArquivo(this.arquivoSelecionado)
        .subscribe(
          nomeArquivo => {
            this.produto.nomeArquivo = nomeArquivo;
            alert(this.produto.nomeArquivo);
            console.log(nomeArquivo);
          },e => {
            console.log();
          }
        );

  }

  public cadastrar(){
    this.produtoServico.cadastrar(this.produto)
    .subscribe(
      produtoJson =>{
        console.log(produtoJson);
        // this.router.navigate(['/pesquisar-produto']);
      },
      e => {
        console.log(e.error);
        this.mensagem = e.error;
      }
    );
    

  }
}
