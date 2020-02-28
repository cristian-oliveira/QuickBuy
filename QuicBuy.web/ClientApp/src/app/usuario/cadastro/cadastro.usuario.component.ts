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

    constructor(private usuarioServico: UsuarioServico) {
    
    
    }

    ngOnInit(): void {
        this.usuario = new Usuario();
    }
    
    public cadastrar(){
        this.usuarioServico.cadastrarUsuario(this.usuario);
            .subscribe(
                usuarioJson =>{
                    
                }
                err =>{

                }
            );
    }
}
