import { Component, OnInit } from "@angular/core";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
import { Usuario } from "src/app/modelo/usuario";

@Component ({
    selector: "cadastro-usuario",
    templateUrl: "./cadastro.usuario.component.html",
    styleUrls: ["./cadastro.usuario.component.scss"]
})

export class CadastroUsuarioComponent implements OnInit{
    public usuario: Usuario; 
    public mensagem: string;
    public usuarioCadastrado: boolean;

    constructor(private usuarioServico: UsuarioServico) {
    }

    ngOnInit(): void {
        this.usuario = new Usuario();
    }
    
    cadastrar(){
        this.usuarioServico.cadastrarUsuario(this.usuario)
        .subscribe(
            
            usuarioJson =>{
                this.usuarioServico.usuario = usuarioJson;  
                this.usuarioCadastrado = true;
                this.mensagem="";
                console.log(this.usuario.email + this.usuario.senha +this.usuario.nome + this.usuario.sobreNome);
            },err =>{
                console.log(err.error);
                this.mensagem = err.error;
            });
    }
}
