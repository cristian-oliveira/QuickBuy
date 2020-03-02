import { Component, OnInit } from "@angular/core";
import { Usuario } from "src/app/modelo/usuario";
import { UsuarioServico } from "src/app/servicos/usuario/usuario.servico";

@Component ({
    selector: "cadastro-usuario",
    templateUrl: "./cadastro.usuario.component.html",
    styleUrls: ["./cadastro.usuario.component.scss"]
})

export class CadastroUsuarioComponent implements OnInit{
    public usuario: Usuario; 
    public mensagem: string;
    public returnUrl: string;
    constructor(private usuarioServico: UsuarioServico) {
    
    }

    ngOnInit(): void {
        this.usuario = new Usuario();
    }
    
    public cadastrar(){
        this.usuarioServico.cadastrarUsuario(this.usuario)
        .subscribe(
            usuarioJson =>{
                var usuarioRetorno: Usuario; //linha executada em execucao sem erros
                this.usuarioServico.usuario = usuarioJson
                // this.router.navigate([this.returnUrl]);       
             }
                ,err =>{
                    console.log(err.error);
                    this.mensagem = err.error;
                }
            );
    }
}
